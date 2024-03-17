using Library.Application.Db;
using LibraryApplication.Models.Entities;
using LibraryApplication.Services;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryApplication.Forms.ReaderForms
{
    public partial class ReaderForm : Form
    {
        private LibraryContext _context;
        private ReaderService _service;

        public ReaderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel = new ControlPanel();
            FormControls.readerForm.Hide();
            FormControls.controlPanel.Show();
        }

        private async void FillTable(string filterValue = "")
        {
            var readers = await _service.GetReaders();
            filterValue = textBox1.Text;

            var toShow = readers.Select(r => new ReaderEntity(r));

            var filterUsers = toShow.Where(r =>
                r.ReaderId.ToString().ToLower().Contains(filterValue.ToLower())
                || r.ReaderName.ToLower().Contains(filterValue.ToLower())
                || r.ReaderSurname.ToLower().Contains(filterValue.ToLower())
                || r.ReaderPassportNumber.ToLower().Contains(filterValue.ToLower())
                || r.StoredBooksId.ToLower().Contains(filterValue.ToLower()));

            if (filterUsers.Count() == 0)
            {
                filterUsers = toShow;
            }

            var bindingSource = new BindingSource();

            dataGridView1.ReadOnly = true;
            bindingSource.DataSource = filterUsers.ToList();
            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Имя читателя";
            dataGridView1.Columns[2].HeaderText = "Фамилия читателя";
            dataGridView1.Columns[3].HeaderText = "Паспортные данные читателя";
            dataGridView1.Columns[4].HeaderText = "Взятые книги (id)";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 120;

            dataGridView1.Font = new Font("Segoi UI", 9);
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new ReaderService(_context);
            FillTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application exApp = new Excel.Application();

                exApp.Workbooks.Add();

                Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

                wsh.Cells[1, 1] = dataGridView1.Columns[0].HeaderText;
                wsh.Cells[1, 2] = dataGridView1.Columns[1].HeaderText;
                wsh.Cells[1, 3] = dataGridView1.Columns[2].HeaderText;
                wsh.Cells[1, 4] = dataGridView1.Columns[3].HeaderText;
                wsh.Cells[1, 5] = dataGridView1.Columns[4].HeaderText;

                for (int lines = 0; lines < dataGridView1.RowCount; lines++)
                {
                    for (int columns = 0; columns < dataGridView1.ColumnCount; columns++)
                    {
                        wsh.Cells[lines + 2, columns + 1] = dataGridView1[columns, lines].Value.ToString();
                    }
                }

                exApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, возможно стоит переустановить MS EXCEL");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("Для удаления следует выбрать ячейку");
                return;
            }

            await _service.DeleteReader(int.Parse(id));

            FillTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addReaderForm = new AddReaderForm();
            FormControls.readerForm.Hide();
            FormControls.addReaderForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormControls.changeReaderForm = new ChangeReaderForm();
            FormControls.readerForm.Hide();
            FormControls.changeReaderForm.IdBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(); 
            FormControls.changeReaderForm.Show();
        }
    }
}

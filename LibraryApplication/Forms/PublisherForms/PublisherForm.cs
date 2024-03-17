using Excel = Microsoft.Office.Interop.Excel;
using Library.Application.Db;
using LibraryApplication.Services;

namespace LibraryApplication.Forms.PublisherForms
{
    public partial class PublisherForm : Form
    {
        private LibraryContext _context;
        private PublisherService _service;

        public PublisherForm()
        {
            InitializeComponent();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new PublisherService(_context);
            FillTable();
        }

        private async void FillTable(string filterValue = "")
        {

            var publishers = await _service.GetPublishers();

            var filterUsers = publishers.Where(g =>
                g.PublsherId.ToString().ToLower().Contains(filterValue.ToLower())
                || g.PublisherName.ToLower().Contains(filterValue.ToLower())
                );

            if (filterUsers.Count() == 0)
            {
                filterUsers = publishers;
            }

            var bindingSource = new BindingSource();

            dataGridView1.ReadOnly = true;
            bindingSource.DataSource = filterUsers;

            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Название издателя";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Font = new Font("Segoe UI", 9);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillTable(textBox1.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel = new ControlPanel();
            FormControls.publisherForm.Hide();
            FormControls.controlPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addPublisherForm = new AddPublisherForm();
            FormControls.publisherForm.Hide();
            FormControls.addPublisherForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormControls.changePublisherForm = new ChangePublisherForm();
            FormControls.changePublisherForm.IdBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            FormControls.publisherForm.Hide();
            FormControls.changePublisherForm.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("Для удаления следует выбрать ячейку");
                return;
            }

            await _service.DeletePublisher(int.Parse(id));

            FillTable();
        }
    }
}

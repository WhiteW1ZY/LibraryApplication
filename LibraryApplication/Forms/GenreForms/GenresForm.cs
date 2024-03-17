using Library.Application.Db;
using LibraryApplication.Services;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryApplication.Forms.GenreForms
{
    public partial class GenresForm : Form
    {
        private LibraryContext _context;
        private GenreService _service;

        public GenresForm()
        {
            InitializeComponent();
        }

        private async void FillTable(string filterValue = "")
        {

            var genres = await _service.GetGenres();

            var filterUsers = genres.Where(g =>
                g.GenreId.ToString().ToLower().Contains(filterValue.ToLower())
                || g.GenreName.ToLower().Contains(filterValue.ToLower())
                );

            if (filterUsers.Count() == 0)
            {
                filterUsers = genres;
            }

            var bindingSource = new BindingSource();

            dataGridView1.ReadOnly = true;
            bindingSource.DataSource = filterUsers;

            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Название жанра";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;

        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new GenreService(_context);
            FillTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel = new ControlPanel();
            FormControls.genresForm.Hide();
            FormControls.controlPanel.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("Для удаления следует выбрать ячейку");
                return;
            }

            await _service.DeleteGenre(int.Parse(id));

            FillTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillTable(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addGenreForm = new AddGenreForm();
            FormControls.genresForm.Hide();
            FormControls.addGenreForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormControls.changeGenreForm = new ChangeGenreForm();
            FormControls.changeGenreForm.IdBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            FormControls.genresForm.Hide();
            FormControls.changeGenreForm.Show();
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
    }
}

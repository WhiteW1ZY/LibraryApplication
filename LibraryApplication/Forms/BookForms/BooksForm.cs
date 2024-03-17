using Library.Application.Db;
using LibraryApplication.Models.Entities;
using LibraryApplication.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryApplication.Forms.BookForms
{
    public partial class BooksForm : Form
    {
        private LibraryContext _context;
        private BookService _service;

        public BooksForm()
        {
            InitializeComponent();
        }

        private async void FillTable(string filterValue = "", int index = 1)
        {
            var books = await _service.GetBooks();
            filterValue = textBox1.Text;

            var toShow = books.Select(b => new BookEntity(b.BookId, b.Title, b.BookCount, b.Author, b.YearOfPublish, b.genres, b.publishers, b.readers));

            var filterUsers = toShow.Where(b =>
                b.BookEntityId.ToString().ToLower().Contains(filterValue.ToLower())
                || b.publishers.ToLower().Contains(filterValue.ToLower())
                || b.BookCount.ToString().ToLower().Contains(filterValue.ToLower())
                || b.genres.ToLower().Contains(filterValue.ToLower())
                || b.readers.ToLower().Contains(filterValue.ToLower())
                || b.Title.ToLower().Contains(filterValue.ToLower())
                || b.Author.ToLower().Contains(filterValue.ToLower())
                || b.YearOfPublish.ToString().ToLower().Contains(filterValue.ToLower())
                );

            if (filterUsers.Count() == 0)
            {
                filterUsers = toShow;
            }

            IEnumerable<BookEntity> result = null!;

            switch (index)
            {
                case 1: result = filterUsers.OrderBy(b => b.BookEntityId); break;
                case 2: result = filterUsers.OrderBy(b => b.Author); break;
                case 3: result = filterUsers.OrderBy(b => b.Title); break;
                case 4: result = filterUsers.OrderBy(b => b.YearOfPublish); break;
                case 5: result = filterUsers.OrderBy(b => b.BookCount); break;
                case 6: result = filterUsers.OrderBy(b => b.genres); break;
                case 7: result = filterUsers.OrderBy(b => b.publishers); break;
                case 8: result = filterUsers.OrderBy(b => b.readers); break;
            }

            var bindingSource = new BindingSource();

            dataGridView1.ReadOnly = true;
            bindingSource.DataSource = result.ToList();
            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Название книги";
            dataGridView1.Columns[2].HeaderText = "Автор книги";
            dataGridView1.Columns[3].HeaderText = "Дата публикации";
            dataGridView1.Columns[4].HeaderText = "Актуальное количество";
            dataGridView1.Columns[5].HeaderText = "Жанры";
            dataGridView1.Columns[6].HeaderText = "Издатели";
            dataGridView1.Columns[7].HeaderText = "ID читателей";

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 180;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 100;

            dataGridView1.Font = new Font("Segoi UI", 7);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new BookService(_context);
            FillTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel = new ControlPanel();
            FormControls.booksForm.Hide();
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

            await _service.DeleteBook(int.Parse(id));

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
                wsh.Cells[1, 6] = dataGridView1.Columns[5].HeaderText;
                wsh.Cells[1, 7] = dataGridView1.Columns[6].HeaderText;
                wsh.Cells[1, 8] = dataGridView1.Columns[7].HeaderText;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillTable(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addBookForm = new AddBookForm();
            FormControls.booksForm.Hide();
            FormControls.addBookForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormControls.changeBookForm = new ChangeBookForm();
            FormControls.changeBookForm.IdBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            FormControls.booksForm.Hide();
            FormControls.changeBookForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FillTable(index: 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FillTable(index: 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FillTable(index: 3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FillTable(index: 4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FillTable(index: 5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FillTable(index: 6);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FillTable(index: 7);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FillTable(index: 8);
        }
    }
}

using Library.Application.Db;
using LibraryApplication.Services;
using System.Windows.Forms;

namespace LibraryApplication.Forms.GenreForms
{
    public partial class ChangeGenreForm : Form
    {
        private LibraryContext _context;
        private GenreService _service;

        public ChangeGenreForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.genresForm = new GenresForm();
            FormControls.changeGenreForm.Hide();
            FormControls.genresForm.Show();
        }

        private void ChangeGenreForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new GenreService(_context);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameText.Text))
            {
                MessageBox.Show("Название жанра не может быть пустым");
                return;
            }

            var id = int.Parse(IdBox.Text);
            await _service.UpdateGenre(id, UserNameText.Text);

            FormControls.genresForm = new GenresForm();
            FormControls.changeGenreForm.Hide();
            FormControls.genresForm.Show();
        }
    }
}

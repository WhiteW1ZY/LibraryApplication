
using Library.Application.Db;
using LibraryApplication.Models;
using LibraryApplication.Services;

namespace LibraryApplication.Forms.GenreForms
{
    public partial class AddGenreForm : Form
    {
        private LibraryContext _context;
        private GenreService _service;

        public AddGenreForm()
        {
            InitializeComponent();
        }

        private void AddGenreForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new GenreService(_context);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addGenreForm.Hide();
            FormControls.genresForm = new GenresForm();
            FormControls.genresForm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("Название жанра не может быть пустым");
                return;
            }
            var genres = await _service.GetGenres();
            var alreadyExist = genres.FirstOrDefault(g => g.GenreName == NameText.Text);

            if(alreadyExist != null) 
            {
                MessageBox.Show("Жанр с таким именем уже существует");
                return;
            }

            await _service.CreateGenre(new Genre { GenreName = NameText.Text });

            FormControls.addGenreForm.Hide();
            FormControls.genresForm = new GenresForm();
            FormControls.genresForm.Show();
        }
    }
}

using Library.Application.Db;
using LibraryApplication.Models;
using LibraryApplication.Services;
namespace LibraryApplication.Forms.BookForms
{
    public partial class AddBookForm : Form
    {
        private LibraryContext _context;

        private BookService _service;
        private GenreService _genreService;
        private PublisherService _publisherService;
        private ReaderService _readerService;

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new BookService(_context);
            _genreService = new GenreService(_context);
            _publisherService = new PublisherService(_context);
            _readerService = new ReaderService(_context);

            FillGenresBox();
            FillPublishersBox();
            FillReadersBox();
        }

        private async void FillReadersBox()
        {
            listBox3.Items.Clear();
            listBox3.SelectionMode = SelectionMode.MultiSimple;

            var readers = await _readerService.GetReaders();

            foreach (var reader in readers)
            {
                listBox3.Items.Add(reader.ReaderPassportNumber);
            }
        }

        private async void FillGenresBox()
        {
            listBox1.Items.Clear();
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            var genres = await _genreService.GetGenres();

            foreach (var genre in genres)
            {
                listBox1.Items.Add(genre.GenreName);
            }
        }
        private async void FillPublishersBox()
        {
            listBox2.Items.Clear();
            listBox2.SelectionMode = SelectionMode.MultiSimple;

            var publishers = await _publisherService.GetPublishers();

            foreach (var publisher in publishers)
            {
                listBox2.Items.Add(publisher.PublisherName);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.booksForm = new BooksForm();
            FormControls.addBookForm.Hide();
            FormControls.booksForm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var bookName = NameText.Text;
            var bookAuthor = authorText.Text;
            var bookCount = countText.Text;
            var yearofPublis = yearText.Text;

            if (string.IsNullOrEmpty(bookName)
                || string.IsNullOrEmpty(bookAuthor)
                || string.IsNullOrEmpty(bookCount)
                || string.IsNullOrEmpty(yearofPublis)
                )
            {
                MessageBox.Show("Основные поля не могут быть пустыми");
                return;
            }

            try
            {
                int bookcount = int.Parse(bookCount);
                int year = int.Parse(yearofPublis);
                if (bookcount < 0 || year < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Количество книг и год публикации должны положительными числами. ");
                return;
            }

            if(listBox3.SelectedItems.Count > int.Parse(bookCount))
            {
                MessageBox.Show("Количество выбранных читателей не может быть больше чем количество книг.");
                return;
            }

            var book = new Book() { Title = bookName, Author = bookAuthor, BookCount = int.Parse(bookCount), YearOfPublish = int.Parse(yearofPublis), publishers = new List<Publisher>(), genres = new List<Genre>(), readers = new List<Reader>() };

            var _genres = await _genreService.GetGenres();

            foreach (var genreName in listBox1.SelectedItems) {

                book.genres.Add(_genres.FirstOrDefault(g => g.GenreName == genreName.ToString()));
            }

            var _publishers = await _publisherService.GetPublishers();

            foreach (var publisherName in listBox2.SelectedItems)
            {
                book.publishers.Add(_publishers.FirstOrDefault(p => p.PublisherName == publisherName.ToString()));
            }

            var _readers = await _readerService.GetReaders();

            foreach (var readersPassport in listBox3.SelectedItems)
            {
                book.readers.Add(_readers.FirstOrDefault(r => r.ReaderPassportNumber == readersPassport.ToString()));
            }

            book.BookCount = book.BookCount - book.readers.Count;

            await _service.CreateBook(book);

            FormControls.booksForm = new BooksForm();
            FormControls.addBookForm.Hide();
            FormControls.booksForm.Show();
        }
    }
}

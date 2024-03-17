using Library.Application.Db;
using LibraryApplication.Models;
using LibraryApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApplication.Forms.BookForms
{
    public partial class ChangeBookForm : Form
    {
        private LibraryContext _context;

        private BookService _service;
        private GenreService _genreService;
        private PublisherService _publisherService;
        private ReaderService _readerService;

        private Book currentBook;

        public ChangeBookForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.booksForm = new BooksForm();
            FormControls.changeBookForm.Hide();
            FormControls.booksForm.Show();
        }

        private async void ChangeBookForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new BookService(_context);
            _genreService = new GenreService(_context);
            _publisherService = new PublisherService(_context);
            _readerService = new ReaderService(_context);

            var books = await _service.GetBooks();
            currentBook = books.FirstOrDefault(b => b.BookId == int.Parse(IdBox.Text));

            NameText.Text = currentBook.Title;
            authorText.Text = currentBook.Author;
            countText.Text = currentBook.BookCount.ToString();
            yearText.Text = currentBook.YearOfPublish.ToString();

            FillGenresBox();
            FillPublishersBox();
            FillReadersBox();
        }
        private async void FillReadersBox()
        {
            var books = await _service.GetBooks();
            currentBook = books.FirstOrDefault(b => b.BookId == int.Parse(IdBox.Text));

            listBox3.Items.Clear();
            listBox3.SelectionMode = SelectionMode.MultiSimple;

            var readers = await _readerService.GetReaders();

            foreach (var reader in readers)
            {
                listBox3.Items.Add(reader.ReaderPassportNumber);

            }

            foreach (var reader in currentBook.readers)
            {
                listBox3.SelectedIndex = listBox3.FindString(reader.ReaderPassportNumber);
            }
        }

        private async void FillGenresBox()
        {
            var books = await _service.GetBooks();
            currentBook = books.FirstOrDefault(b => b.BookId == int.Parse(IdBox.Text));

            listBox1.Items.Clear();
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            var genres = await _genreService.GetGenres();

            foreach (var genre in genres)
            {
                listBox1.Items.Add(genre.GenreName);
            }
            foreach (var genre in currentBook.genres)
            {
                listBox1.SelectedIndex = listBox1.FindString(genre.GenreName);
            }
        }
        private async void FillPublishersBox()
        {
            var books = await _service.GetBooks();
            currentBook = books.FirstOrDefault(b => b.BookId == int.Parse(IdBox.Text));

            listBox2.Items.Clear();
            listBox2.SelectionMode = SelectionMode.MultiSimple;

            var publishers = await _publisherService.GetPublishers();

            foreach (var publisher in publishers)
            {
                listBox2.Items.Add(publisher.PublisherName);
            }

            foreach (var publisher in currentBook.publishers)
            {
                listBox2.SelectedIndex = listBox2.FindString(publisher.PublisherName);
            }
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

            var book = new Book() { Title = bookName, Author = bookAuthor, BookCount = int.Parse(bookCount), YearOfPublish = int.Parse(yearofPublis), publishers = new List<Publisher>(), genres = new List<Genre>(), readers = new List<Reader>() };

            var currentBooks = await _service.GetBooks();
            currentBook = currentBooks.FirstOrDefault(b => b.BookId == int.Parse(IdBox.Text));

            int currentBooksCount = currentBook.readers.Count();

            book.BookCount += currentBooksCount;


            if (listBox3.SelectedItems.Count > book.BookCount)
            {
                MessageBox.Show("Количество выбранных читателей не может быть больше чем количество книг.");
                return;
            }

            var _genres = await _genreService.GetGenres();

            foreach (var genreName in listBox1.SelectedItems)
            {

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

            book.BookCount -= book.readers.Count();

            await _service.UpdateBook(int.Parse(IdBox.Text), book);

            FormControls.booksForm = new BooksForm();
            FormControls.changeBookForm.Hide();
            FormControls.booksForm.Show();
        }
    }
}

using Library.Application.Db;
using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Services
{
    public class BookService
    {
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _context.Books
                .Include(b => b.genres)
                .Include(b => b.publishers)
                .Include(b => b.readers)
                .ToListAsync(); ;
        }

        public async Task<int> CreateBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book.BookId;
        }

        public async Task<int> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book != null) 
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
            return id;
        }

        public async Task<int> UpdateBook(
            int id, 
            Book book)
        {
            var _book = await _context.Books.FindAsync(id);
            if(_book != null) 
            {
                _book.Author = book.Author;
                _book.YearOfPublish = book.YearOfPublish;
                _book.publishers = book.publishers;
                _book.Title = book.Title;
                _book.genres = book.genres;
                _book.readers = book.readers;
                _book.BookCount = book.BookCount;

                await _context.SaveChangesAsync();
            }
            return id;
        }
    }
}

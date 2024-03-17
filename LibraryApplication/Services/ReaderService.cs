using Library.Application.Db;
using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Services
{
    public class ReaderService
    {
        private readonly LibraryContext _context;

        public ReaderService(LibraryContext context) 
        {
            _context = context;
        }

        public async Task<List<Reader>> GetReaders()
        {
            return await _context.Readers.Include(r=>r.StoredBooks).ToListAsync();
        }
        public async Task<int> DeleteReader(int id)
        {
            var reader = await _context.Readers.FindAsync(id);
            if (reader != null)
            {
                foreach(var book in reader.StoredBooks)
                {
                    book.BookCount += 1;
                }

                _context.Readers.Remove(reader);
                await _context.SaveChangesAsync();
            }
            return reader.ReaderId;
        }

        public async Task<int> AddReader(Reader reader)
        {
            await _context.Readers.AddAsync(reader);
            await _context.SaveChangesAsync();
            return reader.ReaderId;
        }

        public async Task<int> UpdateReadet(int id, Reader reader)
        {
            var r = await _context.Readers.FindAsync(id);
            r.ReaderName = reader.ReaderName;
            r.ReaderSurname = reader.ReaderSurname;
            r.ReaderPassportNumber = reader.ReaderPassportNumber;
            await _context.SaveChangesAsync();

            return r.ReaderId;
        }
    }
}

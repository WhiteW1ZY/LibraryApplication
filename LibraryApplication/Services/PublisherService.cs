using Library.Application.Db;
using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Services
{
    public class PublisherService
    {
        private readonly LibraryContext _context;

        public PublisherService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<int> CreatePublisher(Publisher publisher)
        {
            await _context.Publishers.AddAsync(publisher);
            await _context.SaveChangesAsync();
            return publisher.PublsherId;
        }
        public async Task<int> DeletePublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher != null)
            {
                _context.Publishers.Remove(publisher);
                await _context.SaveChangesAsync();
            }
            return publisher.PublsherId;
        }

        public async Task<int> UpdatePublisher(int id, string PublisherName)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher != null)
            {
                publisher.PublisherName = PublisherName;
            }
            await _context.SaveChangesAsync();
            return id;
        }

        public async Task<List<Publisher>> GetPublishers()
        {
            var publishers = await _context.Publishers.ToListAsync();
            return publishers;
        }
    }
}

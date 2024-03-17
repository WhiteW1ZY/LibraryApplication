using Library.Application.Db;
using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Services
{
    public class GenreService
    {
        private readonly LibraryContext _context;

        public GenreService(LibraryContext context) 
        {
            _context = context;
        }

        public async Task<int> CreateGenre(Genre genre)
        {
            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();
            return genre.GenreId;
        }
        public async Task<int> DeleteGenre(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre != null)
            {
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
            }
            return genre.GenreId;
        }

        public async Task<int> UpdateGenre(int id, string GenreName)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre != null)
            {
                genre.GenreName = GenreName;
            }
            await _context.SaveChangesAsync();
            return id;
        }

        public async Task<List<Genre>> GetGenres()
        {
            var genres = await _context.Genres.ToListAsync();
            return genres;
        }

    }
}

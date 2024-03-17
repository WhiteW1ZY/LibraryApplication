using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LibraryApplication.Models.Entities
{
    public class BookEntity
    {
        public int BookEntityId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }

        public int YearOfPublish { get; set; }
        public int BookCount { get; set; }

        public string genres { get; set; }
        public string publishers { get; set; }

        public string readers { get; set; }

        public BookEntity(int bookId, string title, int bookCount, string author, int yearOfPublish, List<Genre> Genres, List<Publisher> Publishers, List<Reader> Readers)
        {
            BookEntityId = bookId;
            Title = title;
            BookCount = bookCount;
            Author = author;
            YearOfPublish = yearOfPublish;
            genres = string.Empty;

            if(Genres.Count == 0)
            {
                genres = "Не найдено";
            }
            else
            {
                for(int element = 0; element < Genres.Count; element++) 
                {
                    genres += Genres[element].GenreName;
                    if(element!=Genres.Count - 1)
                    {
                        genres += ",";
                    }
                }
            }

            publishers = string.Empty;

            if (Publishers.Count == 0)
            {
                publishers = "Не найдено";
            }
            else
            {
                for (int element = 0; element < Publishers.Count; element++)
                {
                    publishers += Publishers[element].PublisherName;
                    if (element != Publishers.Count - 1)
                    {
                        publishers += ",";
                    }
                }
            }

            readers = string.Empty;

            if (Readers.Count == 0)
            {
                readers = "Не найдено";
            }
            else
            {
                for (int element = 0; element < Readers.Count; element++)
                {
                    readers += Readers[element].ReaderId;
                    if (element != Readers.Count - 1)
                    {
                        readers += ",";
                    }
                }
            }
        }
    }
}

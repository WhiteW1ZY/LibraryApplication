
namespace LibraryApplication.Models.Entities
{
    public class ReaderEntity
    {
        public int ReaderId { get; set; }

        public string ReaderName { get; set; }
        public string ReaderSurname { get; set; }

        public string ReaderPassportNumber { get; set; }

        public string StoredBooksId { get; set; }

        public ReaderEntity(Reader reader)
        {
            ReaderId = reader.ReaderId;
            ReaderName = reader.ReaderName;
            ReaderSurname = reader.ReaderSurname;
            ReaderPassportNumber = reader.ReaderPassportNumber;
            StoredBooksId = string.Empty;
            if (reader.StoredBooks.Count == 0)
            {
                StoredBooksId = "не найдено";
            }
            for(int element = 0; element < reader.StoredBooks.Count; element++)
            {
                StoredBooksId += reader.StoredBooks[element].BookId;
                if (element != reader.StoredBooks.Count - 1)
                {
                    StoredBooksId += ", ";
                }
            }
        }

    }
}

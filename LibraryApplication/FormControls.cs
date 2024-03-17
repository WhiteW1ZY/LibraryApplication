using LibraryApplication.Forms.BookForms;
using LibraryApplication.Forms.GenreForms;
using LibraryApplication.Forms.PublisherForms;
using LibraryApplication.Forms.ReaderForms;

namespace LibraryApplication
{
    public static class FormControls
    {
        public static Авторизация authorization = new Авторизация();
        public static ControlPanel controlPanel = new ControlPanel();

        public static UsersForm usersForm = new UsersForm();
        public static AddUserForm addUserForm = new AddUserForm();  
        public static ChangeUserForm changeUserForm = new ChangeUserForm();

        public static GenresForm genresForm = new GenresForm();
        public static AddGenreForm addGenreForm = new AddGenreForm();
        public static ChangeGenreForm changeGenreForm = new ChangeGenreForm();

        public static PublisherForm publisherForm = new PublisherForm();
        public static AddPublisherForm addPublisherForm = new AddPublisherForm();
        public static ChangePublisherForm changePublisherForm = new ChangePublisherForm();

        public static BooksForm booksForm = new BooksForm();
        public static AddBookForm addBookForm = new AddBookForm();
        public static ChangeBookForm changeBookForm = new ChangeBookForm();

        public static ReaderForm readerForm = new ReaderForm();
        public static ChangeReaderForm changeReaderForm = new ChangeReaderForm();
        public static AddReaderForm addReaderForm = new AddReaderForm();

    }
}

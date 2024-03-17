namespace LibraryApplication
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel.Hide();
            FormControls.authorization = new Авторизация();
            FormControls.authorization.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel.Hide();
            FormControls.usersForm = new UsersForm();
            FormControls.usersForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel.Hide();
            FormControls.genresForm = new Forms.GenreForms.GenresForm();
            FormControls.genresForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel.Hide();
            FormControls.publisherForm = new Forms.PublisherForms.PublisherForm();
            FormControls.publisherForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel.Hide();
            FormControls.booksForm = new Forms.BookForms.BooksForm();
            FormControls.booksForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormControls.readerForm = new Forms.ReaderForms.ReaderForm();
            FormControls.controlPanel.Hide();
            FormControls.readerForm.Show();
        }
    }
}

using Library.Application.Db;
using LibraryApplication.Services;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Forms.PublisherForms
{
    public partial class ChangePublisherForm : Form
    {
        private LibraryContext _context;
        private PublisherService _service;

        public ChangePublisherForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.changeGenreForm.Hide();
            FormControls.publisherForm = new PublisherForm();
            FormControls.publisherForm.Show();
        }

        private void ChangePublisherForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new PublisherService(_context);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameText.Text))
            {
                MessageBox.Show("Имя издателя не может быть пустым");
                return;
            }

            var id = int.Parse(IdBox.Text);
            await _service.UpdatePublisher(id, UserNameText.Text);

            FormControls.changeGenreForm.Hide();
            FormControls.publisherForm = new PublisherForm();
            FormControls.publisherForm.Show();
        }
    }
}

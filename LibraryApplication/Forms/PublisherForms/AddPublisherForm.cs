using Library.Application.Db;
using LibraryApplication.Forms.GenreForms;
using LibraryApplication.Models;
using LibraryApplication.Services;
namespace LibraryApplication.Forms.PublisherForms
{
    public partial class AddPublisherForm : Form
    {
        private LibraryContext _context;
        private PublisherService _service;

        public AddPublisherForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addPublisherForm.Hide();
            FormControls.publisherForm = new PublisherForm();
            FormControls.publisherForm.Show();
        }

        private void AddPublisherForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new PublisherService(_context);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("Имя издателя не может быть пустым");
                return;
            }
            var pbl = await _service.GetPublishers();
            var alreadyExist = pbl.FirstOrDefault(p => p.PublisherName == NameText.Text);

            if (alreadyExist != null)
            {
                MessageBox.Show("Издатель с таким именем уже существует");
                return;
            }

            await _service.CreatePublisher(new Publisher { PublisherName = NameText.Text });

            FormControls.addPublisherForm.Hide();
            FormControls.publisherForm = new PublisherForm();
            FormControls.publisherForm.Show();
        }
    }
}

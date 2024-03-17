using Library.Application.Db;
using LibraryApplication.Services;
using System;
using System.Collections.Generic;
namespace LibraryApplication.Forms.ReaderForms
{
    public partial class AddReaderForm : Form
    {
        private LibraryContext _context;
        private ReaderService _service;

        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.readerForm = new ReaderForm();
            FormControls.addReaderForm.Hide();
            FormControls.readerForm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            string surname = textBox1.Text;
            string passport = textBox2.Text;

            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(surname)
                || string.IsNullOrEmpty(passport))
            {
                MessageBox.Show("Поля не могут быть пусты");
                return;
            }

            var readers = await _service.GetReaders();

            foreach (var reader in readers)
            {
                if (reader.ReaderPassportNumber == passport)
                {
                    MessageBox.Show("Читатель с такими пасспортными данными уже зарегистрирован");
                    return;
                }
            }

            await _service.AddReader(new Models.Reader() { ReaderName = name, ReaderPassportNumber = passport, ReaderSurname = surname });

            FormControls.readerForm = new ReaderForm();
            FormControls.addReaderForm.Hide();
            FormControls.readerForm.Show();
        }

        private void AddReaderForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new ReaderService(_context);
        }
    }
}

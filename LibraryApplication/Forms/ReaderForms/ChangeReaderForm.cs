using Library.Application.Db;
using LibraryApplication.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace LibraryApplication.Forms.ReaderForms
{
    public partial class ChangeReaderForm : Form
    {
        private LibraryContext _context;
        private ReaderService _service;

        public ChangeReaderForm()
        {
            InitializeComponent();
        }

        private async void ChangeReaderForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new ReaderService(_context);

            var reader = await _context.Readers.FindAsync(int.Parse(IdBox.Text));
            NameText.Text = reader.ReaderName;
            textBox1.Text = reader.ReaderSurname;
            textBox2.Text = reader.ReaderPassportNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.readerForm = new ReaderForm();
            FormControls.changeReaderForm.Hide();
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
            await _service.UpdateReadet(int.Parse(IdBox.Text), new Models.Reader() { ReaderName = name, ReaderPassportNumber = passport, ReaderSurname = surname });

            FormControls.readerForm = new ReaderForm();
            FormControls.changeReaderForm.Hide();
            FormControls.readerForm.Show();
        }
    }
}

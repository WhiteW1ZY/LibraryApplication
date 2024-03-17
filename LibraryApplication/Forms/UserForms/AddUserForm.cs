using Library.Application.Db;
using Library.ApplicationLogic.Services;
using Library.Core.Models;

namespace LibraryApplication
{
    public partial class AddUserForm : Form
    {
        private LibraryContext _context;
        private UserService _service;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addUserForm.Hide();
            FormControls.usersForm = new UsersForm();
            FormControls.usersForm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameText.Text)
                || string.IsNullOrEmpty(UserPasswordBox.Text))
            {
                MessageBox.Show("Имя пользователя и пароль не могут быть пустыми");
                return;
            }

            var user = new User { Name = UserNameText.Text, Password = UserPasswordBox.Text };
            await _service.CreateUser(user);

            FormControls.addUserForm.Hide();
            FormControls.usersForm = new UsersForm();
            FormControls.usersForm.Show();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new UserService(_context);
        }
    }
}

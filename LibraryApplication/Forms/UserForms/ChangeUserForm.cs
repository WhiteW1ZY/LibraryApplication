using Library.Application.Db;
using Library.ApplicationLogic.Services;
using Library.Core.Models;
namespace LibraryApplication
{
    public partial class ChangeUserForm : Form
    {
        private LibraryContext _context;
        private UserService _service;

        public ChangeUserForm()
        {
            InitializeComponent();
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new UserService(_context);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.usersForm = new UsersForm();
            FormControls.changeUserForm.Hide();
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

            int id = int.Parse(IdBox.Text);

            await _service.UpdateUser(id,UserNameText.Text,UserPasswordBox.Text);

            FormControls.usersForm = new UsersForm();
            FormControls.changeUserForm.Hide();
            FormControls.usersForm.Show();
        }
    }
}

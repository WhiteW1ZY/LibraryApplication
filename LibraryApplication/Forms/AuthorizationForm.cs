using Library.Application.Db;
using Library.ApplicationLogic.Services;

namespace LibraryApplication
{
    public partial class Авторизация : Form
    {
        private LibraryContext _context;
        private UserService _service;

        public Авторизация()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new UserService(_context);
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string login = loginBox.Text;
            string password = passwordBox.Text;

            var user = await _service.GetUserFromAuth(login, password);

            if (user == null)
            {
                MessageBox.Show("Неверный логин и/или пароль");
            }
            else
            {
                FormControls.authorization.Hide();
                FormControls.controlPanel = new ControlPanel();
                FormControls.controlPanel.Show();
            }
        }

        private void loginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}

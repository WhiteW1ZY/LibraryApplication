using Library.Application.Db;
using Library.ApplicationLogic.Services;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryApplication
{
    public partial class UsersForm : Form
    {
        private LibraryContext _context;
        private UserService _service;

        public UsersForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormControls.controlPanel = new ControlPanel();
            FormControls.usersForm.Hide();
            FormControls.controlPanel.Show();
        }

        private async void FillTable(string filterValue = "")
        {

            var users = await _service.GetUsers();

            var filterUsers = users.Where(u =>
                u.UserId.ToString().ToLower().Contains(filterValue.ToLower())
                || u.Password.ToLower().Contains(filterValue.ToLower())
                || u.Name.ToLower().Contains(filterValue.ToLower())
                );

            if (filterUsers.Count() == 0)
            {
                filterUsers = users;
            }

            var bindingSource = new BindingSource();

            dataGridView1.ReadOnly = true;
            bindingSource.DataSource = filterUsers;

            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Имя пользователя";
            dataGridView1.Columns[2].HeaderText = "Пароль пользователя";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            _context = new LibraryContext();
            _service = new UserService(_context);
            FillTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormControls.addUserForm = new AddUserForm();
            FormControls.usersForm.Hide();
            FormControls.addUserForm.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("Для удаления следует выбрать ячейку");
                return;
            }

            await _service.DeleteUser(int.Parse(id));

            FillTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormControls.changeUserForm = new ChangeUserForm();
            FormControls.usersForm.Hide();
            FormControls.changeUserForm.IdBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            FormControls.changeUserForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillTable(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application exApp = new Excel.Application();

                exApp.Workbooks.Add();

                Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

                wsh.Cells[1, 1] = dataGridView1.Columns[0].HeaderText;
                wsh.Cells[1, 2] = dataGridView1.Columns[1].HeaderText;
                wsh.Cells[1, 3] = dataGridView1.Columns[2].HeaderText;

                for (int lines = 0; lines < dataGridView1.RowCount; lines++)
                {
                    for (int columns = 0; columns < dataGridView1.ColumnCount; columns++)
                    {
                        wsh.Cells[lines + 2, columns + 1] = dataGridView1[columns, lines].Value.ToString();
                    }
                }

                exApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, возможно стоит переустановить MS EXCEL");
            }
        }
    }
}

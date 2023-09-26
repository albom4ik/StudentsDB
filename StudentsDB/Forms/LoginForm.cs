using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace StudentsDB
{
    public partial class LoginForm : Form
    {
        private readonly string _connectionString;

        public LoginForm()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            InitializeComponent();
        }

        private async void Entry_Click(object sender, EventArgs e)
        {

            string login = LoginField.Text;
            string password = PasswordField.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrWhiteSpace(login)) 
            {
                MessageBox.Show("Поле логина не заполнено!");
                return;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Поле пароля не заполнено!");
                return;
            }

            using (var connection = new SqlConnection(_connectionString)) 
            {
                var query = "SELECT * FROM Users WHERE Login = @login AND Password = @password";
                var command = new SqlCommand(query, connection);

                var loginParameter = new SqlParameter("@login", login);
                var passwordParameter = new SqlParameter("@password", password);

                command.Parameters.Add(loginParameter);
                command.Parameters.Add(passwordParameter);

                connection.Open();

                var reader = await command.ExecuteReaderAsync();

                if (reader.Read()) 
                {
                    connection.Close();
                    Context.LogInSystem(login);

                    Hide();
                    new ChooseTable().Show();
                } else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) =>
            Process.GetCurrentProcess().Kill();
    }
}

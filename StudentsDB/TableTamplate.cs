using StudentsDB.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentsDB
{
    public partial class TableTamplate : Form, IForm
    {
        private readonly string _connection;
        public TableTamplate()
        {
            InitializeComponent();
            _connection = "Data Source=DESKTOP-MOL1088\\SQLEXPRESS; Initial Catalog=Students; Integrated Security=true; TrustServerCertificate=True;";
        }

        private void InitializeDataGridView()
        {
            try
            {
                dataGridView1.Dock = DockStyle.Fill;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
        }

        private void TableTamplate_Load(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(_connection);

            //try
            //{
            //    connection.Open();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message, "Ошибка соединения с базой данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    if (connection.State == ConnectionState.Open)
            //    {
            //        connection.Close();
            //    }
            //}
        }

        public void DisplayToDataGridView(DataSet dataSet)
        {
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}

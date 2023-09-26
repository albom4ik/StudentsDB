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
        }

        public void DisplayToDataGridView(DataSet dataSet)
        {
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Hide();
            new ChooseTable().Show();
        }
    }
}

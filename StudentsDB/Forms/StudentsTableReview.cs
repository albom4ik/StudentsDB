using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDB.Forms
{
    public partial class StudentsTableReview : Form
    {
        private readonly string _connectionString;

        public StudentsTableReview()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        private async void StudentsTableReview_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM Students ORDER BY Gender";
                var command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];

                dataGridView1.Columns[0].HeaderText = "ID студента";
                dataGridView1.Columns[1].HeaderText = "ФИО";
                dataGridView1.Columns[2].HeaderText = "Пол";
                dataGridView1.Columns[3].HeaderText = "Дата рождения";
                dataGridView1.Columns[4].HeaderText = "Родители";
                dataGridView1.Columns[5].HeaderText = "Адрес";

                connection.Close();
            }
        }
    }
}
using StudentsDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDB.Abstract
{
    public class FormModelAbstract<T> where T : Form
    {
        private readonly T _form;
        private readonly string _connectionString;
        protected string _query;

        public FormModelAbstract(T form, string connectionString) 
            => (_form, _connectionString) = (form, connectionString);

        public virtual void SetTitle(string title) 
        {
            _form.Text = title;
        }

        public virtual void OpenForm() => _form.Show();

        public virtual void SetQuery(string query) => _query = query;

        public virtual DataSet MakeQuery()
        {
            using (var connection = new SqlConnection(_connectionString)) 
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(_query, connection);

                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                connection.Close();

                return dataSet;
            }
        }

        public virtual void Display(IForm form, DataSet dataSet) 
        {
            form.DisplayToDataGridView(dataSet);
        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace StudentsDB.Interfaces
{
    public interface IForm
    {
        void DisplayToDataGridView(DataSet adapter);
    }
}

using StudentsDB.Abstract;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace StudentsDB
{
    public partial class ChooseTable : Form
    {
        private readonly string _connectionString;
        private readonly string[][] _tablesAndQueries;

        public ChooseTable()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _tablesAndQueries = new[]
            {
                new[] { "SELECT * FROM Estimates", "Таблица с оценками" },
                new [] { "SELECT * FROM Subjects", "Таблица с предметами" },
                new [] { "SELECT * FROM Specialties", "Таблица со специальностями" },
                new [] { "SELECT * FROM Students", "Таблица со студентами" }
            };
        }

        private void ChooseTable_Load(object sender, EventArgs e) => Factory();

        private void Factory()
        {
            buttonEstimates.Click += (object sender, EventArgs e) =>
                PrepareForm(_tablesAndQueries[0][0], _tablesAndQueries[0][1]);

            buttonSubject.Click += (object sender, EventArgs e) =>
                PrepareForm(_tablesAndQueries[1][0], _tablesAndQueries[1][1]);

            buttonSpecialities.Click += (object sender, EventArgs e) =>
                PrepareForm(_tablesAndQueries[2][0], _tablesAndQueries[2][1]);

            buttonStudents.Click += (object sender, EventArgs e) =>
                PrepareForm(_tablesAndQueries[3][0], _tablesAndQueries[3][1]);
        }

        private void PrepareForm(string query, string title)
        {
            var form = new TableTamplate();
            var formModel = new FormModelAbstract<TableTamplate>(form, _connectionString);

            formModel.SetTitle(title);
            formModel.SetQuery(query);
            Hide();
            formModel.OpenForm();

            var dataSet = formModel.MakeQuery();

            if (dataSet == null) throw new NullReferenceException(nameof(dataSet));

            formModel.Display(form, dataSet);
        }

    }
}

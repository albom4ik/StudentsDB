using StudentsDB.Abstract;
using StudentsDB.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDB
{
    public partial class ChooseTable : Form
    {

        public ChooseTable()
        {
            InitializeComponent();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            var form = new TableTamplate();

            var t = new ModelAbstract<TableTamplate>(form, "Data Source=DESKTOP-MOL1088\\SQLEXPRESS; Initial Catalog=Students; Integrated Security=true; TrustServerCertificate=True;");
            t.SetTitle("Some title");
            t.SetQuery("SELECT * FROM Estimates");

            MakeSomeAction(t, form);
        }

        private void MakeSomeAction<T>(ModelAbstract<T> model, IForm form) where T : Form
        {
            model.Open();
            var dataSet = model.MakeQuery();
            if (dataSet == null) throw new NullReferenceException(nameof(dataSet));
            model.Display(form, dataSet);
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            var form = new TableTamplate();

            var t = new ModelAbstract<TableTamplate>(form, "Data Source=DESKTOP-MOL1088\\SQLEXPRESS; Initial Catalog=Students; Integrated Security=true; TrustServerCertificate=True;");
            t.SetTitle("Some title");
            t.SetQuery("SELECT * FROM Subjects");

            MakeSomeAction(t, form);
        }

        private void buttonSpecialities_Click(object sender, EventArgs e)
        {
            var form = new TableTamplate();

            var t = new ModelAbstract<TableTamplate>(form, "Data Source=DESKTOP-MOL1088\\SQLEXPRESS; Initial Catalog=Students; Integrated Security=true; TrustServerCertificate=True;");
            t.SetTitle("Some title");
            t.SetQuery("SELECT * FROM Specialties");

            MakeSomeAction(t, form);
        }

        private void buttonEstimates_Click(object sender, EventArgs e)
        {
            var form = new TableTamplate();

            var t = new ModelAbstract<TableTamplate>(form, "Data Source=DESKTOP-MOL1088\\SQLEXPRESS; Initial Catalog=Students; Integrated Security=true; TrustServerCertificate=True;");
            t.SetTitle("Some title");
            t.SetQuery("SELECT * FROM Estimates");

            MakeSomeAction(t, form);
        }
    }
}

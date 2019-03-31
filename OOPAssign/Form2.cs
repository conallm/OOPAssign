using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssign
{
    public partial class Form2 : Form
    {
        public List<Student> studentList;
        public Form2()
        {
            InitializeComponent();
            studentList = new List<Student>();
            studentList.Add(new Student() { Name = "Ruadhan Morgan", StudentId = "101", PPSN = "756553D", Status = "Undergraduate", Address = "Dublin 7" });
            studentList.Add(new Student() { Name = "Geraldine Carpenter", StudentId = "202", PPSN = "678987B", Status = "Postgradate", Address = "Rathmines" });
            studentList.Add(new Student() { Name = "Larry Levan", StudentId = "303", PPSN = "567200G", Status = "Undergraduate", Address = "Galway" }); 

            dataGridView1.DataSource = studentList;
        }
        //Display data in the datagrdiview
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            dt = ConvertToDatatable();
            dataGridView1.DataSource = dt;
        }
        
        //Clear Data
        private void ClearData()
        {
            txtName.Text = "";
            txtId.Text = "";
            txtPPSN.Text = "";
            txtAddress.Text = "";
        }

        public DataTable ConvertToDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Id");
            dt.Columns.Add("PPSN");
            dt.Columns.Add("Address");

            foreach (var item in studentList )
            {
                var row = dt.NewRow();
                row["Name"] = item.Name;
                row["Id"] = item.StudentId;
                row["PPSN"] = item.PPSN;
                row["Address"] = item.Address;
                dt.Rows.Add(row);

            }
            return dt;
        }
    }
}

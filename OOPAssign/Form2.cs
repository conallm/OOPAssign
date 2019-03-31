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
        
        //Clear Data method
        private void ClearData()
        {
            txtName.Text = "";
            txtId.Text = "";
            txtPPSN.Text = "";
             
            txtAddress.Text = "";
        }

        // con
        public DataTable ConvertToDatatable()
        {
            if (rbUnder.Checked = true) ;
                string status = "Undergraduate";

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Id");
            dt.Columns.Add("PPSN");
            dt.Columns.Add("Status");
            dt.Columns.Add("Address");

            foreach (var item in studentList )
            {
                var row = dt.NewRow();
                row["Name"] = item.Name;
                row["Id"] = item.StudentId;
                row["PPSN"] = item.PPSN;
                row["Status"] = item.Status;
                row["Address"] = item.Address;
                dt.Rows.Add(row);
                Console.WriteLine("TestComment");
                //Test comment for git purposesgit
            }
            return dt;
        }

        private void AddStudent(string name, string studentId, string pPSN, string status, string address )
        {
            studentList.Add(new Student { Name = name, StudentId = studentId, PPSN = pPSN, Status = status, Address = address });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtId.Text != "" && txtPPSN.Text != "" && txtAddress.Text != "")
            {
                AddStudent(txtName.Text, txtId.Text, txtPPSN.Text, txtAddress.Text);
                MessageBox.Show("Student has been added to System");
                DisplayData();
            }
            else
            {
                MessageBox.Show("Please complete all fields to add student");
            }
        }
    }
}

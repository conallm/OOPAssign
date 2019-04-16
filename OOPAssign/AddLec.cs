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
    public partial class AddLec : Form
    {
        List<Lecturer> lecturerList = new List<Lecturer>();
        public AddLec()
        {
            InitializeComponent();

            lecturerList.Add(new Lecturer() { Name = "Kelly Liverpool", PPSN = "214453D", Address = "Dublin 8", Id = "818", Salary = 45000, SubjectArea = "Science", SubjectsTaught = new List<Subject> { new Subject() { Name = "Physics" }, new Subject() { Name = "Biology" } }, YearsExper = 3 });
            lecturerList.Add(new Lecturer() { Name = "Rory Crothers", PPSN = "128987B", Address = "Ranelagh", Id = "919", Salary = 32000, SubjectArea = "Computing", SubjectsTaught = new List<Subject> { new Subject() { Name = "Databases" }, new Subject() { Name = "Networks" } }, YearsExper = 6 });
            lecturerList.Add(new Lecturer() { Name = "Lucy Lonergan", PPSN = "997200G", Address = "Grangegorman", Id = "454", Salary = 30000, SubjectArea = "Languages", SubjectsTaught = new List<Subject> { new Subject() { Name = "Spanish" } }, YearsExper = 1 });


            dataGridView1.DataSource = lecturerList;


        }
        private void DisplayData()
        {
            //add columns to datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("Lecturer");
            dt.Columns.Add("PPSN");
            dt.Columns.Add("Address");
            dt.Columns.Add("Id");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Subject Area");
            dt.Columns.Add("Subjects Taught");
            dt.Columns.Add("Years Experience");

            //make all columns required to be filled
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].AllowDBNull = false;
            }

            foreach (var item in lecturerList)
            {
                var row = dt.NewRow();
                row["Lecturer"] = item.Name;
                row["PPSN"] = item.PPSN;
                row["Address"] = item.Address;
                row["Id"] = item.Id;
                row["Salary"] = item.Salary;
                row["Subject Area"] = item.SubjectArea;
                row["Subjects Taught"] = item.SubjectsTaught;
                row["Years Experience"] = item.YearsExper;

                dt.Rows.Add(row);

                dataGridView1.DataSource = dt;
            }

            /* private void comboArea_SelectedIndexChanged(object sender, EventArgs e)
             {
                 string subjectArea;
             }
            */
            }
            private void AddLecturer(string name, string id, string pPSN, string address, int salary, string subjectArea, List<Subject> subjectsTaught, int yearsExper)
            {
                Lecturer lecturer = new Lecturer();
                lecturer.Name = name;
                lecturer.Id = id;
                lecturer.PPSN = pPSN;
                lecturer.Address = address;
                lecturer.Salary = salary;
                lecturer.SubjectArea = subjectArea;
                lecturer.SubjectsTaught = subjectsTaught;
                lecturerList.Add(lecturer);
            }

            private void btnSubmit_Click(object sender, EventArgs e)
            {
                List<Subject> subjectsTaught = new List<Subject>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    Subject subject = new Subject();
                    subject.Name = item.ToString();
                    subjectsTaught.Add(subject);
                }

                AddLecturer(txtName.Text, txtID.Text, txtPPSN.Text, txtAddress.Text,
                   Int32.Parse(txtSalary.Text), comboArea.Text, subjectsTaught, Int32.Parse(txtYears.Text));

                dataGridView1.DataSource = lecturerList;

                MessageBox.Show("New Lecturer added.");
                DisplayData();
            }

            }

        }

    

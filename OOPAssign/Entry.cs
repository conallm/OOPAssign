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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // string name = txtAddStu.Text;

            Form2 m = new Form2();
            m.Show();
            

        }
        private void btnAddLec_Click(object sender, EventArgs e)
        {
            AddLec AddLec = new AddLec();
            AddLec.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            Search Search = new Search();
            Search.Show();

            
        }
    }
}

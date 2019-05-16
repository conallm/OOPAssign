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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private bool ValuesMatch(DataGridView item, string text)
        {
            bool matches = false;

            matches |= item.Text.ToLower().Contains(text.ToLower());

            if (matches)

            {
                return true;
            }

            foreach (DataGridViewCell in Form2.dataGridViewStu)
            {
                matches |= subitem.Text.ToLower().Contains(text.ToLower());

                if (matches)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            ValuesMatch();
            
        }
    }
}

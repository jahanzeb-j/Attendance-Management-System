using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence_System
{
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            if (DatabaseModel.logontype.Equals("admin"))
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;

            }

            ArrayList alist=DatabaseModel.getFaculty();

            //IEnumerable en = alist.GetEnumerator;
             IEnumerator en = alist.GetEnumerator();
            while(en.MoveNext())
            {
                listBox.Items.Add(en.Current);
            }


        }

      

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            facultyModel fm = (facultyModel)listBox.SelectedItem;

            facultyIDtext.Text = "" + fm.FacultyID;
            FacultyNameText.Text = fm.FacultyName;
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            FacultyNameText.Text = "";
        }
    }
}

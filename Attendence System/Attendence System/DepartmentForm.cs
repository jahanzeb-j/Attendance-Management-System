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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            if (DatabaseModel.logontype.Equals("admin"))
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;

            }
            
            ArrayList alist = DatabaseModel.getFaculty();

          
            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                facultyCombobox.Items.Add(en.Current);
            }
        }

        private void facultyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            facultyModel fm = (facultyModel)facultyCombobox.SelectedItem;


            ArrayList alist = DatabaseModel.getDept(fm.FacultyID);


            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                listBox1.Items.Add(en.Current);
            }
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentModel rec = (DepartmentModel)listBox1.SelectedItem;

            deptIDtext.Text=""+rec.DeptID;
            deptNameText.Text = rec.DeptName;
        }

    
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            deptNameText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TeacherForm().Show();
        }

    }
}

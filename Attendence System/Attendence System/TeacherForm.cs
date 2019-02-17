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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            if (DatabaseModel.logontype.Equals("admin"))
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;

            }
            //Faculty get
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
            deptcomboBox1.Items.Clear();

            facultyModel fm = (facultyModel)facultyCombobox.SelectedItem;


            ArrayList alist = DatabaseModel.getDept(fm.FacultyID);


            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                deptcomboBox1.Items.Add(en.Current);
            }
        }

        private void deptcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmentModel rec = (DepartmentModel)deptcomboBox1.SelectedItem;
            ArrayList alist = DatabaseModel.getTeachers(rec.DeptID);


            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                listBox1.Items.Add(en.Current);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeacherModel rec = (TeacherModel)listBox1.SelectedItem;

            IDtext.Text = "" + rec.TeachID;
            NameText.Text = "" + rec.Name;
            fnameText.Text = "" + rec.Fname;

            NicText.Text = "" + rec.NIC;

            surNameText.Text = "" + rec.SurName;
            desIdText.Text = "" + rec.DesigID;
            PayscaleText.Text = "" + rec.Payscale;
            empnoText.Text = "" + rec.EmpNo;
            emailText.Text = "" + rec.Email;
            passText.Text = "" + rec.Pass;
            AddText.Text = "" + rec.Address;
            bsicPayText.Text = "" + rec.BasicPay;
            mobileText.Text = "" + rec.MobileNo;
            remarksText.Text = "" + rec.Remarks;
        }


    }
}

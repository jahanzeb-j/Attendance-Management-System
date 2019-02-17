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
    public partial class BatchForm : Form
    {
        public BatchForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            batchShifttext.Text = "";
            batchYeartext.Text = "";
            IDtext.Text = "";
            grpDecText.Text = "";

        }

        private void BatchForm_Load(object sender, EventArgs e)
        {

            if (DatabaseModel.logontype.Equals("admin"))
            {
                panel2.Visible = true;



            }
            else {
                panel2.Visible = false;

            }

             ArrayList alist = DatabaseModel.getFaculty();

          
            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                facultyCombobox.Items.Add(en.Current);
            }
        }

        private void departmentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             listBox1.Items.Clear();
             programcomboBox.Items.Clear();

            DepartmentModel rec = (DepartmentModel)departmentcomboBox.SelectedItem;

            ArrayList alist = DatabaseModel.getProgram(rec.DeptID);


            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
               programcomboBox.Items.Add(en.Current);
            }

        }

        private void facultyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           departmentcomboBox.Items.Clear();

            facultyModel fm = (facultyModel)facultyCombobox.SelectedItem;


            ArrayList alist = DatabaseModel.getDept(fm.FacultyID);


            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                departmentcomboBox.Items.Add(en.Current);
            }
        
        }

        private void programcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ProgramModel ob = (ProgramModel)programcomboBox.SelectedItem;
            
            ArrayList alist = DatabaseModel.getBatch(ob.ProgID);


            IEnumerator en = alist.GetEnumerator();
            while (en.MoveNext())
            {
                listBox1.Items.Add(en.Current);
            }
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            batchModel ob = (batchModel)listBox1.SelectedItem;
            IDtext.Text = "" + ob.Batchid;
            batchYeartext.Text = "" + ob.Batchyear;
            batchShifttext.Text = ob.batchShift;
            grpDecText.Text = ob.Grpdesc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StudentRegistrationForm().Show();
        }
        
    }
}

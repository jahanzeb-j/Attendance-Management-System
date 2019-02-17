using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mitsoftsolution.net/");
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FacultyForm().Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentForm().Show();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProgramForm().Show();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new BatchForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

          
            
            
            
            DatabaseModel.getConnection();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean b = DatabaseModel.getAuth(textBox1.Text,textBox2.Text);
            if (b)
            {

                this.menuStrip1.Visible = true;
            }
            else
            {
                this.menuStrip1.Visible = true;
                //this.menuStrip1.Visible = false;
            }
        }
    }
}

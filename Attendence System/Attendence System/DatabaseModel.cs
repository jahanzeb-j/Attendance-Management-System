using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;

namespace Attendence_System
{
    class DatabaseModel
    {
        public static OleDbConnection con = null;
        public static String logontype=null; 

        public static Boolean getAuth(String user, String pass) {
            
            if (user.Equals("admin") && pass.Equals("admin"))
            {
                logontype = "admin";
                return true;

            }

            else {
                logontype = "";
                return false;
                
            
            }

              }
        public static void getConnection()
        {
            string driver = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBase.mdb";
            con = new OleDbConnection(driver);

        }

        public static ArrayList getFaculty()
        {
            ArrayList alist = new ArrayList();
            string query = "select * from faculty";
            OleDbCommand com = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader read=com.ExecuteReader();
            
            
            while(read.Read())
            {
                facultyModel rec = new facultyModel();
                rec.FacultyID = read.GetInt32(0);
                rec.FacultyName = read.GetString(1);

                alist.Add(rec);

            }
               con.Close();
            return alist;

        }

    public static ArrayList getDept(int facultyid)
        {
            ArrayList alist = new ArrayList();
            string query = "select * from department where faculty_id="+facultyid;
            OleDbCommand com = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader read = com.ExecuteReader();


            while (read.Read())
            {
                DepartmentModel rec = new DepartmentModel();
                rec.DeptID = read.GetInt32(0);
                rec.FacultyID = read.GetInt32(1);
                rec.DeptName= read.GetString(2);

                alist.Add(rec);

            }
            con.Close();
            return alist;
        }

    public static ArrayList getProgram(int deptid)
    {
        ArrayList alist = new ArrayList();
        string query = "select * from program where dept_id=" + deptid;
        OleDbCommand com = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader read = com.ExecuteReader();


        while (read.Read())
        {
            ProgramModel rec = new ProgramModel();
            rec.ProgID = read.GetInt32(0);
            rec.DeptID = read.GetInt32(1);
            rec.Program = read.GetString(2);
            rec.DurationSem = read.GetInt32(3);

            alist.Add(rec);

        }
        con.Close();
        return alist;
    }

    public static ArrayList getBatch(int progid)
    {
        ArrayList alist = new ArrayList();
        string query = "select * from batch where prog_id=" + progid;
        OleDbCommand com = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader read = com.ExecuteReader();


        while (read.Read())
        {
            batchModel rec = new batchModel();
            rec.Batchid = read.GetInt32(0);
            rec.Progid = read.GetInt32(1);
            rec.Batchyear = read.GetInt32(2);
            rec.batchShift = read.GetString(3);
            rec.Grpdesc = read.GetString(4);

            alist.Add(rec);

        }
        con.Close();
        return alist;
    }

        public static ArrayList getTeachers(int deptid)
        {
             ArrayList alist = new ArrayList();
        string query = "select * from teacher where dept_id=" + deptid;
        OleDbCommand com = new OleDbCommand(query, con);
        con.Open();
        OleDbDataReader read = com.ExecuteReader();


        while (read.Read())
        {
            TeacherModel rec =  new TeacherModel();
            
            rec.TeachID = read.GetInt32(0);
            rec.DEptID = read.GetInt32(1);
            //rec. = 
            rec.Name = read.GetString(2);
            rec.Fname = read.GetString(3);
            rec.SurName = read.GetString(4);
            rec.NIC = read.GetString(5);
            rec.DesigID = read.GetInt32(6);
                rec.Payscale = read.GetString(7);
                rec.BasicPay = read.GetInt32(8);
                rec.Address = read.GetString(9);
                rec.Email = read.GetString(10);
                rec.EmpNo = read.GetString(11);
                rec.MobileNo = read.GetString(12);
                rec.Pass = read.GetString(13);
                rec.Remarks = read.GetString(14);

            alist.Add(rec);

        }
        con.Close();
        return alist;
        }

        public static ArrayList getStudentsReg(int batchid)
        {
            ArrayList alist = new ArrayList();
            string query = "select * from student_registration where batch_id=" + batchid;
            OleDbCommand com = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader read = com.ExecuteReader();


            while (read.Read())
            {
               StudentRegistrationModel rec = new StudentRegistrationModel();

                rec.RollNo = read.GetString(0);
                rec.Batchid = read.GetInt32(1);
                //rec. = 
                rec.Name = read.GetString(2);
                rec.Fname = read.GetString(3);
                rec.SurName = read.GetString(4);
                rec.Gender = read.GetString(5);
                rec.Email = read.GetString(6);
                rec.MobileNo = read.GetString(8);
                rec.Pass = read.GetString(7);
                  rec.Address = read.GetString(9);
               
                alist.Add(rec);

            }
            con.Close();
            return alist;
        }


    }
}

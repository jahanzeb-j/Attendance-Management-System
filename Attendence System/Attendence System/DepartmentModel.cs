using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System
{
    class DepartmentModel
    {
        private int deptID;
        private int facultyid;
        private string deptName;

        public int DeptID {

            get
            {
                return this.deptID;
            }
            set
            {
            this.deptID=value;
            }}

        public int FacultyID {
            get
            {
                return this.facultyid;
            }
            set
            {
                this.facultyid=value;
            }
        }

        public string DeptName
        {
            get
            {
                return this.deptName;

            }
            set
            {
                this.deptName=value;
            }
        }


        public override string ToString()
        {
            return this.deptName;
        }


    }
}

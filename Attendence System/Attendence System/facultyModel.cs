using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System
{
    class facultyModel
    {
        private int facultyid;
        private string facultyname;

        public int FacultyID {
            
            get{
                return this.facultyid;
        }
             set{
                 this.facultyid = value;
             }
                 }


        public string FacultyName { 

            get{
                return this.facultyname;
            }
            set
            { this.facultyname=value;
            }
        }

        public override string ToString()
        {
            return this.facultyname;
        }
    }
}

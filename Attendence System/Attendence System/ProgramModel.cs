using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System
{
    class ProgramModel
    {
        private int deptid;
        private int progID;
        private string program;
        private int durationSem;


        public int DeptID {
            get
            {
                return this.deptid;
            }

            set
            {
                this.deptid = value;
            }
        }
        public int ProgID
        {
            get
            {
                return this.progID;
            }
            set
            {
                this.progID = value;
            }
        }
        public string Program { get {

            return this.program;
        }
            set {

                this.program = value;
            }

        }

        public int DurationSem {
            get
            {

                return this.durationSem;
            }
            set
            {
                
                durationSem=value;
                }}

        public override string ToString()
        {
            return this.program;
        }

    }
}

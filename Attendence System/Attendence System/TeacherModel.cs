using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System
{
    class TeacherModel
    {
        private int deptid;
        private int techid;
        private string name;
        private string fname;
        private string surname;
        private int desigID;
        private string nic;
        private string payscale;
        private int basicpay;
        private string address;
        private string email;
        private string employNO;
        private string mobieNo;
        private string password;
        private string remarks;


        public int DEptID {
            get
            {
               return deptid;
            }

            set
            {
                deptid = value;
            }
        }
        public int TeachID {
            get
            {
                return techid;
            }
            set
            {
                techid = value;
            }
        }
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string  Fname {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string SurName {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string  NIC   {
            get
            {
                return nic;
            }
            set
            {
                nic = value;
            }
        }
        public int DesigID {
            get
            {
                return desigID;
            }
            set
            {
                desigID = value;
            }
        }
        public string Payscale {
            get
            {
                return payscale;
            }
            set
            {
                payscale = value;
            }
        }
        public int BasicPay {
            get { return basicpay; }

            set { basicpay = value;}
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
            public string Email 
            { get { return email;}
                set { email=value;}
            }
        public string  EmpNo 
        { get { return employNO;}
            set { employNO=value;}
        }
        public string  MobileNo 
        { get { return mobieNo; }
            set { mobieNo=value;}
        }
        public string  Pass { 
            get { return password;}
            set { password=value; }
        }
        public string Remarks { 
            get{ return remarks; }
            set{ remarks=value; }
        }
        public override string ToString()
{
 	 return name;
}
    }
}

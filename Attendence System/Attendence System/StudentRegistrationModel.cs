using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System
{
    class StudentRegistrationModel
    {
        private int batchid;
        private string rollno;
      private string name;
        private string fname;
        private string surname;
        private string address;
        private string email;
        private string mobieNo;
        private string password;
        private string gender;

        public int Batchid {
            get
            {
                return batchid;
            }
            set { batchid = value; }
        }
        public string RollNo {
            get { return rollno; }
            set { rollno = value; }
        }

        public string Gender {
            get { return gender; }
            set { gender = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string SurName
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
       
        
        public string MobileNo
        {
            get { return mobieNo; }
            set { mobieNo = value; }
        }
        public string Pass
        {
            get { return password; }
            set { password = value; }
        }
        public override string ToString()
        {
            return rollno;
        }
    }
}

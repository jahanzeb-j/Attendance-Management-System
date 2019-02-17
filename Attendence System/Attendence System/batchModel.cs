using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System
{
    class batchModel
    {

        private int progid;
        private int batchtid;
        private int batchYear;
        private string batchshift;
        private string grpdesc;

        public int Progid {
            get
            {
                return this.progid;
            }
            set
            {

                this.progid = value;
            }
        }
        public int Batchid
        {
            get
            {
               return this.batchtid;
            }
            set
            {
                this.batchtid = value;
            }
        }
        
        public int Batchyear
        {
            get
            {
                return this.batchYear;
            }
            set
           
           {
               this.batchYear = value;
        }
        }
        public string batchShift {
            get {
                return batchshift;
            }
            set
            {
                batchshift = value;
            }
        }
        public string Grpdesc
        {
            get
            {
                return grpdesc;
            }
            set
            {
                grpdesc = value;
            }
        }

        public override string ToString()
        {
            return batchYear.ToString();
        }
         

    }
}

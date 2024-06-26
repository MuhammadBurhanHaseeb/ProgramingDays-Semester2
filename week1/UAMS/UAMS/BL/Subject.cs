using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Subject
    {

        public int code;
        public int creditHour;
        public string subjectType;
        public double subjectFee;

        public Subject(int code, string sType,int creditHour,double fees)
        {
            this.code = code;
            subjectType = sType;
            this.creditHour = creditHour;
            subjectFee = fees;
        }
    }
}

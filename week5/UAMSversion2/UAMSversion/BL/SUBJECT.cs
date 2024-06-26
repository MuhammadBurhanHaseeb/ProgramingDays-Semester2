using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class SUBJECT
    {
        public SUBJECT(string code , int creditHour , string type, int fee)
        {
            subjectCode = code;
            subjectCreditHour = creditHour;
            subjectType = type;
            subjectFee = fee;
        }
        public string subjectCode;
        public int subjectCreditHour;
        public string subjectType;
        public int subjectFee;

      
    }
}

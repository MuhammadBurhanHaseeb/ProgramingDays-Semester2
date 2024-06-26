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
        private string subjectCode;
        private int subjectCreditHour;
        private string subjectType;
        private int subjectFee;
        public string getSubjectCode()
        {
            return subjectCode;
        }
        public int getSubjectCreditHour()
        {
            return subjectCreditHour;
        }
        public string getSubjectType()
        {
            return subjectType;
        }
        public int getSubjectFee()
        {
            return subjectFee;
        }
        public void setSubjectCode(string subjectCode)
        {
            this. subjectCode = subjectCode;
        }
        public void getSubjectCreditHour(int subjectCreditHour)
        {
           this .subjectCreditHour = subjectCreditHour;
        }
        public void  getSubjectType(string subjectType)
        {
            this. subjectType= subjectType;
        }
        public void  getSubjectFee(int subjectFee)
        {
            this.subjectFee = subjectFee;
        }
    }
}

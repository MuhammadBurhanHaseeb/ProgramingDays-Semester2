using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class STUDENT
    {
        public STUDENT(string name ,int  age , float matric , float fsc , float ecat , List<DegreeProgram>prefference)
        {
            this.name = name;
            this.age = age;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            this.prefference = prefference;

        }
        
        public string name;
        public int age;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float merit;
        public DegreeProgram registerDegree = null;
        public List<DegreeProgram> prefference = new List<DegreeProgram>();
        public List<SUBJECT> subject= new List<SUBJECT>();

        public void  calculateMerit()
        {
            this.merit = ((fscMarks / 1100) * 60) + ((ecatMarks / 400) * 40);
        }

        public bool registerStudentSubject(SUBJECT s)
        {
            int get = getCreditHours();
            if (registerDegree != null && registerDegree.isSubjectExists(s) && get + s.subjectCreditHour <= 9)
            {
                subject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (SUBJECT sub in subject)
            {
                count = count + sub.subjectCreditHour;
            }
            return count;
        }

        public float calculateFee()
        {
            float fee = 0;
            if (registerDegree != null)
            {
                foreach(SUBJECT sub in subject)
                {
                    fee = fee + sub.subjectFee;
                }
            }
            return fee;
        }
       
       
       
    }
}

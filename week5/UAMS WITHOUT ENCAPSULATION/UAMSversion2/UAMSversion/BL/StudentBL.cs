using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSversion.DL;

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
        public STUDENT(string name, int age, float matric, float fsc, float ecat, List<DegreeProgram> prefference , List<SUBJECT> subject)
        {
            this.name = name;
            this.age = age;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            this.prefference = prefference;
            this.subject = subject;
        }
        public STUDENT(string name, int age, float matric, float fsc, float ecat)     {
            this.name = name;
            this.age = age;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            
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

        public  void calculateMerit()
        {
            merit = ((fscMarks / 1100) * 60) + ((ecatMarks / 400) * 40);
        }
        public static void addIntoSubjectList(STUDENT stu , List<SUBJECT> sub)
        {
            stu.subject = sub;//.Add(sub); 
        }
        public void addInToPreferenceList(DegreeProgram  degree)
        {
            prefference.Add(degree);
        }
    }
}

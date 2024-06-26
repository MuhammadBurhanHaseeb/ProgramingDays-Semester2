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
       /* public STUDENT(string name, int age, float matric, float fsc, float ecat, List<DegreeProgram> prefference , List<SUBJECT> subject)
        {
            this.name = name;
            this.age = age;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            this.prefference = prefference;
            this.subject = subject;
        }*/
        public STUDENT(string name, int age, float matric, float fsc, float ecat)
        {
            this.name = name;
            this.age = age;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            
        }

        private string name;
        private int age;
        private float matricMarks;
        private float fscMarks;
        private float ecatMarks;
        private float merit;
        private DegreeProgram registerDegree = null;

        private List<DegreeProgram> prefference = new List<DegreeProgram>();
        private List<SUBJECT> subject= new List<SUBJECT>();

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public float getMatricMarks()
        {
            return matricMarks;
        }
        public float getFscMarks()
        {
            return fscMarks;
        }
        public float getEcatMarks()
        {
            return ecatMarks;
        }
        public float getMerit()
        {
            return merit;
        }
        public DegreeProgram getRegisterDegree()
        {
            return registerDegree;
        }
        public List<DegreeProgram> getPrefference()
        {
            return prefference;
        }
        public List<SUBJECT> getSubject()
        {
            return subject;
        }
        public void  setName(string name)
        {
            this. name = name;
        }
        public void setAge(int age)
        {
            this.age= age;
        }
        public void setMatricMarks(float matricMarks)
        {
            this.matricMarks = matricMarks;
        }
        public void setFscMarks(float fscMarks)
        {
            this.fscMarks = fscMarks;
        }
        public void setEcatMarks(float ecatMarks)
        {
            this.ecatMarks = ecatMarks;
        }
        public void setMerit(float merit)
        {
            this.merit = merit;
        }
        public void setRegisterDegree(DegreeProgram registerDegree)
        {
            this.registerDegree = registerDegree;
        }
        public void setPrefference(List<DegreeProgram> prefference)
        {
            this.prefference = prefference;
        }
        public void setSubject(List<SUBJECT> subject)
        {
            this.subject = subject;
        }
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

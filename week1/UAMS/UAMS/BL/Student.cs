using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Student
    {
        public string name;
        public float fscMarks;
        public float ecatMarks;
        public int age;
        public float merit;
        public bool status = false;
        public string registerCourse = null;

        public List<Degree> degreeProgram = new List<Degree>();
        
        public void getAddmission(string course)
        {
            status = true;
            registerCourse = course;
        }
        

        
        public Student(string name, int age, float fsc, float ecat, List<Degree> pref)
        {
            this.name = name;
            this.age = age;
            fscMarks = fsc;
            ecatMarks = ecat;
            degreeProgram = pref;


        }
        public Student(string name, int age, float fsc, float ecat, List<Degree> pref, float merit)
        {
            this.name = name;
            this.age = age;
            fscMarks = fsc;
            ecatMarks = ecat;
            degreeProgram = pref;
            this.merit = merit;
        }
        public Student(string name)
        {
            this.name = name;
        }
        public float calculateMerit()
        {
            float percent;
            percent = (fscMarks / 1100) * 60;
            percent = percent + ((ecatMarks / 400) * 40);
            return percent;
        }
       /* public bool search(string degreeName)
        {
            for (int i = 0; i < degreeProgram.Count; i++)
            {
                if (degreeProgram[i].title == degreeName)
                {
                    return true;
                }
            }
            return false;


        }*/
    }
}

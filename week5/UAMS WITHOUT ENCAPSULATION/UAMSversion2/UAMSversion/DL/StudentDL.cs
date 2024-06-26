using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;

namespace UAMSversion.DL
{
    class StudentDL
    {
        public static List<STUDENT> studentList = new List<STUDENT>();

        public static void addIntoStudentList(STUDENT s)
        {
            StudentDL.studentList.Add(s);
        }
        public static List<STUDENT> sortStudentByMerit()
        {
            List<STUDENT> sortedStudentList = new List<STUDENT>();
            foreach (STUDENT s in StudentDL.studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = StudentDL.studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        public static void giveAdmission(List<STUDENT> sortedStudentList)
        {
            foreach (STUDENT s in sortedStudentList)
            {
                foreach (DegreeProgram a in s.prefference)
                {
                    if (a.programSeats > 0 && s.registerDegree == null)
                    {
                        s.registerDegree = a;
                        a.programSeats--;
                        break;
                    }
                }
            }
        }
        public static STUDENT studentPresent(string name)
        {
            foreach (STUDENT s in StudentDL.studentList)
            {
                if (name == s.name && s.registerDegree != null)
                {
                    return s;
                }
            }
            return null;

        }
        public static float calculateFee(STUDENT s)
        {
            float fee = 0;
                foreach (SUBJECT sub in s.subject)
                {
                    fee = fee + sub.subjectFee;
                }
            return fee;
        }

       public static void addIntoStudentFile(STUDENT s)
        {
            string path = "student.txt";
            string degreeName = "";
            StreamWriter f = new StreamWriter(path , true);
            for(int x = 0; x<s.prefference.Count - 1; x++ ) 
            {
                degreeName = degreeName +  s.prefference[x].programTitel +";";
            }
            degreeName = degreeName + s.prefference[s.prefference.Count - 1].programTitel ;
            f.WriteLine(s.name + "," + s.age + "," + s.matricMarks + "," + s.fscMarks + "," + s.ecatMarks + "," + degreeName);
            f.Flush();
            f.Close();
        }
        public static void loadStudent()
        {
            string path = "student.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    int age = int.Parse(load[1]);
                    float matric = float.Parse(load[2]);
                    float fsc = float.Parse(load[3]);
                    float ecat = float.Parse(load[4]);
                    string[] load1 = load[5].Split(';');
                    List<DegreeProgram> prefference = new List<DegreeProgram>();
                    for (int x = 0; x < load1.Length; x++)
                    {
                        DegreeProgram a = DegreeProgramDL.isDegreeExist(load1[x]);
                        if (a != null && !(prefference.Contains(a)))
                        {
                            prefference.Add(a);
                        }
                    }
                   STUDENT add = new STUDENT(name , age , matric , fsc ,ecat , prefference);

                    addIntoStudentList(add);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
    }
}

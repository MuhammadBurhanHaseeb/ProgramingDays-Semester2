using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMSversion.DL;
namespace UAMSversion.UI
{
    class StudentUI
    {
        public static STUDENT addStudent()
        {
            string nam;

            string name;
            int age;
            float fsc, matric, ecat;
            Console.WriteLine("enter the name of the student :");
            name = Console.ReadLine();
            Console.WriteLine("enter the age  of the student :");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the matric mark  of the student :");
            matric = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the fsc mark  of the student :");
            fsc = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the ecat mark  of the student :");
            ecat = float.Parse(Console.ReadLine());
            DegreeProgramUI.availableDegreeProgram();
            Console.WriteLine("how many prefference you want to enter :");
            int no = int.Parse(Console.ReadLine());
            STUDENT s = new STUDENT(name, age, matric, fsc, ecat);

            for (int x = 0; x < no; x++)
            {

                Console.WriteLine("eneter the prefference :");
                nam = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram d in DegreeProgramDL.programList)
                {
                    if (nam == d.programTitel && !(s.prefference.Contains(d))) 
                    {
                        s.addInToPreferenceList(d);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("enter the valid degrre");
                    x--;
                }
            }
            return s;
        }
        public static void displayStudents()
        {
            foreach (STUDENT s in StudentDL.studentList)
            {
                if (s.registerDegree != null)
                {
                    Console.WriteLine(s.name + "got admission in " + s.registerDegree.programTitel);
                }
                else
                {
                    Console.WriteLine(s.name + "did not get admision");
                }
            }
        }
        public static void viewRegisterStudent()
        {
            Console.WriteLine("name\tFSC\tECAT\t\tAg");
            foreach (STUDENT s in StudentDL.studentList)
            {
                if (s.registerDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }

            }
        }
        public static void viewRegisterStudentDegree(string degreeName)
        {
            Console.WriteLine("name\tFSC\tECAT\t\tAge");
            foreach (STUDENT s in StudentDL.studentList)
            {
                if (s.registerDegree != null)
                {
                    if (degreeName == s.registerDegree.programTitel)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                    }
                }
            }
        }
        public static void displayFee(float  fee , STUDENT s )
        {
            Console.WriteLine(s.name + " has " + fee + " Fee");

        }
       

    }
}

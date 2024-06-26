using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMSversion.UI;
using UAMSversion.Menu;
using UAMSversion.DL;
namespace UAMS
{
    class Program
    {
       

        static void Main(string[] args)
        {
           SubjectDL.loadSubject();
            DegreeProgramDL.loadDegree();
            StudentDL.loadStudent();
            SubjectDL.loadRegisterSubject();
            while (true)
            {
                int op = 0;
                Console.Clear();
                op = MenuUI.header();
                if (op == 1)
                {
                    if (DegreeProgramDL.programList.Count > 0)
                    {
                        STUDENT add =StudentUI.addStudent();
                       StudentDL.addIntoStudentList(add);
                        StudentDL.addIntoStudentFile(add);
                    }

                }
                else if (op == 2)
                {
                    DegreeProgram s =DegreeProgramUI.addDegree();
                    DegreeProgramDL.addIntoDegreeList(s);
                    DegreeProgramDL.addIntoDegreeFile(s);
                  //  DegreeProgramDL.addIntoFile(s);
                }
                else if (op == 3)
                {
                    List<STUDENT> sortedStudentList = new List<STUDENT>();
                    sortedStudentList =StudentDL.sortStudentByMerit();
                   StudentDL.giveAdmission(sortedStudentList);
                   StudentUI.displayStudents();
                    Console.ReadKey();
                }
                else if (op == 4)
                {
                  StudentUI.viewRegisterStudent();
                    Console.ReadKey();

                }
                else if (op == 5)
                {
                    string degName;
                    Console.WriteLine("enter the degree name");
                    degName = Console.ReadLine();
                    StudentUI.viewRegisterStudentDegree(degName);
                    Console.ReadKey();
                }
                else if (op == 6)
                {
                    Console.WriteLine("enter the student name:");
                    string name = Console.ReadLine();
                    STUDENT s =StudentDL.studentPresent(name);
                    if (s != null)
                    {
                       SubjectUI.viewSubject(s);
                       SubjectDL.registerSubjects(s);
                       
                    }
                    else
                    {
                        Console.WriteLine("student not present>>");
                    }
                    SubjectDL.addIntoRegisterSubject();
                    Console.ReadKey();

                }
                else if (op == 7)
                {
                    foreach(STUDENT s in StudentDL.studentList)
                    {
                        if (s.registerDegree != null)
                        {
                            float fee = StudentDL.calculateFee(s);
                            StudentUI.displayFee(fee,s);
                        }
                    }
                    Console.ReadKey();

                }
                else if (op == 8)
                {
                    break;
                }

            }
        }
        
       

       
       
       

      
        

       

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>
      

       
       


       

       
       
    }
}

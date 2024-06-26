using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
namespace UAMS
{
    class Program
    {
        static List<DegreeProgram> prefference = new List<DegreeProgram>();
        static List<STUDENT> studentList = new List<STUDENT>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();

        static void Main(string[] args)
        {
            
            while (true)
            {
                int op = 0;
                Console.Clear();
                op = header();
                if (op == 1)
                {
                    if (programList.Count >0)
                    {
                        STUDENT add = addStudent();
                        addIntoStudentList(add);
                    }
                  
                }
                else if (op == 2)
                {
                   DegreeProgram s =  addDegree();
                    addIntoDegreeList(s);
                }
                else if (op == 3)
                {
                    List<STUDENT> sortedStudentList = new List<STUDENT>();
                    sortedStudentList = sortStudentByMerit();
                    giveAdmission(sortedStudentList);
                    displayStudents();
                    Console.ReadKey();

                }
                else if (op == 4)
                {
                    viewRegisterStudent();
                    Console.ReadKey();

                }
                else if (op == 5)
                {
                    string degName;
                    Console.WriteLine("enter the degree name");
                    degName = Console.ReadLine();
                    viewRegisterStudentDegree(degName);
                    Console.ReadKey();
                }
                else if (op == 6)
                {
                    Console.WriteLine("enter the student name:");
                    string name = Console.ReadLine();
                    STUDENT s = studentPresent(name );
                    if (s != null)
                    {
                        viewSubject(s);
                        registerSubjects(s);
                    }
                    Console.ReadKey();

                }
                else if (op == 7)
                {
                    calculateFee();
                    Console.ReadKey();

                }
                else if (op == 8)
                {
                    break;
                }

            }
        }
        static int header()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("                   UAMS                      ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("1. Add the student :");
            Console.WriteLine("2. Add the degree program : ");
            Console.WriteLine("3. Generate the merit :");
            Console.WriteLine("4. view the registered student  :");
            Console.WriteLine("5. view student of the specific program :");
            Console.WriteLine("6. Register subjects for the specific student : ");
            Console.WriteLine("7. Calculate fees for all registered students :");
            Console.WriteLine("8. Logut this UAMS Application :");
            int op;
            Console.WriteLine("enter the option:");
            op = int.Parse(Console.ReadLine());
            return op;



        }
        static STUDENT addStudent()
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
            availableDegreeProgram();
            Console.WriteLine("how many prefference you want to enter :");
              int   no = int.Parse(Console.ReadLine());

            for (int x = 0; x < no; x++)
            {

                Console.WriteLine("eneter the prefference :");
                nam = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram d in programList)
                {
                    if (nam == d.programTitel && !(prefference.Contains(d)));
                    {
                        prefference.Add(d);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("enter the valid degrre");
                    x--;
                }
            }
            STUDENT s = new STUDENT(name , age , matric , fsc ,ecat , prefference);
            return s;
        }
        
        static void availableDegreeProgram()
        {
            Console.WriteLine("the available degree programs are ::");
            foreach(DegreeProgram a in programList)
            {
                Console.WriteLine(a.programTitel);
            }
            Console.ReadKey();
        }
        static void addIntoDegreeList(DegreeProgram a)
        {
            programList.Add(a);
        }
        static DegreeProgram addDegree()
        {
            string name;
            int duration , seats;
            Console.WriteLine("enter the name of the degree program: ");
            name = Console.ReadLine();
            Console.WriteLine("enter the duration of the program :");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the seats of this offer program: ");
            seats = int.Parse(Console.ReadLine());
            int no;
            DegreeProgram degreeprogram = new DegreeProgram(name,duration , seats);
            Console.WriteLine("how many subject you want to enter :");
            no = int.Parse(Console.ReadLine());

            for (int x = 0; x < no; x++)
            {
                degreeprogram.addSubject(inputSubject());
            }
            return degreeprogram;
        }

        static SUBJECT inputSubject()
        {
            string code, type;
            int creditHour, fee;
                Console.WriteLine("enter the code  of the subject: ");
                code = Console.ReadLine();
                Console.WriteLine("enter the credit hour of the subject : ");
                creditHour = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the type of the subject : ");
                type = Console.ReadLine();
                Console.WriteLine("enter the subject fee of the subject : ");
                fee = int.Parse(Console.ReadLine());

                SUBJECT a = new SUBJECT(code, creditHour, type, fee);
            return a;
        }
        static void addIntoStudentList(STUDENT s)
        {
            studentList.Add(s);
        }

        static void viewSubject(STUDENT s)
        {
            if (s.registerDegree !=null)
            {
                Console.WriteLine("subject code \t subject type");
                foreach (SUBJECT sub in s.registerDegree.subjects)
                {
                    Console.WriteLine(sub.subjectCode+"\t\t"+sub.subjectType);
                }
            }
        }
        
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>
        static STUDENT studentPresent(string name)
        {
            foreach(STUDENT s in studentList)
            {
                if (name == s.name && s.registerDegree != null)
                {
                    return s;
                }
            }
            return null;

        }

        static void calculateFee()
        {
            foreach(STUDENT s in studentList)
            {
                if (s.registerDegree != null)
                {
                    Console.WriteLine(s.name +" has " + s.calculateFee() +" Fee");
                }
            }

        }
        static void registerSubjects(STUDENT s)
        {
            Console.WriteLine("enter how  many subjects you want to register ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x<count; x++)
            {
                Console.WriteLine("enter the subject code :");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(SUBJECT sub in s.registerDegree.subjects)
                {
                    if (code == sub.subjectCode && !(s.subject.Contains(sub)))
                    {
                        s.registerStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false )
                {
                    Console.WriteLine("enter valid course :");
                    x--;
                }
            }
        }
        static List<STUDENT> sortStudentByMerit()
        {
            List<STUDENT> sortedStudentList = new List<STUDENT>();
            foreach(STUDENT s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }

        static void giveAdmission (List<STUDENT> sortedStudentList)
        {
            foreach(STUDENT s in sortedStudentList)
            {
                foreach(DegreeProgram a in  s.prefference )
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
        static void displayStudents()
        {
            foreach(STUDENT s in studentList)
            {
                if (s.registerDegree != null)
                {
                    Console.WriteLine(s.name +"got admission in "+s.registerDegree.programTitel );
                }
                else
                {
                    Console.WriteLine(s.name+"did not get admision");
                }
            }
        }

        static void viewRegisterStudentDegree(string degreeName)
        {
            Console.WriteLine("name\tFSC\tECAT\t\tAge");
            foreach(STUDENT s in studentList)
            {
                if (s.registerDegree !=null)
                {
                    if (degreeName == s.registerDegree.programTitel)
                    {
                        Console.WriteLine(s.name +"\t" + s.fscMarks +"\t"+s.ecatMarks +"\t" + s.age);
                    }
                }
            }
        }
        static void viewRegisterStudent()
        {
            Console.WriteLine("name\tFSC\tECAT\t\tAg");
            foreach(STUDENT s  in studentList)
            {
                if (s.registerDegree != null )
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
        
            }
        }
    }
}

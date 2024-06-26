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
        // ---------------- 2021-cs-165-------------------------------------

        static void Main(string[] args)
        {
            List<Degree> degreeProgram = new List<Degree>();
            List<Student> stu = new List<Student>();
            while (true)
            {
               int option = menu();
             if(option == 1)
                {
                   Console.Clear();
                   Student stuInfo= takeStuInput(degreeProgram);

                   stu.Add(stuInfo);

                }
             else if(option == 2)
                {
                    Console.Clear();
                    Degree information =  addDegree();
                    degreeProgram.Add(information);


                }
             else if(option == 3)
                {
                    generateMerit(stu, degreeProgram);
                    seeAdmitStudents(stu);
                }
             else if(option == 4)
                {
                    Console.Clear();
                    seeRegisterStu(stu);
                }
             else if(option == 5)
                {
                    specificDegreeStu(stu);
                }
             else if( option == 6)
                {
                    registerSubject(stu,degreeProgram);
                }
             else if (option == 7)
                {
                    generateFee();
                }
            }
        }
        static void generateFee()
        {

        }
        static void registerSubject(List<Student> students, List<Degree> offerProgram)
        {
            Console.WriteLine(" ENTER ADMIT STUDENT NAME FOR REGISTER THE SUBJECTS.");
            string name = Console.ReadLine();
            foreach( var admitStu in students)
            {
                if(admitStu.name == name && admitStu.status == true)
                {
                    seeDegreeSubjects(admitStu.registerCourse,  offerProgram );
                }
                else if(admitStu.name == name)
                {
                    Console.WriteLine(" PLEASE ENTER VALID NAME STUDENT IS NOT REGISTER IN ANY PROGRAM.");
                }
            }
            Console.WriteLine("** PRESS ANY KEY TO CONTINUE **");
            Console.ReadKey();
        }
        static void seeDegreeSubjects(string course,List<Degree> programs)
        {
            Console.WriteLine("CODE    CREDITHOUR   FEE   NAME");
            foreach (var P in programs)
            {
                if (P.title == course)
                {
                    for (int i = 0; i < P.subjects.Count; i++)
                    {
                        Console.WriteLine(P.subjects[i].code + "     " + P.subjects[i].creditHour + "     " + P.subjects[i].subjectFee + "      " + P.subjects[i].subjectType);
                    }
                }
            }
        }
        static void seeAdmitStudents(List<Student> admitStu) { 
       
              foreach(var stats in admitStu)
            {
                if(stats.status == true)
                {
                    Console.WriteLine(stats.name + " GOT ADDMISSION IN " + stats.registerCourse);
                }
                else
                {
                    Console.Write(stats.name + " DID NOT GET ADDMISSION IN ");
                    for( int i =0; i< stats.degreeProgram.Count; i++)
                    {
                        Console.Write(stats.degreeProgram[i].title + " ");
                    }
                    Console.WriteLine();
                }

            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE..");
            Console.ReadKey();

        }
        static void generateMerit(List<Student> forMerit, List<Degree> forSeats)
        {
            // ------ SWAPP FULL LIST IN HIGHEST TO LOWEST ORDER   //
            for(int i = 0; i < forMerit.Count; i++){

               int index = getLargest(forMerit,i);
                Student temp = forMerit[index];
                forMerit[index] = forMerit[i];
                forMerit[i] = temp;
            }

            //----------
            foreach (var student in forMerit)
            {
                

                for (int i = 0; i < student.degreeProgram.Count; i++) {
                    string course = student.degreeProgram[i].title;
                    
                    foreach(var seatt in forSeats)
                    {
                        if(seatt.title == course && seatt.seat !=0)
                        {
                            student.getAddmission(course);
                            seatt.seat--;
                            student.status = true;
                            student.registerCourse = course;
                        }
                    }
                    if(student.status == true)
                    {
                        break;
                    }
                   
                    

            }
            }

        }
        // ---------------- 2021-cs-165-------------------------------------
        static int getLargest(List<Student> findLargest, int id)
        {
            float merit = -1;
            int index =0;
            
            for( int i=id; i<findLargest.Count; i++)
            {
                if(merit < findLargest[i].merit)
                {
                    merit = findLargest[i].merit;
                    index = i;
                }
            }
            return index;

        }
        static void specificDegreeStu(List<Student> searchByDegree)
        {
            Console.Clear();
            Console.WriteLine(" ENTER DEGREE NAME..");
            string name = Console.ReadLine();


            Console.WriteLine("NAME     FSC    ECAT    AGE");
            foreach (var students in searchByDegree)
            {
                for(int i =0; i<students.degreeProgram.Count; i++)
                {
                    if (students.degreeProgram[i].title == name)
                    
                        {

                        Console.WriteLine(students.name + "    " + students.fscMarks + "    " + students.ecatMarks + "     " + students.age);
                    }
                   
                }
                
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE..");
            Console.ReadKey();
        }
        static void seeRegisterStu(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("NAME     FSC    ECAT   AGE");
            foreach (var stu in students)
            {
                if (stu.status == true)
                {
                    Console.WriteLine(stu.name + "    " + stu.fscMarks + "    " + stu.ecatMarks + "    " + stu.age);
                }
            }
            Console.WriteLine("PRESS ANY KEY TO CONTINUE..");
            Console.ReadKey();
        }
        static Degree addDegree()
        {
            Console.Write("ENTER DEGREE NAME :");
            string degreeName = Console.ReadLine();
            Console.Write("ENTER DEGREE DURATION :");
            string degreeDuration = Console.ReadLine();
            Console.Write("ENTER SEATS FOR DEGREE :");
            int seat = int.Parse(Console.ReadLine());

            List<Subject> addSubject = takeSubject();
            Degree add = new Degree(degreeName,degreeDuration,addSubject,seat);
            

            return add;

        }
        static List<Subject> takeSubject()
        {
            List<Subject> subjects = new List<Subject>();
            Console.Write("ENTER HOW MANY SUBJECTS TO ENTER :");
            int how = int.Parse(Console.ReadLine());

            for(int i =0; i<how; i++)
            {
                Console.Write("ENTER SUBJECT CODE.");
                int code = int.Parse(Console.ReadLine());
                Console.Write("ENTER SUBJECT TYPE.");
                string sType = Console.ReadLine();
                Console.Write("ENTER SUBJECT CREDIT HOUR");
                int creditHour = int.Parse(Console.ReadLine());
                Console.Write("ENTER SUBJECT FEES.");
                double fees = double.Parse( Console.ReadLine());

                Subject addSubject = new Subject(code, sType, creditHour, fees);
                subjects.Add(addSubject);
            }
            return subjects;
        }
        static Student takeStuInput(List<Degree> programs)
        {
            int count = 0;
            Console.Write("ENTER STUDENT NAME.");
            string name = Console.ReadLine();
            Console.Write("ENTER STUDENT AGE.");
            int age = int.Parse(Console.ReadLine());
            Console.Write("ENTER STUDENT FSC MARKS.");
            float fsc = float.Parse(Console.ReadLine());
            Console.Write("ENTER STUDENT ECAT MARKS.");
            float ecat = float.Parse(Console.ReadLine());
            
            Console.Write("AVAILABLE DEGREE PROGRAM.");
            foreach(var degree in programs)
            {
                Console.WriteLine(degree.title);
                count++;
            }
            

           List<Degree> pref = preferences(count);
           Student addStu = new Student(name, age, fsc, ecat, pref);
           float percentage = addStu.calculateMerit();

            Student addStu2 = new Student(name, age, fsc, ecat, pref,percentage);
            return addStu2;



        }
        static List<Degree> preferences(int count)
        {
            
            List<Degree> degre = new List<Degree>();
            Console.Write("ENTER HOW MANY PREFERANCES TO ENTER.");
            int how = int.Parse(Console.ReadLine());
            Console.Write("ENTER PREFERENCES.");
            if (how <= count)
            {
                for (int i = 0; i < how; i++)

                {
                    string name = Console.ReadLine();
                    Degree add = new Degree(name);
                    degre.Add(add);
                }
                return degre;
            }
            else
            {
                Console.WriteLine(" YOU HAVE ENTERED INVALID NUMBER OF PREFERENCES..");
                
            }
            Console.ReadKey();
            return null;
        }
        static int menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            UAMS               ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1] ADD STUDENT.");
            Console.WriteLine("2] ADD DEGREE PROGRAM.");
            Console.WriteLine("3] GENERATE MERIT.");
            Console.WriteLine("4] VIEW REGISTERED STUDENTS.");
            Console.WriteLine("5] VIEW STUDENTS OF A SPECIFIC PROGRAM.");
            Console.WriteLine("6] REGISTER SUBJECTS OF A SPECIFIC STUDENTS.");
            Console.WriteLine("7] CALCULATE FEES FOR ALL REGISTERED STUDENTS.");
            Console.WriteLine("7] EXIT.");
            Console.Write("8] ENTER OPTION.");
            int option = int.Parse(Console.ReadLine());
            return option;



        }
    }
}
// ---------------- 2021-cs-165-------------------------------------
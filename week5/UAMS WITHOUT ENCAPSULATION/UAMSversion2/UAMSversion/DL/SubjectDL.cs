using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO; 
namespace UAMSversion.DL
{
    class SubjectDL
    {
        public static List<SUBJECT> subjectList = new List<SUBJECT>();

        public static void registerSubjects(STUDENT s)
        {
            Console.WriteLine("enter how  many subjects you want to register ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("enter the subject code :");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (SUBJECT sub in s.registerDegree.subjects)
                {
                    if (code == sub.subjectCode && !(s.subject.Contains(sub)))
                    {
                        registerStudentSubject(s, sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("enter valid course :");
                    x--;
                }
            }
        }
        public static bool registerStudentSubject(STUDENT a ,  SUBJECT s)
        {
            int get = getCreditHours(a);
            if (a.registerDegree != null && a.registerDegree.isSubjectExists(s) && (get + s.subjectCreditHour) <= 9)
            {
                a.subject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int getCreditHours(STUDENT a)
        {
            int count = 0;
            foreach (SUBJECT sub in a.subject)
            {
                count = count + sub.subjectCreditHour;
            }
            return count;
        }
        public static void addIntoSubjectFile(SUBJECT s)
        {
            string path = "subject.txt";
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.subjectCode + "," + s.subjectCreditHour + "," + s.subjectType + "," + s.subjectFee);
            f.Flush();
            f.Close();
        }
        public static void addIntoRegisterSubject()
        {
            string path = "RegisterSubject.txt";
            string subjectCode = "";
            StreamWriter f = new StreamWriter(path);
            foreach(STUDENT s in StudentDL.studentList)
            {
            f.Write(s.name+",");
                for(int x = 0; x< s.subject.Count - 1; x++ )
                {
                    subjectCode = subjectCode + s.subject[x].subjectCode + ";";
                }
                subjectCode = subjectCode + s.subject[s.subject.Count-1].subjectCode ;
                f.WriteLine(s.name +","+ subjectCode);
            }
            f.Flush();
            f.Close();
        }
        public static void loadSubject()
        {
            string path = "subject.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    int creditHour = int.Parse(load[1]);
                    string type = load[2];
                    int fee = int.Parse(load[1]);
                    SUBJECT s = new SUBJECT(name, creditHour, type, fee);

                   addSubject(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
        public static void addSubject(SUBJECT s)
        {
            SubjectDL.subjectList.Add(s);
        }

        public static SUBJECT isSubjectExist(string name)
        {
            foreach(SUBJECT s  in SubjectDL.subjectList)
            {
                if (name == s.subjectType)
                {
                    return s;
                }
            }
            return null;
        }
        public static void loadRegisterSubject()
        {
            string path = "RegisterSubject.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    string[] load1 = load[1].Split(';');
                    List<SUBJECT> subject = new List<SUBJECT>();
                    foreach (STUDENT stu in StudentDL.studentList)
                    {
                       STUDENT student =  StudentDL.studentPresent(load[0]);
                        if (student != null)
                        {

                            for (int x = 0; x < load1.Length; x++)
                            {
                                SUBJECT sub = isSubjectExist(load1[x]);
                                if (sub != null && !(stu.subject.Contains(sub)))
                                {
                                    subject.Add(sub);
                                // STUDENT.addIntoSubjectList(student ,subject );
                                }
                                else
                                {
                                    Console.WriteLine("subject is already exist>>>");
                                    Console.ReadKey();
                                }

                            }
                           STUDENT.addIntoSubjectList(student,subject);
                        }
                        else
                        {
                            Console.WriteLine("student no exist>>>");
                            Console.ReadKey();
                        }
                    }
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

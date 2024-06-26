using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;
namespace UAMSversion.DL
{
    class DegreeProgramDL
    {
        public static List<DegreeProgram> programList = new List<DegreeProgram>();

        public static void addIntoDegreeList(DegreeProgram a)
        {
            programList.Add(a);
        }
        public static void addIntoDegreeFile(DegreeProgram s)
        {
            string path = "degree.txt";
            string subjectName = "";
            StreamWriter f = new StreamWriter(path,true);
            for (int x = 0 ; x < s.getSubjects().Count - 1 ; x++)
            {
                subjectName = subjectName + s.getSubjects()[x].getSubjectType() + ";";

            }
            subjectName = subjectName + s.getSubjects()[s.getSubjects().Count - 1].getSubjectType() ;
            f.WriteLine(s.getProgramTitel() + "," + s.getProgramDuration() + "," + s.getProgramSeats() + "," + subjectName);
            f.Flush();
            f.Close();
        }
        public static void loadDegree()
        {
            string path = "degree.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    int duration = int.Parse(load[1]);
                    int seats = int.Parse(load[2]);
                    DegreeProgram s = new DegreeProgram(name, duration, seats);
                    string[] load1 = load[3].Split(';');
                    for(int x =0;x< load1.Length; x++)
                    {
                        SUBJECT a = SubjectDL.isSubjectExist(load1[x]);
                        if (a!=null)
                        {
                            s.addSubject(a);
                        }
                    }

                    addIntoDegreeList(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
        public static DegreeProgram isDegreeExist(string name )
        {
            foreach(DegreeProgram s in programList)
            {
              if (name == s.getProgramTitel())
                {
                    return s;
                }
            }
            return null;
        }

    }
}

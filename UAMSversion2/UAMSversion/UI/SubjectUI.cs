using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMSversion.DL;

namespace UAMSversion.UI
{
    class SubjectUI
    {
        public static SUBJECT inputSubject()
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
           SubjectDL.addIntoSubjectFile(a);
            return a;
        }
        public static void viewSubject(STUDENT s)
        {
            if (s.getRegisterDegree() != null)
            {
                Console.WriteLine("subject code \t subject type");
                foreach (SUBJECT sub in s.getRegisterDegree().getSubjects())
                {
                    Console.WriteLine(sub.getSubjectCode() + "\t\t" + sub.getSubjectType());
                }
            }
        }
    }
}

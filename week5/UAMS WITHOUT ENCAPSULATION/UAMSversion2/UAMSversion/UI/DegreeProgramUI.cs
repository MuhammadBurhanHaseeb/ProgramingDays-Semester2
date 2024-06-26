using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMSversion.DL;
namespace UAMSversion.UI
{
    class DegreeProgramUI
    {
        public static DegreeProgram addDegree()
        {
            string name;
            int duration, seats;
            Console.WriteLine("enter the name of the degree program: ");
            name = Console.ReadLine();
            Console.WriteLine("enter the duration of the program :");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the seats of this offer program: ");
            seats = int.Parse(Console.ReadLine());
            int no;
            DegreeProgram degreeprogram = new DegreeProgram(name, duration, seats);
            Console.WriteLine("how many subject you want to enter :");
            no = int.Parse(Console.ReadLine());

            for (int x = 0; x < no; x++)
            {
                degreeprogram.addSubject(SubjectUI.inputSubject());
            }
            return degreeprogram;
        }
        public  static void availableDegreeProgram()
        {
            Console.WriteLine("the available degree programs are ::");
            foreach (DegreeProgram a in DegreeProgramDL.programList)
            {
                Console.WriteLine(a.programTitel);
            }
            Console.ReadKey();
        }
    }
}

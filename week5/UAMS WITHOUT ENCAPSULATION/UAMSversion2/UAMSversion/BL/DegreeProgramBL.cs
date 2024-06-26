using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public DegreeProgram(string name, int duration, int seats)
        {
            programTitel = name;
            programDuration = duration;
            programSeats = seats;
            subjects = new List<SUBJECT>();
        }
      
        public string programTitel;
        public int programDuration;
        public int programSeats;


        public List<SUBJECT> subjects = new List<SUBJECT>();


        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < subjects.Count; x++)
            {
                count = count + subjects[x].subjectCreditHour;
            }
            return count;
        }
        public bool addSubject(SUBJECT s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.subjectCreditHour <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isSubjectExists(SUBJECT subject)
        {
            foreach (SUBJECT s in subjects)
            {
                if (s.subjectCode == subject.subjectCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

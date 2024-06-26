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
      
        private string programTitel;
        private int programDuration;
        private int programSeats;
        private List<SUBJECT> subjects = new List<SUBJECT>();
        public string getProgramTitel()
        {
            return programTitel;
        }
        public int getProgramDuration()
        {
            return programDuration;
        }
        public int getProgramSeats()
        {
            return programSeats;
        }
        public List<SUBJECT> getSubjects()
        {
            return subjects;
        }
        public void setProgramTitel(string programTitel)
        {
            this. programTitel = programTitel;
        }
        public void setProgramDuration(int programDuration)
        {
            this. programDuration = programDuration;
        }
        public void  setProgramSeats()
        {
            this.programSeats--;//= programSeats;
        }
        public void setSubjects(List<SUBJECT> subjects)
        {
           this. subjects = subjects;
        }
        public int calculateCreditHours()
        {
            int count = 0;
            for (int x = 0; x < subjects.Count; x++)
            {
                count = count + subjects[x].getSubjectCreditHour();
            }
            return count;
        }
        public bool addSubject(SUBJECT s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.getSubjectCreditHour() <= 20)
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
                if (s.getSubjectCode() == subject.getSubjectCode())
                {
                    return true;
                }
            }
            return false;
        }
    }
}

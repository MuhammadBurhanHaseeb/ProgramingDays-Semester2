using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Degree
    {
       public string title;
       public string duration;
       public int seat;
       public List<Subject> subjects = new List<Subject>();

        public Degree(string title, string duration,List<Subject> subjects,int seat)
        {
            this.title = title;
            this.duration = duration;
            this.subjects = subjects;
            this.seat = seat;
        }
        public Degree(string title)
        {
            this.title = title;
        }
        

    }
}

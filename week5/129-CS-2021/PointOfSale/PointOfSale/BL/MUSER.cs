using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class MUSER
    {
        public static List<MUSER> muserList = new List<MUSER>();
        public MUSER (string userName , string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
        public MUSER(string userName, string userPassword,string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public string userName;
        public string userPassword;
        public string userRole;
    }
}

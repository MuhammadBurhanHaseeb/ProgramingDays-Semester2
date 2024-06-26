using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class MuserBL
    {
        public MuserBL (string userName , string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
        public MuserBL(string userName, string userPassword,string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        private string userName;
        private string userPassword;
        private string userRole;
        
        public string getUserName()
        {
            return userName;
        }
        public string getUserPassword()
        {
            return userPassword;
        }
        public string getUserRole()
        {
            return userRole;
        }
    }
}

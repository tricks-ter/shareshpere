using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shareshpere
{
    internal class session
    {
    }
    public static class UserSessionManager
    {
        private static UserSession instance;

        static UserSessionManager()
        {
            
            instance = new UserSession();
        }

        
        public static UserSession Instance
        {
            get { return instance; }
        }
    }

    public class UserSession
    {
        
        public int userID { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string isAdmin { get; set; }


        internal UserSession() { }

        
        public void ClearSession()
        {
            userID = 0;
            username = null;
            email = null;
            isAdmin = null;
        }
    }

}

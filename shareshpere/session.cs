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
        
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        
        internal UserSession() { }

        
        public void ClearSession()
        {
            UserID = 0;
            Username = null;
            Email = null;
        }
    }

}

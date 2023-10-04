using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicTableTopGamingWebsite.App_Code
{
    public class User
    {
        private string username;
        private string password;
        //private string email;

        public User()
        { 
        
        }

        public string getUsername() {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }
        //public string getEmail()
        //{
        //    return this.email;
        //}

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
        //public void setEmail(string email)
        //{
        //    this.email = email;
        //}
    }
}
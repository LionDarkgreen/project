using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleApp
{
    
    class User
    {
        
        public int id { get; set; }
      
        public string login, password, email;
      
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
     
        public User() { }

        public User(string login, string email, string pass)
        {
            this.login = login;
            this.email = email;
            this.password = pass;
        }
    }
}

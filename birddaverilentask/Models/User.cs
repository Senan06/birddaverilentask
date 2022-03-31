using System;
using System.Collections.Generic;
using System.Text;

namespace birddaverilentask.Models
{
    class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte Role { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("melumatlar");
        }
        public User(string UserName, string Email, byte Role)
        {
            this.UserName = UserName;
            this.Email = Email;
            this.Role = Role;
        }
    }
}

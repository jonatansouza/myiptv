using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myiptv.models
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string Username, string Name, string Password)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
        }
        public User()
        {

        }
        public override string ToString()
        {
            return "{Name: "+Name+ ", Username: "+ Username + " Password: "+Password+" }";
        }
    }
}

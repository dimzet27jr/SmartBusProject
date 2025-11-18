using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class User
    {
        private String name;
        private String password;
        private UserType type; 

        public User(string name, string password, UserType type)
        {
            this.name = name;
            this.password = password;
            this.type = type;
        }

        public String getName() {  return name; }
        public String getPassword() { return password; }
        public UserType getType() { return type; }

    }

    public enum UserType
    {
        Passenger, Driver
    }
}

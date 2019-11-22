using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class User
    {
        int _userid;
        string _fullName;
        string _email;
        string _password;
        string _confirmPassword;

        public int Userid { get => _userid; set => _userid = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string ConfirmPassword { get => _confirmPassword; set => _confirmPassword = value; }
    }
}

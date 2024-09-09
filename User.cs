using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFit
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsInJogja { get; set; }
        public string ProfileImage { get; set; }

        public List<Donate> Donations { get; set; }
        public List<Notification> Notifications { get; set; }

        public User()
        {
            Donations = new List<Donate>();
            Notifications = new List<Notification>();
        }

        public void Register(string username, string password, string email, string phoneNumber)
        {
            Username = username;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void Login(string username, string password)
        {
            // Authentication logic
        }

        public void EditProfile(string email, string phoneNumber, string profileImage)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            ProfileImage = profileImage;
        }

        public void ViewProfile()
        {
            Console.WriteLine($"Username: {Username}\nEmail: {Email}\nPhone: {PhoneNumber}\nAddress: {Address}");
        }
    }
}

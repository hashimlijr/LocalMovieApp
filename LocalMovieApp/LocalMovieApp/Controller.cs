using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMovieApp
{
    public class Controller
    {
        private readonly Context context = new Context();
        public bool AddUser(RegisterModel rm)
        {
            var oldUser = context.Users.FirstOrDefault(u => u.Username == rm.Username);
            if (oldUser != null)
                return false;

            User user = new User()
            {
                Name = rm.Name,
                Surname = rm.Surname,
                Password = rm.Password,
                Username = rm.Username,
            };
            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }

        public bool LoginUser(LoginModel lm)
        {
            User registeredUser = context.Users.FirstOrDefault(i => i.Username.Equals(lm.Username) && i.Password.Equals(lm.Password));
            
            if (registeredUser != null)
            {
                //IniFile ini = new IniFile(userFile);
                //ini.Write("Id", registeredUser.Id.ToString());
                //ini.Write("Name", registeredUser.Name);
                //ini.Write("Surname", registeredUser.Surname);

                //ini.Write("Password", registeredUser.Password);

                return true;
            }

            return false;
        }

        public string GetUserData(string username, string what)
        {
            var user = context.Users.FirstOrDefault(i => i.Username == username);
            string fullname = user.Name + " " + user.Surname;
            switch (what)
            {
                case "Name": return fullname;
                case "Id": return user.Id.ToString(); 
            }
            return "";
        }
    }
}

using CarRent.DAL;
using CarRent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.BL
{
    public class UsersManager
    {
        public IEnumerable<User> GetUsers()
        {
            using (var context = new RentContext())
            {
                return context.Users.ToArray();
            }
        }
        public User GetUserById(int UserId)
        {
            using (var context = new RentContext())
            {
                return context.Users.Find(UserId);
            }
        }

        public void AddUser(User user)
        {
            using (var context = new RentContext())
            {
                // context.Users.Add(user);
                context.Users.Attach(user);
                context.Entry(user).State = user.UserId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveUser(int userId)
        {
            using (var context = new RentContext())
            {
                // context.Users.Add(user);
                User userToDelete = context.Users.Find(userId);
                if (userToDelete != null)
                {
                    context.Entry(userToDelete).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                {
                    // TODO: if userToDelete is null, report it or return something

                }
            }
        }

        public void UpdateUser(User user)
        {
            // TODO: validate user exist on db befor trying to update
            using (var context = new RentContext())
            {
                // context.Users.Add(user);
                context.Users.Attach(user);
                context.Entry(user).State = user.UserId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool VerifyUserCredentials(string userName, string userPassword)
        {
            var foundUser = GetUsers().FirstOrDefault(u => (u.UserName == userName && u.Password == userPassword));
           return (foundUser != null);
        }
    }
}

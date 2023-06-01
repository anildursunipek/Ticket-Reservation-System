using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System.Repositories
{
    public class UserRepository
    {
        public void AddUser(User newUser) {
            using(var db = new AppDbContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }
        public List<User> GetAllUsers()
        {
            using(var db = new AppDbContext())
            {
                var users = db.Users.ToList();
                return users;
            }
        }
        public User GetUserById(int id)
        {
            using(var db = new AppDbContext())
            {
                var user = db.Users.Where(u => u.Id == id).FirstOrDefault();
                return user;
            }
        }
        public void UpdateUser(User userRequest) {
            using (var db = new AppDbContext())
            {
                var user = db.Users.Where(u => u.Id == userRequest.Id).FirstOrDefault();
                if(user != null)
                {
                    user.Name = userRequest.Name;
                    user.Surname = userRequest.Surname;
                    user.Email = userRequest.Email;
                    user.Age = userRequest.Age;
                    user.PhoneNumber = userRequest.PhoneNumber;
                    user.UserName = userRequest.UserName;
                    user.Password = userRequest.Password;
                    user.Birthday = userRequest.Birthday;
                    user.Gender = userRequest.Gender;

                    db.Users.Update(user);
                    db.SaveChanges();
                }
            }
        }
        public void DeleteUserById(int id)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.Where(u => u.Id ==id).FirstOrDefault();
                if(user != null)
                {
                    db.Users.Remove(user); 
                    db.SaveChanges();
                }
            }
        }
    }
}

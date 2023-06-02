using Ticket_Reservation_System.Forms;
using Ticket_Reservation_System.Models;

namespace Ticket_Reservation_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using(var db = new AppDbContext())
            //{
            //    var user = new User();
            //    user.Name = "batuhan";
            //    user.Surname = "arslandas";
            //    user.Email = "b.arslandas@hotmail.com";
            //    user.UserName = "b.arslandas";
            //    user.Password = "123";
            //    user.Gender = "erkek";
            //    user.PhoneNumber = "05555555555";
            //    user.Age = 22;
            //    user.Birthday = new DateTime();
            //    db.Users.Add(user);
                
            //    db.SaveChanges();
            //}
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AddFirm());
        }
    }
}
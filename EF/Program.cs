using FirstApp;
using EF;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FirstApp.AppContext())
            {
                var user1 = new User { Name = "Arthur", Role = "Admin" };
                var user2 = new User { Name = "klim", Role = "User" };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }
        }
    }
}
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
                var company1 = new Company { Name = "SF" };
                var company2 = new Company { Name = "VK" };

                var company3 = new Company { Name = "FB" };
                db.Companies.Add(company3);
                db.SaveChanges();

                var user1 = new User { Name = "Arthur", Email = "mail2@mail.ru" ,Role = "Admin" };
                var user2 = new User { Name = "Bob", Email = "mail2@mail.ru", Role = "Admin" };
                var user3 = new User { Name = "Clark", Email = "mail2@mail.ru", Role = "User" };

                user1.Company = company1;
                company2.Users.Add(user2);
                user3.CompanyId = company3.Id;

                db.Companies.AddRange(company1, company2);
                db.Users.AddRange(user1, user2, user3);

                db.SaveChanges();
            }
        }
    }
    
}
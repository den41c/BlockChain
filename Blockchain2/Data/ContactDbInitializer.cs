using Blockchain2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlockChain.Models
{
    public class UserDbInitializer
    {
       
        public static void SeedDb(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            if (db.Users == null || !db.Users.Any())
            {
                db.Database.EnsureCreated();
                db.Contacts.Add(new Contact { ContactName = "user1", Email = "user1@gmail.com", Id = Guid.NewGuid() });
                db.Contacts.Add(new Contact { ContactName = "user2", Email = "user2@gmail.com", Id = Guid.NewGuid() });
                db.Contacts.Add(new Contact { ContactName = "user3", Email = "user3@gmail.com", Id = Guid.NewGuid() });
                db.SaveChanges();
            }

			IdentityUser user = new IdentityUser
            {
                UserName = "denys@email.com",
                Email = "denys@email.com"
            };
            userManager.CreateAsync(user, "P@ssword123!").Wait();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BlockChain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Tools;
//using Microsoft.EntityFrameworkCore.SqlServer;

namespace Blockchain2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi2.Models;

namespace WebApi2.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
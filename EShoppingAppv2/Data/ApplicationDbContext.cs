using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EShoppingAppv2.Models;

namespace EShoppingAppv2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EShoppingAppv2.Models.Product> Product { get; set; }
        public DbSet<EShoppingAppv2.Models.User> User { get; set; }
    }
}

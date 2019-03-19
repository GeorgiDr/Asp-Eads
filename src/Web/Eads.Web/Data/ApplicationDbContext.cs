using System;
using System.Collections.Generic;
using System.Text;
using Eads.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eads.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

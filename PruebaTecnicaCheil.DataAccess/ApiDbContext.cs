using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebaTecnicaCheil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.DataAccess
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

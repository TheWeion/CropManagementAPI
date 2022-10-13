using CropManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropManagementSystem.Data
{
    public class CropManagementSystemContext : DbContext
    {
        public CropManagementSystemContext(DbContextOptions<CropManagementSystemContext> options):
             base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        
        public DbSet<UserModel> users { get; set; }
        public DbSet<TrackModel> tracks { get; set; }
    }
}

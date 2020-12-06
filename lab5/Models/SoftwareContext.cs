using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5.Models
{
    public class SoftwareContext : DbContext
    {
        //Constructor for SoftwareContext
        public SoftwareContext(DbContextOptions<SoftwareContext> options) : base(options)
        {



        }
        public DbSet<Software> Software { get; set; }
    }
}

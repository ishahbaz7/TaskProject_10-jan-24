using System;
using Microsoft.EntityFrameworkCore;
using TaskProject.Models;

namespace TaskProject.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<EducationDetails> EducationDetails { get; set; }
    
    }
}


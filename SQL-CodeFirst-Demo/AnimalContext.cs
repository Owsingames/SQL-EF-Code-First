using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_CodeFirst_Demo
{
    class AnimalContext : DbContext // This class is for the Database
    {
        //this will represent the animal table in the DB, table is mapped by Animal class
        public DbSet<Animal> Animals { get; set; }

        //This will be different for web apps 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=AnimalDb;Trusted_Connection=True;");
        }
    }
}

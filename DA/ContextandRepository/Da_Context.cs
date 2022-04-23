using System;
using System.Collections.Generic;
using System.Text;
using DA.DA;
using Microsoft.EntityFrameworkCore;


namespace DA.ContextandRepository
{
    public class Da_Context : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\Emtehan Akhar\DA\DB_Emteham.mdf;Integrated Security=True");
        }
    }
}

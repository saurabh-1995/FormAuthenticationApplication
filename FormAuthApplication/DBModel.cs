using FormAuthApplication.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormAuthApplication
{
    public class DBModel:DbContext
    {
        public DbSet<LoginCredentials> tblFormAuthentication { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D6FS7LS\;Initial Catalog=SampleExercise;Integrated Security=True");
        }
    }
}

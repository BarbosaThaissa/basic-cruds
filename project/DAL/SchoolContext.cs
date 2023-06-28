using project.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace project.DAL
{
    public class SchoolContext : System.Data.Entity.DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
            public System.Data.Entity.DbSet<Student> Students { get; set; }
            public System.Data.Entity.DbSet<Enrollment> Enrollments { get; set; }
            public System.Data.Entity.DbSet<Course> Courses { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}
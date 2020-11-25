using Microsoft.EntityFrameworkCore;
using Yggdrasil.Models;
using Yggdrasil.Models.DBModels;

namespace Yggdrasil.Context
{
    public class SchoolDatabaseContext : DbContext
    {
        public SchoolDatabaseContext(DbContextOptions<SchoolDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
    }
}
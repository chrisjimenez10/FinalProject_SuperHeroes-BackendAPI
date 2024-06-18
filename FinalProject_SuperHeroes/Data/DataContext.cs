using FinalProject_SuperHeroes.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_SuperHeroes.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet <SuperHeroes> SuperHeroes { get; set; } //Here the "SuperHeroes {get; set;}" is the collection of entities/records stored in our database and we are able to interact with that data (i.e. performing queries like create, edit, delete, view) through the "DbSet <SuperHeroes>" property 
    }
}

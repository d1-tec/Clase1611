using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class RecipesContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Chef> Chefs { get; set; }

        public RecipesContext() : base("name=defaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RecipesContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .HasRequired(p => p.Country)
                .WithOptional(p => p.Ingredient);

            // modelBuilder.Entity<Chef>().Property(x => x.Name).HasMaxLength(20);
            // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/fluent/types-and-properties
        }
    }
}

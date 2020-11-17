using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain
{
    public class IngredientsController
    {
        public void CreateIngredient(Ingredient ingredient)
        {
            using (var context = new RecipesContext())
            {
                context.Ingredients.Add(ingredient);
                context.Entry(ingredient.Country).State = System.Data.Entity.EntityState.Unchanged;
                context.SaveChanges();
            }
        }

        public ICollection<Ingredient> GetAllIngredients()
        {
            //var context = new RecipesContext();

            //return context.Ingredients.Include(x => x.Country).ToList();

            using (var context = new RecipesContext())
            {
                return context.Ingredients.Include(x => x.Country).ToList();
            }
        }
    }
}

// eager loading (con .Include)
// lazy loading (con virtual)
// explicit loading (esta NO)
// problema de las N+1 queries

    // n a n
    // 1 a n

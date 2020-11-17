using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain
{
    public class RecipesController
    {
        public void CreateRecipe(Recipe recipe)
        {
            using (var context = new RecipesContext())
            {

                context.Recipes.Add(recipe);

                foreach (var ingredient in recipe.Ingredients)
                {
                    context.Entry(ingredient).State = EntityState.Unchanged;
                }

                context.Entry(recipe.Chef).State = EntityState.Unchanged;

                context.SaveChanges();
            }
        }

        public ICollection<Recipe> GetAllRecipes()
        {
            using (var context = new RecipesContext())
            {
                return context.Recipes.Include(x => x.Ingredients).ToList();
            }
        }
    }
}

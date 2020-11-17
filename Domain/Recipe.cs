using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public Chef Chef { get; set; }

        public Recipe()
        {
            this.Ingredients = new List<Ingredient>();
        }

        public void AddIngredients(List<Ingredient> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                this.Ingredients.Add(ingredient);
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

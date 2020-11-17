using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public override string ToString()
        {
            //return this.Name;
            return $"{this.Name} ({this.Country.Name})";
        }
    }
}

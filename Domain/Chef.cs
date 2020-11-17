using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public Chef()
        {
            this.Recipes = new List<Recipe>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

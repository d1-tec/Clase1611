using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

// Convention over configuration

    // data annotations vs. fluent api


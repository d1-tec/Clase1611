using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ChefsController
    {
        public ICollection<Chef> GetAllChefs()
        {
            using (var context = new RecipesContext())
            {
                return context.Chefs.ToList();
            }
        }

        public void CreateChef(string name)
        {
            Chef chef = new Chef() { Name = name };

            using (var context = new RecipesContext())
            {
                context.Chefs.Add(chef);
                context.SaveChanges();
            }
        }
    }
}

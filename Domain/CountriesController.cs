using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain
{
    public class CountriesController
    {
        public void CreateCountry(string name)
        {
            using (var context = new RecipesContext())
            {
                Country country = new Country() { Name = name };
                context.Countries.Add(country);
                context.SaveChanges();
            }
        }

        public ICollection<Country> GetAllCountries()
        {
            using (var context = new RecipesContext())
            {
                return context.Countries.ToList();
            }
        }

        public void UpdateCountry(Country country)
        {
            //using (var context = new RecipesContext())
            //{
            //    context.Countries.Attach(country);
            //    country.Name = newName;
            //    var state = context.Entry(country).State;
            //    context.SaveChanges();
            //}


            using (var context = new RecipesContext())
            {
                context.Countries.Attach(country); // bo mira que el country esta en la base (POR DEFECTO VA COMO UNCHANGED)
                context.Entry(country).State = EntityState.Modified; // este va como modified, actualizalo
                context.SaveChanges(); // confirma los cambios
            }
        }

        public void DeleteCountry(Country country)
        {
            using (var context = new RecipesContext())
            {
                context.Countries.Attach(country);
                context.Countries.Remove(country);
                context.SaveChanges();
            }
        }
    }

  // insert delete update select
 // unchanged added deleted modified detached

}

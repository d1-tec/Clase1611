using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UI
{
    public partial class ManageRecipesUserControl : UserControl
    {
        private MainWindow mainWindow;
        private IngredientsController ingredientsController;
        private RecipesController recipesController;
        private ChefsController chefsController;
        private List<Ingredient> ingredientsCurrentRecipe;

        public ManageRecipesUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.ingredientsController = new IngredientsController();
            this.recipesController = new RecipesController();
            this.chefsController = new ChefsController();

            this.mainWindow = mainWindow;
            this.ingredientsCurrentRecipe = new List<Ingredient>();
            this.listBoxIngredients.Items.AddRange(ingredientsController.GetAllIngredients().ToArray());

            this.RefreshRecipes();

            this.comboBoxRecipeChef.Items.Clear();
            this.comboBoxRecipeChef.Items.AddRange(this.chefsController.GetAllChefs().ToArray());
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MAIN_MENU);
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredientChosen = (Ingredient)this.listBoxIngredients.SelectedItem;

            if (ingredientChosen != null)
            {
                this.ingredientsCurrentRecipe.Add(ingredientChosen);
                this.RefreshIngredientsOfCurrentRecipe();
            }
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            string recipeName = this.textBoxRecipeName.Text;
            Chef chef = (Chef)this.comboBoxRecipeChef.SelectedItem;

            /*
             
             WORKAROUND 1

            Le seteo como Chef un nuevo Chef, pero que tenga el mismo Id que el elegido, para que
            Entity Framework pueda identificar la tupla. Esto tiene como ventaja que cuando attachee
            al nuevo Chef y lo marque como UNCHANGED no tenga que iterar todas sus recetas y setear a ellas
            tambien como UNCHANGED. Este nuevo Chef no tiene Recetas dado que acabo de crearlo, es un 
            Chef "ficticio" que solo me permite identificar correctamente la tupla. Esto es porque Id
            es CLAVE PRIMARIA
             
             */

            Recipe recipe = new Recipe() { Name = recipeName, Chef = new Chef() { Id = chef.Id } };

            /*
             
             WORKAROUND 2

            Idem anterior, itero los ingredientes y me quedo solamente con sus ids para poder identificar la tupla
            en la base, pero no me interesa tener que attachear y marcar como UNCHANGED sus entidades relacionadas
             
             */

            /*
             
            ========================================================================================================

            ES IMPORTANTE ACLARAR QUE ESTE CODIGO ES INCORRECTO QUE SE HAGA EN EL PROYECTO DE INTERFAZ
            ESTO ES UN WORKAROUND QUE DEBERIA HACERSE COMO PARTE DE LA OPERACION QUE INTERACTUE CON ENTITY FRAMEWORK
            Y NO DENTRO DE LA VENTANA

            NO TOMEN ESTO COMO EJEMPLO DE DISENIO SOLAMENTE COMO EJEMPLO DE COMO USAR LA TECNOLOGIA

            ========================================================================================================
    
           */

            List<Ingredient> ingredientsToAdd = new List<Ingredient>();

            foreach (var ingredient in this.ingredientsCurrentRecipe)
            {
                ingredientsToAdd.Add(new Ingredient() { Id = ingredient.Id });
            }

            recipe.AddIngredients(ingredientsToAdd);

            this.recipesController.CreateRecipe(recipe);

            this.RefreshRecipes();
            this.ingredientsCurrentRecipe.Clear();
            this.RefreshIngredientsOfCurrentRecipe();
        }

        private void RefreshIngredientsOfCurrentRecipe()
        {
            this.listBoxIngredientsCurrentRecipe.Items.Clear();
            this.listBoxIngredientsCurrentRecipe.Items.AddRange(this.ingredientsCurrentRecipe.ToArray());
        }

        private void RefreshRecipes()
        {
            this.listBoxRecipes.Items.Clear();
            this.listBoxRecipes.Items.AddRange(this.recipesController.GetAllRecipes().ToArray());
        }

        private void listBoxRecipes_SelectedValueChanged(object sender, EventArgs e)
        {
            Recipe selectedRecipe = (Recipe)this.listBoxRecipes.SelectedItem;

            if (selectedRecipe != null)
            {
                var ingredientesNames = selectedRecipe.Ingredients.Select(x => x.Name).ToArray();

                this.textBoxRecipeDetails.Text = $@"Receta: {selectedRecipe.Name}
Ingredientes: {string.Join(", ", ingredientesNames)}
";
            }
        }
    }
}

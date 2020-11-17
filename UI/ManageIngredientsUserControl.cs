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
    public partial class ManageIngredientsUserControl : UserControl
    {
        private MainWindow mainWindow;
        private CountriesController countriesController;
        private IngredientsController IngredientsController;

        public ManageIngredientsUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.countriesController = new CountriesController();
            this.IngredientsController = new IngredientsController();

            this.comboBoxCountry.Items.AddRange(this.countriesController.GetAllCountries().ToArray());

            // this.listBoxIngredients.Items.Clear();
            this.RefreshIngredients();

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MAIN_MENU);
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            Country country = (Country)this.comboBoxCountry.SelectedItem;
            string ingredientName = this.textBoxIngredientName.Text;

            Ingredient ingredient = new Ingredient() { Country = country, Name = ingredientName };
            this.IngredientsController.CreateIngredient(ingredient);
            this.RefreshIngredients();
        }

        private void RefreshIngredients()
        {
            this.listBoxIngredients.Items.Clear();
            this.listBoxIngredients.Items.AddRange(this.IngredientsController.GetAllIngredients().ToArray());
        }
    }
}

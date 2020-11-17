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
    public partial class ManageCountriesUserControl : UserControl
    {
        private MainWindow mainWindow;
        private CountriesController countriesController;

        public ManageCountriesUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.countriesController = new CountriesController();

            this.RefreshCountries();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MAIN_MENU);
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            this.countriesController.CreateCountry(this.textBoxCountryName.Text);
            this.RefreshCountries();
        }

        private void RefreshCountries()
        {
            this.listBoxCountries.Items.Clear();
            this.listBoxCountries.Items.AddRange(countriesController.GetAllCountries().ToArray());
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Country currentCountry = (Country) this.listBoxCountries.SelectedItem;
            string newCountryName = this.textBoxCountryName.Text;

            Country updatedCountry = new Country() { Id = currentCountry.Id, Name = newCountryName };

            this.countriesController.UpdateCountry(updatedCountry);
            // this.countriesController.UpdateCountry(currentCountry, newCountryName);
            this.RefreshCountries();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Country currentCountry = (Country)this.listBoxCountries.SelectedItem;
            this.countriesController.DeleteCountry(currentCountry);
            this.RefreshCountries();
        }
    }
}

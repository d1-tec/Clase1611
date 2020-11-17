using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainUserControl : UserControl
    {
        private MainWindow mainWindow;

        public MainUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void buttonManageIngredients_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MANAGE_INGREDIENTS);
        }

        private void buttonManageRecipes_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MANAGE_RECIPES);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.mainWindow.Close();
        }

        private void buttonManageChefs_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MANAGE_CHEFS);
        }

        private void buttonManageCountries_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MANAGE_COUNTRIES);
        }
    }
}

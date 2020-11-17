using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.GoTo(MenuOption.MAIN_MENU);
        }

        public void GoTo(MenuOption menuOption)
        {
            UserControl nextUserControl = this.GetNextUserControl(menuOption);

            if (nextUserControl != null)
            {
                this.panel.Controls.Clear();
                this.panel.Controls.Add(nextUserControl);
            }
        }

        private UserControl GetNextUserControl(MenuOption menuOption)
        {
            switch (menuOption)
            {
                case MenuOption.MANAGE_INGREDIENTS:
                    return new ManageIngredientsUserControl(this);
                case MenuOption.MANAGE_RECIPES:
                    return new ManageRecipesUserControl(this);
                case MenuOption.MANAGE_CHEFS:
                    return new ManageChefsUserControl(this);
                case MenuOption.MAIN_MENU:
                    return new MainUserControl(this);
                case MenuOption.MANAGE_COUNTRIES:
                    return new ManageCountriesUserControl(this);
                default:
                    return null;
            }
        }
    }
}

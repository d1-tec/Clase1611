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
    public partial class ManageChefsUserControl : UserControl
    {
        private MainWindow mainWindow;
        private ChefsController chefsController;

        public ManageChefsUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.chefsController = new ChefsController();

            this.mainWindow = mainWindow;

            this.RefreshChefs();
        }

        private void RefreshChefs()
        {
            this.listBoxChefs.Items.Clear();
            this.listBoxChefs.Items.AddRange(this.chefsController.GetAllChefs().ToArray());
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.mainWindow.GoTo(MenuOption.MAIN_MENU);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var chefName = this.textBoxName.Text;

            this.chefsController.CreateChef(chefName);

            this.RefreshChefs();
        }
    }
}

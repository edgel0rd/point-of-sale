using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PointOfSale
{
    public partial class FrmManager : Form
    {

        private List<EFlatButton> menubuttons;
        public FrmManager()
        {
            InitializeComponent();
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            menubuttons = new List<EFlatButton>()
            {
                btnCustomers,btnDashboard,btnManagers,btnAdmins
            };
            var series = new Series("Purchases");
            pnlDboardLeftSide.Size = new Size((pnlDboardLeftSide.Parent.Size.Width / 2), pnlDboardLeftSide.Parent.Height);
            pnlInventoryPadding.Size = new Size((pnlInventoryPadding.Parent.Size.Width), 
                Convert.ToInt32(pnlInventoryPadding.Parent.Size.Height / 1.7));
            btnDashboard.PerformClick();
        }
        
        
        private void MultiClick(object sender, EventArgs e)
        {
            EFlatButton triggering_button = (EFlatButton)sender;
            foreach (EFlatButton fbtn in pnlSideBar.Controls.OfType<EFlatButton>())
            {
                fbtn.PerformLock(triggering_button == fbtn);
            }
            btnTitle.Text = triggering_button.Title;
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            menuOptions.Show(ptLowerLeft);
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExtendMenu_Click(object sender, EventArgs e)
        {
            btnExtendMenu.Toggle();
            pnlSideBar.Size = !btnExtendMenu.IsActivated() ? new Size(pnlSideBar.Width * 3, pnlSideBar.Height) : new Size(pnlSideBar.Width / 3, pnlSideBar.Height);
        }

        private void FrmManager_SizeChanged(object sender, EventArgs e)
        {
            pnlDboardLeftSide.Size = new Size((pnlDboardLeftSide.Parent.Size.Width / 2),pnlDboardLeftSide.Parent.Height);
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

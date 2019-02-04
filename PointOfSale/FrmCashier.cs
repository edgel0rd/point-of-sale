using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Models;
using PointOfSale.BaseModels;
using PointOfSale.Data.AccessObjects;

namespace PointOfSale
{
    public partial class FrmCashier : Form
    {
        private Employee Employee;
        private FrmLogin FrmLogin;
        private List<Category> Categories;
        private Category ActiveCategory;
        public FrmCashier(Employee employee, FrmLogin form)
        {
            InitializeComponent();
            Employee = employee;
            FrmLogin = form;
        }

        private void FrmCashier_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = Employee.Name;
            lblEmployeeRole.Text = Employee.Role;
            Categories = AoCategory.Instance.SelectAll();
            foreach(Category category in Categories)
            {
                
            }
            SetActiveCategory(Categories[0]);
        }        

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void LnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin.Show();
            Close();
        }

        private void SetActiveCategory
    }
}

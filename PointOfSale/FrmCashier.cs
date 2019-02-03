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
        public FrmCashier(Employee employee, FrmLogin form)
        {
            InitializeComponent();
            Employee = employee;
            FrmLogin = form;
        }

        private void FrmCashier_Load(object sender, EventArgs e)
        {
            BindUI();
        }

        private void BindUI()
        {
            lblEmployeeName.Text = Employee.Name;
            lblEmployeeRole.Text = Employee.Role;
        }

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void LnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            FrmLogin.Show();
        }
    }
}

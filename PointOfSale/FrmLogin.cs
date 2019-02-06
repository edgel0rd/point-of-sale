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
    public partial class FrmLogin : Form
    {
        AoEmployee ao_employee = AoEmployee.Instance;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            Employee emp = ao_employee.Select("email", email);
            string error_message = string.Empty;

            if (email.Equals(string.Empty))
            {
                error_message = "Email is required";
            }
            else if (password.Equals(string.Empty))
            {
                error_message = "Password is Empty";
            }
            else if(emp == null || emp.Password != password)
            {
                error_message = "Incorrect email or password";
            }

            if (error_message.Equals(string.Empty))
            {
                Hide();
                if (emp.Role == Employee.Roles.Cashier)
                {
                    new FrmCashier(emp, this).Show();
                }
                else
                {
                    new FrmManager(emp, this).Show();
                }

                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(error_message);
            }
        }
    }
}

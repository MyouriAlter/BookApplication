using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace BookSaleApp
{
    public partial class frmLogin : Form, ILoginView
    {
        public string Username 
        {
            get => txtUsername.Text.Trim();            
        }

        public string Password 
        { 
            get => txtPassword.Text.Trim();
        }

        private LoginPresenter loginPresenter;

        public frmLogin()
        {
            InitializeComponent();
            try
            {
                loginPresenter = new LoginPresenter(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginPresenter.Login(Username, Password) == true)
            {
                frmMain newFrmMain = new frmMain();
                newFrmMain.FormClosing += frmLogin_Load;
                newFrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

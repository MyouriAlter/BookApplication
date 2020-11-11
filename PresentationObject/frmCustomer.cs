using BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class frmCustomer : Form, ICustomerView
    {
        private CustomerPresenter customerPresenter;
        private bool action;
        public frmCustomer(bool action, Customers customers)
        {
            InitializeComponent();
            this.action = action;

            try
            {
                customerPresenter = new CustomerPresenter(this);
                txtCustomerName.DataBindings.Clear();
                mskPhoneNo.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                txtCustomerName.DataBindings.Add("Text", customers, "CustomerName");
                mskPhoneNo.DataBindings.Add("Text", customers, "CustomerPhoneNo");
                txtAddress.DataBindings.Add("Text", customers, "Address");
                txtEmail.DataBindings.Add("Text", customers, "Email");

                if (action == false)
                    mskPhoneNo.Enabled = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        


        #region Customer Properties

        public string CustomerPhoneNo 
        { 
            get => mskPhoneNo.Text.Trim(); 
            set => mskPhoneNo.Text = value; 
        }
        public string CustomerName 
        {
            get => txtCustomerName.Text.Trim();
            set => txtCustomerName.Text = value;
        }
        public string Email 
        {
            get => txtEmail.Text.Trim();
            set => txtEmail.Text = value;
        }
        public string Address 
        {
            get => txtAddress.Text.Trim();
            set => txtAddress.Text = value;
        }

        #endregion

        private bool IsValidEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerPhoneNo) ||
                string.IsNullOrEmpty(CustomerName) ||
                string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(Email)
                )
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Email not correct format");
                return;
            }

            try
            {
                customerPresenter.Save(action);
                this.Close();
            } 
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Save failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using WinForms.Presenters;
using WinForms.Views;

namespace BookSaleApp
{
    public partial class frmManageBook : Form, IBookView
    {
        private bool action;
        private BookPresenter bookPresenter;

        public frmManageBook(bool action, Books books)
        {
            InitializeComponent();
            this.action = action;
            txtBookID.Text = 0.ToString();
            try
            {
                bookPresenter = new BookPresenter(this);
                txtBookID.DataBindings.Clear();
                txtBookAuthor.DataBindings.Clear();
                txtPublisherID.DataBindings.Clear();
                txtBookTitle.DataBindings.Clear();
                txtBookPrice.DataBindings.Clear();
                dateTimePickerPublishDate.DataBindings.Clear();
                numQuantity.DataBindings.Clear();
                if (!action && books != null)
                {
                    txtBookID.DataBindings.Add("Text", books, "BookID");
                    txtBookTitle.DataBindings.Add("Text", books, "BookTitle");
                    txtBookAuthor.DataBindings.Add("Text", books, "Author");
                    txtBookPrice.DataBindings.Add("Text", books, "Price");
                    txtPublisherID.DataBindings.Add("Text", books, "Publisher");
                    dateTimePickerPublishDate.DataBindings.Add("Text", books, "PublishDate");
                    numQuantity.DataBindings.Add("Text", books, "Quantity");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageBook_Load(object sender, EventArgs e)
        {
            txtBookID.Enabled = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            bookPresenter.Save(action);
            this.Close();
        }

        //IBookView
        public int ID
        {
            get => Convert.ToInt32(txtBookID.Text);
            set => txtBookID.Text = value.ToString();
        }

        public string Title { 
            get => txtBookTitle.Text; 
            set => txtBookTitle.Text = value;
        }

        public string Author
        {
            get => txtBookAuthor.Text; 
            set => txtBookAuthor.Text = value;
        }

        public string Publisher
        {
            get => txtPublisherID.Text; 
            set => txtPublisherID.Text = value;
        }

        public DateTime PublishDate
        {
            get => dateTimePickerPublishDate.Value; 
            set => dateTimePickerPublishDate.Value = value;
        }

        public double Price
        {
            get => Convert.ToDouble(txtBookPrice.Text); 
            set => txtBookPrice.Text = value.ToString(CultureInfo.CurrentCulture);
        }

        public int Quantity
        {
            get => Convert.ToInt32(numQuantity.Text); 
            set => numQuantity.Text = value.ToString();
        }
    }
}

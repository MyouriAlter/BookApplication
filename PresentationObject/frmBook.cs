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
    public partial class frmBook : Form, IBookView
    {
        private bool action;
        private BookPresenter bookPresenter;

        public frmBook(bool action, Books books)
        {
            InitializeComponent();
            
            this.action = action;
            txtBookID.Text = 0.ToString();
            try
            {
                bookPresenter = new BookPresenter(this);

                //Clear Data in text field
                txtBookID.DataBindings.Clear();
                txtBookAuthor.DataBindings.Clear();
                txtPublisher.DataBindings.Clear();
                txtBookTitle.DataBindings.Clear();
                numPrice.DataBindings.Clear();
                dateTimePickerPublishDate.DataBindings.Clear();
                numQuantity.DataBindings.Clear();                
                
                //Bind Data from book object into textfield
                txtBookID.DataBindings.Add("Text", books, "BookID");
                txtBookTitle.DataBindings.Add("Text", books, "BookTitle");
                txtBookAuthor.DataBindings.Add("Text", books, "Author");
                numPrice.DataBindings.Add("Text", books, "Price");
                txtPublisher.DataBindings.Add("Text", books, "Publisher");
                dateTimePickerPublishDate.DataBindings.Add("Text", books, "PublishDate");
                numQuantity.DataBindings.Add("Text", books, "Quantity");

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
            if (string.IsNullOrEmpty(Title) ||
                string.IsNullOrEmpty(Author) ||
                string.IsNullOrEmpty(Publisher) ||
                string.IsNullOrEmpty(Price.ToString()) ||
                string.IsNullOrEmpty(Quantity.ToString())
                )
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            try
            {
                 bookPresenter.Save(action);
                 this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Save failed");
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookTitle.Text = string.Empty;
            txtBookAuthor.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            dateTimePickerPublishDate.Value = DateTime.Today;
            numPrice.Value = 500;
            numQuantity.Value = 1;
        }

        #region Book Properties

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
            get => txtPublisher.Text; 
            set => txtPublisher.Text = value;
        }

        public DateTime PublishDate
        {
            get => dateTimePickerPublishDate.Value; 
            set => dateTimePickerPublishDate.Value = value;
        }

        public double Price
        {
            get => Convert.ToDouble(numPrice.Text); 
            set => numPrice.Text = value.ToString(CultureInfo.CurrentCulture);
        }

        public int Quantity
        {
            get => Convert.ToInt32(numQuantity.Text); 
            set => numQuantity.Text = value.ToString();
        }

        #endregion

        
    }
}

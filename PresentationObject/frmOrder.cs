using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessObjects;
using WinForms.Models;
using WinForms.Presenters;
using WinForms.Views;
using WinFroms.Presenters;
using WinFroms.Views;

namespace WinFroms
{
    public partial class frmOrder : Form, IOrderView, IBooksView, IBookView, ICustomerView, IOrderDetailView
    {
        private OrderPresenter orderPresenter;
        private BooksPresenter booksPresenter;
        private CustomerPresenter customerPresenter;
        private OrderDetailPresenter orderDetailPresenter;
        public frmOrder(Customers customers)
        {
            InitializeComponent();
            try
            {
                customerPresenter = new CustomerPresenter(this);
                booksPresenter = new BooksPresenter(this);
                orderPresenter = new OrderPresenter(this);
                orderDetailPresenter = new OrderDetailPresenter(this);
                
                txtCustomerName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                mskPhoneNo.DataBindings.Clear();

                if (customers != null)
                {
                    txtCustomerName.DataBindings.Add("Text", customers, "CustomerName");
                    txtAddress.DataBindings.Add("Text", customers, "Address");
                    txtEmail.DataBindings.Add("Text", customers, "Email");
                    mskPhoneNo.DataBindings.Add("Text", customers, "CustomerPhoneNo");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            txtAuthor.Enabled = false;
            txtPublisher.Enabled = false;
            txtPrice.Enabled = false;
            lbTotalPrice.Text = string.Empty;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {   
            try
            {
                //customerPresenter.Save();
                orderPresenter.ConfirmOrder();
                foreach (DataGridViewRow item in dgvOrderDetails.Rows)
                {
                    if (dgvOrderDetails.Rows.Count != item.Index + 1)
                    {
                        OrderDetailID = 0;
                        DetailBookId = Convert.ToInt32(item.Cells[0].Value.ToString());
                        //DetailBookTitle = item.Cells[1].Value.ToString();
                        DetailQuantity = Convert.ToInt32(item.Cells[5].Value.ToString());
                        orderDetailPresenter.ConfirmOrderDetail(OrderID);
                        
                    }
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, @"Apply failed!");
            }

            this.Close();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            booksPresenter.Display();
        }
        private void BindBooks(IList<BookModel> books)
        {
            if (books == null) return;
            cmbBookTitle.DataSource = books;
            cmbBookTitle.DisplayMember = "BookTitle";
        }

       
        public IList<OrderModel> Orders { get; set; }

        public IList<BookModel> Books
        {
            set
            {
                var books = value;
                BindBooks(books);
            }
        }

        public int ID { get; set; }
        public string Title { get; set; }

        public string Author
        {
            get => ((Books)cmbBookTitle.SelectedItem).Author;
            set => txtAuthor.Text = value;
        }

        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public string OrderID
        {
            get ; 
            set ;
        }

        //Phone No Form 
        public string PhoneNo
        {
            get => mskPhoneNo.Text;
            set => mskPhoneNo.Text = value;
        }

        //Customer View
        public string CustomerName
        {
            get => txtCustomerName.Text; 
            set => txtCustomerName.Text = value;
        }

        public string Email
        {
            get => txtEmail.Text; 
            set => txtEmail.Text = value;
        }
        public string Address { 
            get => txtAddress.Text; 
            set => txtAddress.Text = value;
        }

        public string CustomerPhoneNo
        {
            get => PhoneNo;
            set => PhoneNo = value;
        }

        public DateTime DateOfReceipt
        {
            get => DateTime.Now;
            set => throw new NotImplementedException();
        }

        public double SubPrice => (double) numQuantity.Value * ((BookModel) cmbBookTitle.SelectedItem).Price;

        public double TotalPrice { get; set; }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvOrderDetails.Rows[0].Clone();
            if (row == null) return;
            row.Cells[0].Value = ((BookModel)cmbBookTitle.SelectedItem).BookID;
            row.Cells[1].Value = ((BookModel)cmbBookTitle.SelectedItem).BookTitle;
            row.Cells[2].Value = ((BookModel)cmbBookTitle.SelectedItem).Author;
            row.Cells[3].Value = ((BookModel)cmbBookTitle.SelectedItem).Publisher;
            row.Cells[4].Value = ((BookModel)cmbBookTitle.SelectedItem).Price.ToString(CultureInfo.CurrentCulture);
            row.Cells[5].Value = numQuantity.Text;
            row.Cells[6].Value = SubPrice;
            dgvOrderDetails.Rows.Add(row);
            lbTotalPrice.Text = dgvOrderDetails.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[6].Value)).ToString(CultureInfo.InvariantCulture);
            TotalPrice = Convert.ToDouble(lbTotalPrice.Text);
        }

        private void cmbBookTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtAuthor.Text = ((BookModel)cmbBookTitle.SelectedItem).Author;
            txtPublisher.Text = ((BookModel)cmbBookTitle.SelectedItem).Publisher;
            txtPrice.Text = ((BookModel)cmbBookTitle.SelectedItem).Price.ToString(CultureInfo.CurrentCulture);
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.Rows.Count <= 1) return;
            foreach (DataGridViewRow item in this.dgvOrderDetails.SelectedRows)
            {
                if (dgvOrderDetails.Rows.Count != item.Index+1)
                    dgvOrderDetails.Rows.RemoveAt(item.Index);
            }
        }

        //Detail 
        public int OrderDetailID { get; set; }

        public string DetailOrderID
        {
            get ;
            set ;
        }
        public string DetailBookTitle { get; set; }
        public int DetailBookId { get; set; }
        public int DetailQuantity { get; set; }
    }
}

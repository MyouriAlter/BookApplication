using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BusinessObjects;
using WinForms.Models;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class frmOrder : Form, IOrderView, IBooksView, IBookView, IOrderDetailView
    {
        private OrderPresenter orderPresenter;
        private BooksPresenter booksPresenter;
        private BookPresenter bookPresenter;
        private OrderDetailPresenter orderDetailPresenter;
        public frmOrder(Customers customers)
        {
            InitializeComponent();
            try
            {
                booksPresenter = new BooksPresenter(this);
                bookPresenter = new BookPresenter(this);
                orderPresenter = new OrderPresenter(this);
                orderDetailPresenter = new OrderDetailPresenter(this);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            txtAuthor.Enabled = false;
            txtPublisher.Enabled = false;
            txtPrice.Enabled = false;
            lbTotalPrice.Text = string.Empty;
            PhoneNo = customers.CustomerPhoneNo;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.Rows.Count <= 1)
            {
                MessageBox.Show("Add more books to confirm purchase", "No books");
                return;
            }

            try
            {
                orderPresenter.ConfirmOrder();

                foreach (DataGridViewRow item in dgvOrderDetails.Rows)
                {
                    if (dgvOrderDetails.Rows.Count != item.Index + 1)
                    {
                        OrderDetailID = 0;
                        DetailBookID = Convert.ToInt32(item.Cells[0].Value.ToString());
                        DetailQuantity = Convert.ToInt32(item.Cells[5].Value.ToString());
                        bookPresenter.UpdateBookQuantity(DetailBookID, DetailQuantity);
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

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            if (numQuantity.Value <= 0) return;

            DataGridViewRow row = (DataGridViewRow)dgvOrderDetails.Rows[0].Clone();
            if (row == null) return;
            
            ID = ((BookModel)cmbBookTitle.SelectedItem).BookID;

            bool flag = false;
            int index = 0;           

            for (int i = 0; i<dgvOrderDetails.Rows.Count-1; i++)
            {
                if (ID == int.Parse(dgvOrderDetails.Rows[i].Cells[0].Value.ToString()))
                {
                    index = i;
                    flag = true;                    
                }                
            }

            if (flag == false)
            {
                row.Cells[0].Value = ((BookModel)cmbBookTitle.SelectedItem).BookID;
                row.Cells[1].Value = ((BookModel)cmbBookTitle.SelectedItem).BookTitle;
                row.Cells[2].Value = ((BookModel)cmbBookTitle.SelectedItem).Author;
                row.Cells[3].Value = ((BookModel)cmbBookTitle.SelectedItem).Publisher;
                row.Cells[4].Value = ((BookModel)cmbBookTitle.SelectedItem).Price.ToString(CultureInfo.CurrentCulture);
                row.Cells[5].Value = numQuantity.Text;
                row.Cells[6].Value = double.Parse(row.Cells[4].Value.ToString()) * double.Parse(row.Cells[5].Value.ToString());
                dgvOrderDetails.Rows.Add(row);
            }
            else
            {
                DetailQuantity = int.Parse(numQuantity.Text);
                if ((DetailQuantity + int.Parse(dgvOrderDetails.Rows[index].Cells[5].Value.ToString())) >= numQuantity.Maximum)
                {
                    dgvOrderDetails.Rows[index].Cells[5].Value = numQuantity.Maximum;                    
                }
                else
                {
                    dgvOrderDetails.Rows[index].Cells[5].Value = (DetailQuantity + int.Parse(dgvOrderDetails.Rows[index].Cells[5].Value.ToString()));                    
                }
                dgvOrderDetails.Rows[index].Cells[6].Value = double.Parse(dgvOrderDetails.Rows[index].Cells[4].Value.ToString())
                    * double.Parse(dgvOrderDetails.Rows[index].Cells[5].Value.ToString());
            }            

            lbTotalPrice.Text = dgvOrderDetails.Rows.Cast<DataGridViewRow>()
                        .Sum(t => Convert.ToDouble(t.Cells[6].Value)).ToString(CultureInfo.InvariantCulture);
            TotalPrice = Convert.ToDouble(lbTotalPrice.Text);
        }

        private void cmbBookTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtAuthor.Text = ((BookModel)cmbBookTitle.SelectedItem).Author;
            txtPublisher.Text = ((BookModel)cmbBookTitle.SelectedItem).Publisher;
            txtPrice.Text = ((BookModel)cmbBookTitle.SelectedItem).Price.ToString(CultureInfo.CurrentCulture);
            numQuantity.Maximum = ((BookModel)cmbBookTitle.SelectedItem).Quantity;
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.Rows.Count <= 1) return;
            foreach (DataGridViewRow item in this.dgvOrderDetails.SelectedRows)
            {
                if (dgvOrderDetails.Rows.Count != item.Index+1)
                    dgvOrderDetails.Rows.RemoveAt(item.Index);
            }
            lbTotalPrice.Text = dgvOrderDetails.Rows.Cast<DataGridViewRow>()
                        .Sum(t => Convert.ToDouble(t.Cells[6].Value)).ToString(CultureInfo.InvariantCulture);
            TotalPrice = Convert.ToDouble(lbTotalPrice.Text);
        }


        #region Book Properties

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

        #endregion

        #region Customer

        public string PhoneNo { get; set; }

        #endregion

        #region Order Properties

        public IList<OrderModel> Orders { get; set; }

        public string OrderID { get; set; }

        public DateTime DateOfReceipt
        {
            get => DateTime.Now;
            set => throw new NotImplementedException();
        }

        public double TotalPrice { get; set; }

        #endregion

        #region Order Detail Properties

        public int OrderDetailID { get; set; }
        public string DetailOrderID { get; set; }
        public string DetailBookTitle { get; set; }
        public int DetailBookID { get; set; }
        public int DetailQuantity { get; set; }        

        #endregion
        
        
    }
}

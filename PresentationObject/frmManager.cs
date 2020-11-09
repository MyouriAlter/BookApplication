using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using WinForms.Models;
using WinForms.Presenters;
using WinForms.Views;
using WinFroms;

namespace BookSaleApp
{
    public partial class frmManager : Form, IBooksView, ICustomersView, IOrdersView, IBookView
    {
        private BooksPresenter booksPresenter;
        private CustomersPresenter customersPresenter;
        private OrdersPresenter ordersPresenter;
        private BookPresenter bookPresenter;

        public frmManager()
        {
            InitializeComponent();

            try
            {
                booksPresenter = new BooksPresenter(this);
                customersPresenter = new CustomersPresenter(this);
                ordersPresenter = new OrdersPresenter(this);
                bookPresenter = new BookPresenter(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            booksPresenter.Display();
            customersPresenter.Display();
        }

        #region Book Presenter
        private void BindBook(BookModel book)
        {
            if (book == null) return;

            //Bind book detail into textbox
            txtBookID.Text = book.BookID.ToString();
            txtBookTitle.Text = book.BookTitle;
            txtBookAuthor.Text = book.Author;
            txtBookPublisher.Text = book.Publisher;
            txtBookPublishDate.Text = book.PublishDate.ToShortDateString();
            txtBookPrice.Text = book.Price.ToString();
            txtBookQuantity.Text = book.Quantity.ToString();
  
        }

        public IList<BookModel> Books
        {
            set
            {
                var books = value;
                // Clear nodes under root of tree
                var root = treeViewBooks.Nodes[0];
                root.Nodes.Clear();

                // Build the book tree
                foreach (var book in books)
                {
                    AddBookToTree(book);
                }
            }
        }

        private TreeNode AddBookToTree(BookModel book)
        {
            var node = new TreeNode();
            node.Text = book.BookTitle + " (" + book.Author + ")";
            node.Tag = book;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            this.treeViewBooks.Nodes[0].Nodes.Add(node);

            return node;
        }

        private void treeViewBooks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var book = treeViewBooks.SelectedNode.Tag as BookModel;
            BindBook(book);            
        }

        private void treeViewBooks_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewBooks.SelectedNode =
                    treeViewBooks.GetNodeAt(e.Location);

                //contextMenuStripMember.Show((Control)sender, e.Location);
            }
        }

        private void toolStripButtonAddBook_Click(object sender, EventArgs e)
        {
            /*
            using (var form = new frmManageBook(true))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    booksPresenter.Display();
                }
            }
            */
            //var book = treeViewBooks.SelectedNode.Tag as Books;
            frmManageBook newFrmManageBook = new frmManageBook(true, null);
            newFrmManageBook.FormClosing += frmManager_Load;
            newFrmManageBook.Show();

        }

        #endregion

        #region Customer Presenter
        public IList<CustomerModel> Customers
        {
            set
            {
                var customers = value;
                // Clear nodes under root of tree
                var root = treeViewCustomers.Nodes[0];
                root.Nodes.Clear();

                //Build the customer tree
                foreach (var customer in customers)
                {
                    AddCustomerToTree(customer);
                }
            }
        }

        private TreeNode AddCustomerToTree(CustomerModel customer)
        {
            var node = new TreeNode();
            node.Text = customer.CustomerName + "(" + customer.CustomerPhoneNo + ")"; 
            node.Tag = customer;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            this.treeViewCustomers.Nodes[0].Nodes.Add(node);
            return node;
        }

        private void treeViewCustomers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get selected customer. Note: root node does not have a customer record
            var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;
            if (customer == null) return;

            // Check if orders were already retrieved for customer
            if (customer.Orders.Count > 0)
                BindOrders(customer.Orders);
            else
            {
                this.Cursor = Cursors.WaitCursor;
                ordersPresenter.Display(customer.CustomerPhoneNo);
                this.Cursor = Cursors.Default;
            }
        }

        private void treeViewCustomers_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewCustomers.SelectedNode =
                    treeViewCustomers.GetNodeAt(e.Location);

                //contextMenuStripMember.Show((Control)sender, e.Location);
            }
        }

        #endregion

        #region Order Presenter
        public IList<OrderModel> Orders
        {
            set
            {
                // Unpack order transfer objects into order business objects.
                var orders = value;
                // Store orders for next time this customer is selected.
                var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;
                customer.Orders = orders;
                BindOrders(orders);
            }
        }
        
        private void BindOrders(IList<OrderModel> orders)
        {
            if (orders == null) return;
            dgvOrders.DataSource = orders;
            dgvOrders.Columns["OrderDetails"].Visible = false;
            dgvOrders.Columns["Customers"].Visible = false;
            dgvOrders.Columns["TotalPrice"].DefaultCellStyle.Alignment 
                = DataGridViewContentAlignment.MiddleRight;
        }

        #endregion

        #region Order Detail Presenter
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            dgvOrderDetails.DataSource = null;
            if (dgvOrders.SelectedRows.Count == 0) return;

            var row = dgvOrders.SelectedRows[0];
            if (row == null) return;

            string orderID = row.Cells["OrderID"].Value.ToString();            

            // Get customer record from treeview control.
            var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;

            // Check for root node. It does not have a customer record
            if (customer == null) return;

            // Locate order record
            foreach (var order in customer.Orders)
            {
                if (order.OrderID == orderID)
                {
                    if (order.OrderDetails.Count == 0) return;
                    dgvOrderDetails.DataSource = order.OrderDetails;
                    dgvOrderDetails.Columns["BookID"].Visible = false;
                    dgvOrderDetails.Columns["OrderID"].Visible = false;
                    dgvOrderDetails.Columns["OrderDetailID"].Visible = false;
                    dgvOrderDetails.Columns["Orders"].Visible = false;
                    dgvOrderDetails.Columns["Quantity"].DefaultCellStyle.Alignment 
                        = DataGridViewContentAlignment.MiddleRight;
                    return;
                }
            }            
        }
        #endregion

        private void toolStripButtonAddOrder_Click(object sender, EventArgs e)
        {
            var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;
            Customers customers = new Customers()
            {
                CustomerPhoneNo = customer.CustomerPhoneNo,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                Email = customer.Email
            };
            frmOrder order = new frmOrder(customers);
            order.FormClosing += frmManager_Load;
            order.Show();
        }
        private void toolStripButtonDeleteOrder_Click(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchValue = txtSearchValue.Text;
            booksPresenter.DisplaySearch(searchValue);
        }

        private void toolStripButtonEditBook_Click(object sender, EventArgs e)
        {
            var book = treeViewBooks.SelectedNode.Tag as BookModel;
            Books books = new Books()
            {
                BookID = book.BookID,
                BookTitle = book.BookTitle,
                Author = book.Author,
                Publisher = book.Publisher,
                PublishDate = book.PublishDate,
                Price = book.Price,
                Quantity = book.Quantity
            };
            frmManageBook newFrmManageBook = new frmManageBook(false, books);
            newFrmManageBook.FormClosing += frmManager_Load;
            newFrmManageBook.Show();
        }
        private void toolStripButtonDeleteBook_Click(object sender, EventArgs e)
        {
            bookPresenter.Delete();
            frmManager_Load(sender, e);
        }

        //IBookView
        public int ID
        {
            get => Convert.ToInt32(txtBookID.Text); 
            set => txtBookID.Text = value.ToString();
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmManager_Load(sender, e);
        }
    }
}

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
using WinForms;
using WinForms.Models;
using WinForms.Presenters;
using WinForms.Views;


namespace BookSaleApp
{
    public partial class frmMain : Form, IBooksView, IBookView, ICustomersView, IOrdersView, IOrderView
    {
        private BooksPresenter booksPresenter;
        private CustomersPresenter customersPresenter;
        private OrdersPresenter ordersPresenter;
        private OrderPresenter orderPresenter;

        public frmMain()
        {
            InitializeComponent();

            try
            {
                booksPresenter = new BooksPresenter(this);
                customersPresenter = new CustomersPresenter(this);
                ordersPresenter = new OrdersPresenter(this);
                orderPresenter = new OrderPresenter(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Form        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            booksPresenter.Display();
            treeViewBooks.ExpandAll();
            customersPresenter.Display();
            treeViewCustomers.ExpandAll();
        }

        #endregion

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
            node.Text = book.BookTitle + " [" + book.Author + "]";
            node.Tag = book;
            this.treeViewBooks.Nodes[0].Nodes.Add(node);

            return node;
        }

        private void treeViewBooks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var book = treeViewBooks.SelectedNode.Tag as BookModel;
            BindBook(book);
        }

        #endregion

        #region Book persistence
        private void toolStripButtonAddBook_Click(object sender, EventArgs e)
        {
            Books books = new Books()
            {
                BookID = 0,
                BookTitle = string.Empty,
                Author = string.Empty,
                Publisher = string.Empty,
                PublishDate = DateTime.Today,
                Price = 500,
                Quantity = 1
            };
            frmBook newFrmManageBook = new frmBook(true, books);
            newFrmManageBook.FormClosing += frmMain_Load;
            newFrmManageBook.Show();
        }

        private void toolStripButtonEditBook_Click(object sender, EventArgs e)
        {
            // Check if a node is selected (and not the root)
            if (treeViewBooks.SelectedNode == null ||
                treeViewBooks.SelectedNode.Text == "Books")
            {
                MessageBox.Show("No book is currently selected",
                            "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            frmBook newFrmManageBook = new frmBook(false, books);
            newFrmManageBook.FormClosing += frmMain_Load;
            newFrmManageBook.Show();
        }

        private void toolStripButtonDeleteBook_Click(object sender, EventArgs e)
        {
            // Check if a node is selected (and not the root)
            if (treeViewBooks.SelectedNode == null ||
                treeViewBooks.SelectedNode.Text == "Books")
            {
                MessageBox.Show("No book is currently selected",
                            "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var book = treeViewBooks.SelectedNode.Tag as BookModel;

            try
            {
                new BookPresenter(null).Delete(book.BookID);
                treeViewBooks.Nodes[0].Nodes.Remove(treeViewBooks.SelectedNode);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Delete failed");
            }


            frmMain_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchValue = txtSearchValue.Text;
            booksPresenter.DisplaySearch(searchValue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
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
            node.Text = customer.CustomerName + " [" + customer.CustomerPhoneNo + "]";
            node.Tag = customer;
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

                contextMenuStripCustomer.Show((Control)sender, e.Location);
            }
        }

        #endregion

        #region Customer persistence

        private void addNewCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers()
            {
                CustomerName = string.Empty,
                CustomerPhoneNo = string.Empty,
                Address = string.Empty,
                Email = string.Empty
            };
            frmCustomer newFrmCustomer = new frmCustomer(true, customers);
            newFrmCustomer.FormClosing += frmMain_Load;
            newFrmCustomer.Show();
        }

        private void editNewCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Check if a node is selected (and not the root)
            if (treeViewCustomers.SelectedNode == null ||
                treeViewCustomers.SelectedNode.Text == "Customers")
            {
                MessageBox.Show("No customer is currently selected",
                            "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;
            Customers customers = new Customers()
            {
                CustomerName = customer.CustomerName,
                CustomerPhoneNo = customer.CustomerPhoneNo,
                Address = customer.Address,
                Email = customer.Email
            };
            frmCustomer newFrmCustomer = new frmCustomer(false, customers);
            newFrmCustomer.FormClosing += frmMain_Load;
            newFrmCustomer.Show();
        }

        private void deleteCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Check if a node is selected (and not the root)
            if (treeViewCustomers.SelectedNode == null ||
                treeViewCustomers.SelectedNode.Text == "Customers")
            {
                MessageBox.Show("No customer is currently selected",
                            "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;

            try
            {
                if (customer.Orders.Count > 0)
                {
                    MessageBox.Show("Cannot delete " + customer.CustomerName + " because he/she has existing orders!", "Cannot Delete");
                    return;
                }

                // Execute delete
                new CustomerPresenter(null).Delete(customer.CustomerPhoneNo);

                // Remove node
                treeViewCustomers.Nodes[0].Nodes.Remove(treeViewCustomers.SelectedNode);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Delete failed");
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
            dgvOrders.Columns["TotalPrice"].DefaultCellStyle.Format = "#,0.###";
        }

        #endregion

        #region Order persistence

        private void toolStripButtonAddOrder_Click(object sender, EventArgs e)
        {
            // Check if a node is selected (and not the root)
            if (treeViewCustomers.SelectedNode == null ||
                treeViewCustomers.SelectedNode.Text == "Customers")
            {
                MessageBox.Show("No customer is currently selected",
                            "Add order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var customer = treeViewCustomers.SelectedNode.Tag as CustomerModel;
            Customers customers = new Customers()
            {
                CustomerPhoneNo = customer.CustomerPhoneNo,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                Email = customer.Email
            };

            frmOrder order = new frmOrder(customers);
            order.FormClosing += frmMain_Load;
            order.Show();
        }
        private void toolStripButtonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count <= 1) return;

            try
            {
                foreach (DataGridViewRow item in this.dgvOrders.SelectedRows)
                {
                    if (dgvOrders.Rows.Count != item.Index)
                    {
                        OrderID = dgvOrders.Rows[item.Index].Cells[0].Value.ToString();
                        orderPresenter.DeleteOrder(OrderID);
                    }
                }

                frmMain_Load(sender, e);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, @"Delete failed");
            }

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

        #region Book Properties

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

        #endregion

        #region Order persistence

        public string OrderID { get; set; }
        public string PhoneNo { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public double TotalPrice { get; set; }

        #endregion


    }
}

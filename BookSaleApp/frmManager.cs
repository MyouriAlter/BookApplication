using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinForms.Models;
using WinForms.Presenters;
using WinForms.Views;

namespace BookSaleApp
{
    public partial class frmManager : Form, IBooksView
    {
        private BookPresenter _bookPresenter;

        public IList<BookModel> Books { set => throw new NotImplementedException(); }

        public frmManager()
        {
            InitializeComponent();

            try
            {
                _bookPresenter = new BookPresenter(this);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmManageBook addBook = new frmManageBook();
            addBook.Show();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            frmManageBook updateBook = new frmManageBook();
            updateBook.Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Show();
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

        }
    }
}

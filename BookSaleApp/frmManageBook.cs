using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSaleApp
{
    public partial class frmManageBook : Form
    {
        public frmManageBook()
        {
            InitializeComponent();
        }

        private void frmBookDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {

        }
    }
}

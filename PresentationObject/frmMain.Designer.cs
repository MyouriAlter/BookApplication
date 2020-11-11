namespace BookSaleApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Books");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Customers");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeViewBooks = new System.Windows.Forms.TreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookPublishDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStripBookAction = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteBook = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.treeViewCustomers = new System.Windows.Forms.TreeView();
            this.contextMenuStripCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editNewCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.buttonOrderDetails = new System.Windows.Forms.Button();
            this.toolStripOrderAction = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteOrder = new System.Windows.Forms.ToolStripButton();
            this.menuStripAction = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripBookAction.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStripCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.toolStripOrderAction.SuspendLayout();
            this.menuStripAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 622);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.toolStripBookAction);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(931, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(927, 563);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeViewBooks);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer2.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer2.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel2.Controls.Add(this.txtSearchValue);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2MinSize = 85;
            this.splitContainer2.Size = new System.Drawing.Size(323, 563);
            this.splitContainer2.SplitterDistance = 471;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeViewBooks
            // 
            this.treeViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBooks.Location = new System.Drawing.Point(0, 0);
            this.treeViewBooks.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewBooks.Name = "treeViewBooks";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Books";
            this.treeViewBooks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewBooks.ShowPlusMinus = false;
            this.treeViewBooks.ShowRootLines = false;
            this.treeViewBooks.Size = new System.Drawing.Size(323, 471);
            this.treeViewBooks.TabIndex = 0;
            this.treeViewBooks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewBooks_AfterSelect);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(236, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(155, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchValue.Location = new System.Drawing.Point(106, 10);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(205, 23);
            this.txtSearchValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search a book:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBookQuantity);
            this.panel1.Controls.Add(this.txtBookPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBookPublishDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBookPublisher);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBookAuthor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBookTitle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 563);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(23, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quantity";
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Enabled = false;
            this.txtBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookQuantity.Location = new System.Drawing.Point(152, 444);
            this.txtBookQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(162, 28);
            this.txtBookQuantity.TabIndex = 7;
            this.txtBookQuantity.TabStop = false;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Enabled = false;
            this.txtBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPrice.Location = new System.Drawing.Point(152, 403);
            this.txtBookPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(162, 28);
            this.txtBookPrice.TabIndex = 6;
            this.txtBookPrice.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(23, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Price";
            // 
            // txtBookPublishDate
            // 
            this.txtBookPublishDate.Enabled = false;
            this.txtBookPublishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublishDate.Location = new System.Drawing.Point(152, 349);
            this.txtBookPublishDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPublishDate.Name = "txtBookPublishDate";
            this.txtBookPublishDate.Size = new System.Drawing.Size(274, 28);
            this.txtBookPublishDate.TabIndex = 5;
            this.txtBookPublishDate.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(23, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Publish Date";
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Enabled = false;
            this.txtBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublisher.Location = new System.Drawing.Point(152, 306);
            this.txtBookPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(274, 28);
            this.txtBookPublisher.TabIndex = 4;
            this.txtBookPublisher.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(23, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Publisher";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Enabled = false;
            this.txtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthor.Location = new System.Drawing.Point(152, 214);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookAuthor.Multiline = true;
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(435, 64);
            this.txtBookAuthor.TabIndex = 3;
            this.txtBookAuthor.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Author";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Enabled = false;
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(152, 102);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookTitle.Multiline = true;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(436, 86);
            this.txtBookTitle.TabIndex = 2;
            this.txtBookTitle.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(23, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Title";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(152, 58);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(162, 28);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(23, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "BookID";
            // 
            // toolStripBookAction
            // 
            this.toolStripBookAction.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBookAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddBook,
            this.toolStripButtonEditBook,
            this.toolStripButtonDeleteBook});
            this.toolStripBookAction.Location = new System.Drawing.Point(2, 2);
            this.toolStripBookAction.Name = "toolStripBookAction";
            this.toolStripBookAction.Size = new System.Drawing.Size(927, 25);
            this.toolStripBookAction.TabIndex = 7;
            this.toolStripBookAction.Text = "toolStrip2";
            // 
            // toolStripButtonAddBook
            // 
            this.toolStripButtonAddBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddBook.Name = "toolStripButtonAddBook";
            this.toolStripButtonAddBook.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.toolStripButtonAddBook.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonAddBook.Text = "Add";
            this.toolStripButtonAddBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAddBook.Click += new System.EventHandler(this.toolStripButtonAddBook_Click);
            // 
            // toolStripButtonEditBook
            // 
            this.toolStripButtonEditBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditBook.Name = "toolStripButtonEditBook";
            this.toolStripButtonEditBook.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.toolStripButtonEditBook.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonEditBook.Text = "Edit";
            this.toolStripButtonEditBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonEditBook.Click += new System.EventHandler(this.toolStripButtonEditBook_Click);
            // 
            // toolStripButtonDeleteBook
            // 
            this.toolStripButtonDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteBook.Name = "toolStripButtonDeleteBook";
            this.toolStripButtonDeleteBook.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.toolStripButtonDeleteBook.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonDeleteBook.Text = "Delete";
            this.toolStripButtonDeleteBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDeleteBook.Click += new System.EventHandler(this.toolStripButtonDeleteBook_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Controls.Add(this.toolStripOrderAction);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(931, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(2, 27);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeViewCustomers);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(927, 563);
            this.splitContainer3.SplitterDistance = 268;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 17;
            // 
            // treeViewCustomers
            // 
            this.treeViewCustomers.ContextMenuStrip = this.contextMenuStripCustomer;
            this.treeViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.treeViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewCustomers.Name = "treeViewCustomers";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Customers";
            this.treeViewCustomers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewCustomers.ShowPlusMinus = false;
            this.treeViewCustomers.ShowRootLines = false;
            this.treeViewCustomers.Size = new System.Drawing.Size(268, 563);
            this.treeViewCustomers.TabIndex = 0;
            this.treeViewCustomers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCustomers_AfterSelect);
            this.treeViewCustomers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewCustomers_MouseUp);
            // 
            // contextMenuStripCustomer
            // 
            this.contextMenuStripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem1,
            this.editNewCustomerToolStripMenuItem1,
            this.deleteCustomerToolStripMenuItem1});
            this.contextMenuStripCustomer.Name = "contextMenuStripCustomer";
            this.contextMenuStripCustomer.Size = new System.Drawing.Size(179, 70);
            // 
            // addNewCustomerToolStripMenuItem1
            // 
            this.addNewCustomerToolStripMenuItem1.Name = "addNewCustomerToolStripMenuItem1";
            this.addNewCustomerToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.addNewCustomerToolStripMenuItem1.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem1.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem1_Click);
            // 
            // editNewCustomerToolStripMenuItem1
            // 
            this.editNewCustomerToolStripMenuItem1.Name = "editNewCustomerToolStripMenuItem1";
            this.editNewCustomerToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.editNewCustomerToolStripMenuItem1.Text = "Edit Customer";
            this.editNewCustomerToolStripMenuItem1.Click += new System.EventHandler(this.editNewCustomerToolStripMenuItem1_Click);
            // 
            // deleteCustomerToolStripMenuItem1
            // 
            this.deleteCustomerToolStripMenuItem1.Name = "deleteCustomerToolStripMenuItem1";
            this.deleteCustomerToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.deleteCustomerToolStripMenuItem1.Text = "Delete Customer";
            this.deleteCustomerToolStripMenuItem1.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem1_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dgvOrders);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvOrderDetails);
            this.splitContainer4.Panel2.Controls.Add(this.buttonOrderDetails);
            this.splitContainer4.Size = new System.Drawing.Size(656, 563);
            this.splitContainer4.SplitterDistance = 190;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(656, 190);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 40);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(656, 330);
            this.dgvOrderDetails.TabIndex = 3;
            // 
            // buttonOrderDetails
            // 
            this.buttonOrderDetails.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOrderDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.buttonOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderDetails.Name = "buttonOrderDetails";
            this.buttonOrderDetails.Size = new System.Drawing.Size(656, 40);
            this.buttonOrderDetails.TabIndex = 2;
            this.buttonOrderDetails.Text = "Order Details";
            this.buttonOrderDetails.UseVisualStyleBackColor = false;
            // 
            // toolStripOrderAction
            // 
            this.toolStripOrderAction.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripOrderAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddOrder,
            this.toolStripButtonDeleteOrder});
            this.toolStripOrderAction.Location = new System.Drawing.Point(2, 2);
            this.toolStripOrderAction.Name = "toolStripOrderAction";
            this.toolStripOrderAction.Size = new System.Drawing.Size(927, 25);
            this.toolStripOrderAction.TabIndex = 16;
            this.toolStripOrderAction.Text = "toolStrip1";
            // 
            // toolStripButtonAddOrder
            // 
            this.toolStripButtonAddOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddOrder.Name = "toolStripButtonAddOrder";
            this.toolStripButtonAddOrder.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.toolStripButtonAddOrder.Size = new System.Drawing.Size(107, 22);
            this.toolStripButtonAddOrder.Text = "Add New Order";
            this.toolStripButtonAddOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAddOrder.Click += new System.EventHandler(this.toolStripButtonAddOrder_Click);
            // 
            // toolStripButtonDeleteOrder
            // 
            this.toolStripButtonDeleteOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteOrder.Name = "toolStripButtonDeleteOrder";
            this.toolStripButtonDeleteOrder.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.toolStripButtonDeleteOrder.Size = new System.Drawing.Size(91, 22);
            this.toolStripButtonDeleteOrder.Text = "Delete Order";
            this.toolStripButtonDeleteOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDeleteOrder.Click += new System.EventHandler(this.toolStripButtonDeleteOrder_Click);
            // 
            // menuStripAction
            // 
            this.menuStripAction.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStripAction.Location = new System.Drawing.Point(0, 0);
            this.menuStripAction.Name = "menuStripAction";
            this.menuStripAction.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripAction.Size = new System.Drawing.Size(957, 24);
            this.menuStripAction.TabIndex = 1;
            this.menuStripAction.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "&Login";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logOutToolStripMenuItem.Text = "Lo&gout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.editBookToolStripMenuItem1,
            this.deleteBookToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "&Book";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewBookToolStripMenuItem.Text = "&Add New";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddBook_Click);
            // 
            // editBookToolStripMenuItem1
            // 
            this.editBookToolStripMenuItem1.Name = "editBookToolStripMenuItem1";
            this.editBookToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.editBookToolStripMenuItem1.Text = "&Edit";
            this.editBookToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButtonEditBook_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteBookToolStripMenuItem.Text = "&Delete";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonDeleteBook_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.editCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "&Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewCustomerToolStripMenuItem.Text = "&Add New";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem1_Click);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editCustomerToolStripMenuItem.Text = "Edit";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.editNewCustomerToolStripMenuItem1_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteCustomerToolStripMenuItem.Text = "&Delete";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "&Order";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddOrder_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStripAction);
            this.MainMenuStrip = this.menuStripAction;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Sale Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripBookAction.ResumeLayout(false);
            this.toolStripBookAction.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStripCustomer.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.toolStripOrderAction.ResumeLayout(false);
            this.toolStripOrderAction.PerformLayout();
            this.menuStripAction.ResumeLayout(false);
            this.menuStripAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStripAction;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripBookAction;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditBook;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddBook;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteBook;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookPublishDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView treeViewCustomers;
        private System.Windows.Forms.ToolStrip toolStripOrderAction;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteOrder;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button buttonOrderDetails;
        private System.Windows.Forms.TreeView treeViewBooks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCustomer;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editNewCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
    }
}


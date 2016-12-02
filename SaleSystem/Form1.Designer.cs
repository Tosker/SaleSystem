namespace SaleSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.SignupButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.ManageButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.historyView = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stampCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userBox = new System.Windows.Forms.TextBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.lastLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemView = new System.Windows.Forms.ListView();
            this.productCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.employeeLbl = new System.Windows.Forms.Label();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateLbl);
            this.groupBox1.Controls.Add(this.timeLbl);
            this.groupBox1.Controls.Add(this.SignupButton);
            this.groupBox1.Controls.Add(this.HistoryButton);
            this.groupBox1.Controls.Add(this.SaleButton);
            this.groupBox1.Controls.Add(this.ManageButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1869, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(862, 70);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(167, 36);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "12/12/2016";
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(818, 31);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(248, 39);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "Time: 16:00:00";
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryButton.Image")));
            this.HistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistoryButton.Location = new System.Drawing.Point(378, 41);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(282, 75);
            this.HistoryButton.TabIndex = 4;
            this.HistoryButton.Text = "Inventory";
            this.HistoryButton.UseVisualStyleBackColor = false;
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.SystemColors.Control;
            this.SignupButton.FlatAppearance.BorderSize = 0;
            this.SignupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupButton.Image = ((System.Drawing.Image)(resources.GetObject("SignupButton.Image")));
            this.SignupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignupButton.Location = new System.Drawing.Point(1562, 41);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(282, 75);
            this.SignupButton.TabIndex = 3;
            this.SignupButton.Text = "Sign Up";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaleButton.FlatAppearance.BorderSize = 0;
            this.SaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaleButton.Image = ((System.Drawing.Image)(resources.GetObject("SaleButton.Image")));
            this.SaleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaleButton.Location = new System.Drawing.Point(1236, 41);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(282, 75);
            this.SaleButton.TabIndex = 2;
            this.SaleButton.Text = "Sale";
            this.SaleButton.UseVisualStyleBackColor = false;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.BackColor = System.Drawing.SystemColors.Control;
            this.ManageButton.FlatAppearance.BorderSize = 0;
            this.ManageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManageButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageButton.Image")));
            this.ManageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageButton.Location = new System.Drawing.Point(45, 41);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(282, 75);
            this.ManageButton.TabIndex = 0;
            this.ManageButton.Text = "Manage";
            this.ManageButton.UseVisualStyleBackColor = false;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.historyView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(979, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 644);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
            // 
            // historyView
            // 
            this.historyView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.stampCol});
            this.historyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyView.ForeColor = System.Drawing.Color.White;
            this.historyView.FullRowSelect = true;
            this.historyView.Location = new System.Drawing.Point(19, 31);
            this.historyView.Name = "historyView";
            this.historyView.Size = new System.Drawing.Size(397, 591);
            this.historyView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.historyView.TabIndex = 0;
            this.historyView.UseCompatibleStateImageBehavior = false;
            this.historyView.View = System.Windows.Forms.View.Details;
            this.historyView.SelectedIndexChanged += new System.EventHandler(this.historyView_SelectedIndexChanged);
            // 
            // idCol
            // 
            this.idCol.Text = "Order #";
            this.idCol.Width = 166;
            // 
            // stampCol
            // 
            this.stampCol.Text = "Order Date";
            this.stampCol.Width = 227;
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.Teal;
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.White;
            this.userBox.Location = new System.Drawing.Point(20, 83);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(434, 32);
            this.userBox.TabIndex = 2;
            this.userBox.Text = "test2@test.com";
            // 
            // lookupButton
            // 
            this.lookupButton.BackColor = System.Drawing.SystemColors.Control;
            this.lookupButton.FlatAppearance.BorderSize = 0;
            this.lookupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lookupButton.Image = ((System.Drawing.Image)(resources.GetObject("lookupButton.Image")));
            this.lookupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lookupButton.Location = new System.Drawing.Point(20, 121);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(434, 67);
            this.lookupButton.TabIndex = 3;
            this.lookupButton.Text = "Look Up";
            this.lookupButton.UseVisualStyleBackColor = false;
            this.lookupButton.Click += new System.EventHandler(this.lookupButton_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(15, 254);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(140, 30);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "First Name";
            // 
            // lastLbl
            // 
            this.lastLbl.AutoSize = true;
            this.lastLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLbl.ForeColor = System.Drawing.Color.White;
            this.lastLbl.Location = new System.Drawing.Point(201, 254);
            this.lastLbl.Name = "lastLbl";
            this.lastLbl.Size = new System.Drawing.Size(137, 30);
            this.lastLbl.TabIndex = 5;
            this.lastLbl.Text = "Last Name";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(15, 423);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(78, 30);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.ForeColor = System.Drawing.Color.White;
            this.addressLbl.Location = new System.Drawing.Point(15, 342);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(107, 30);
            this.addressLbl.TabIndex = 7;
            this.addressLbl.Text = "Address";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Teal;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(20, 287);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(180, 35);
            this.nameBox.TabIndex = 8;
            // 
            // lastBox
            // 
            this.lastBox.BackColor = System.Drawing.Color.Teal;
            this.lastBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBox.ForeColor = System.Drawing.Color.White;
            this.lastBox.Location = new System.Drawing.Point(206, 287);
            this.lastBox.Name = "lastBox";
            this.lastBox.ReadOnly = true;
            this.lastBox.Size = new System.Drawing.Size(248, 35);
            this.lastBox.TabIndex = 9;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.Teal;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.White;
            this.addressBox.Location = new System.Drawing.Point(20, 375);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(434, 35);
            this.addressBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.Teal;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(20, 456);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(434, 35);
            this.emailBox.TabIndex = 11;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(20, 510);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(434, 99);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Member Email";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.itemView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1442, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 644);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items In Order";
            // 
            // itemView
            // 
            this.itemView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCol,
            this.priceCol});
            this.itemView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemView.ForeColor = System.Drawing.Color.White;
            this.itemView.FullRowSelect = true;
            this.itemView.Location = new System.Drawing.Point(28, 37);
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(397, 585);
            this.itemView.TabIndex = 0;
            this.itemView.UseCompatibleStateImageBehavior = false;
            this.itemView.View = System.Windows.Forms.View.Details;
            // 
            // productCol
            // 
            this.productCol.Text = "Product";
            this.productCol.Width = 282;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Price";
            this.priceCol.Width = 110;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.userBox);
            this.groupBox4.Controls.Add(this.lookupButton);
            this.groupBox4.Controls.Add(this.updateBtn);
            this.groupBox4.Controls.Add(this.nameLbl);
            this.groupBox4.Controls.Add(this.emailBox);
            this.groupBox4.Controls.Add(this.lastLbl);
            this.groupBox4.Controls.Add(this.addressBox);
            this.groupBox4.Controls.Add(this.emailLbl);
            this.groupBox4.Controls.Add(this.lastBox);
            this.groupBox4.Controls.Add(this.addressLbl);
            this.groupBox4.Controls.Add(this.nameBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(23, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 631);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Lookup";
            // 
            // clockTimer
            // 
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(43, 913);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(423, 59);
            this.loginBtn.TabIndex = 16;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Teal;
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBox.ForeColor = System.Drawing.Color.White;
            this.loginBox.Location = new System.Drawing.Point(43, 870);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(423, 37);
            this.loginBox.TabIndex = 17;
            this.loginBox.Text = "190577";
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.BackColor = System.Drawing.Color.Transparent;
            this.employeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLbl.ForeColor = System.Drawing.Color.White;
            this.employeeLbl.Location = new System.Drawing.Point(1465, 861);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Size = new System.Drawing.Size(265, 29);
            this.employeeLbl.TabIndex = 18;
            this.employeeLbl.Text = "Logged On: Employee";
            // 
            // signoutBtn
            // 
            this.signoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.signoutBtn.FlatAppearance.BorderSize = 0;
            this.signoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signoutBtn.Image")));
            this.signoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signoutBtn.Location = new System.Drawing.Point(1469, 893);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Size = new System.Drawing.Size(423, 102);
            this.signoutBtn.TabIndex = 19;
            this.signoutBtn.Text = "Sign Out";
            this.signoutBtn.UseVisualStyleBackColor = false;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.employeeLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.signoutBtn);
            this.Controls.Add(this.loginBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "POS V1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView historyView;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label lastLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader stampCol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView itemView;
        private System.Windows.Forms.ColumnHeader productCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label employeeLbl;
        private System.Windows.Forms.Button signoutBtn;
    }
}


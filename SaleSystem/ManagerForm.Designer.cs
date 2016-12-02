namespace SaleSystem
{
    partial class ManagerForm
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
            this.inventoryView = new System.Windows.Forms.ListView();
            this.itemCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descrCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.merchPage = new System.Windows.Forms.TabPage();
            this.employeePage = new System.Windows.Forms.TabPage();
            this.elastBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eremoveBtn = new System.Windows.Forms.Button();
            this.eupdateBtn = new System.Windows.Forms.Button();
            this.ecreateBtn = new System.Windows.Forms.Button();
            this.etitleBox = new System.Windows.Forms.TextBox();
            this.ewageBox = new System.Windows.Forms.TextBox();
            this.eidBox = new System.Windows.Forms.TextBox();
            this.efirstBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.merchPage.SuspendLayout();
            this.employeePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryView
            // 
            this.inventoryView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemCol,
            this.idCol,
            this.descrCol,
            this.priceCol});
            this.inventoryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryView.ForeColor = System.Drawing.Color.White;
            this.inventoryView.FullRowSelect = true;
            this.inventoryView.Location = new System.Drawing.Point(6, 6);
            this.inventoryView.Name = "inventoryView";
            this.inventoryView.Size = new System.Drawing.Size(479, 442);
            this.inventoryView.TabIndex = 0;
            this.inventoryView.UseCompatibleStateImageBehavior = false;
            this.inventoryView.View = System.Windows.Forms.View.Details;
            this.inventoryView.SelectedIndexChanged += new System.EventHandler(this.inventoryView_SelectedIndexChanged);
            // 
            // itemCol
            // 
            this.itemCol.Text = "ID";
            this.itemCol.Width = 75;
            // 
            // idCol
            // 
            this.idCol.Text = "Name";
            this.idCol.Width = 171;
            // 
            // descrCol
            // 
            this.descrCol.Text = "Price";
            this.descrCol.Width = 87;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Category";
            this.priceCol.Width = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Teal;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(498, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(171, 32);
            this.nameBox.TabIndex = 3;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.Teal;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.White;
            this.idBox.Location = new System.Drawing.Point(498, 172);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(112, 32);
            this.idBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(493, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item ID";
            // 
            // descrBox
            // 
            this.descrBox.BackColor = System.Drawing.Color.Teal;
            this.descrBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrBox.ForeColor = System.Drawing.Color.White;
            this.descrBox.Location = new System.Drawing.Point(498, 105);
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(171, 32);
            this.descrBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(493, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.Teal;
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.ForeColor = System.Drawing.Color.White;
            this.priceBox.Location = new System.Drawing.Point(498, 239);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(112, 32);
            this.priceBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(493, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Price";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.Location = new System.Drawing.Point(496, 277);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(171, 69);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemoveButton.Location = new System.Drawing.Point(496, 403);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(171, 45);
            this.RemoveButton.TabIndex = 11;
            this.RemoveButton.Text = "Remove Item";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditButton.Location = new System.Drawing.Point(496, 352);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(171, 45);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Update Item";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.merchPage);
            this.tabControl.Controls.Add(this.employeePage);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(686, 493);
            this.tabControl.TabIndex = 13;
            // 
            // merchPage
            // 
            this.merchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.merchPage.Controls.Add(this.AddButton);
            this.merchPage.Controls.Add(this.RemoveButton);
            this.merchPage.Controls.Add(this.EditButton);
            this.merchPage.Controls.Add(this.inventoryView);
            this.merchPage.Controls.Add(this.priceBox);
            this.merchPage.Controls.Add(this.label1);
            this.merchPage.Controls.Add(this.nameBox);
            this.merchPage.Controls.Add(this.label2);
            this.merchPage.Controls.Add(this.label4);
            this.merchPage.Controls.Add(this.idBox);
            this.merchPage.Controls.Add(this.descrBox);
            this.merchPage.Controls.Add(this.label3);
            this.merchPage.Location = new System.Drawing.Point(4, 33);
            this.merchPage.Name = "merchPage";
            this.merchPage.Padding = new System.Windows.Forms.Padding(3);
            this.merchPage.Size = new System.Drawing.Size(678, 456);
            this.merchPage.TabIndex = 0;
            this.merchPage.Text = "Merchandise";
            // 
            // employeePage
            // 
            this.employeePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.employeePage.Controls.Add(this.elastBox);
            this.employeePage.Controls.Add(this.label9);
            this.employeePage.Controls.Add(this.employeeView);
            this.employeePage.Controls.Add(this.eremoveBtn);
            this.employeePage.Controls.Add(this.eupdateBtn);
            this.employeePage.Controls.Add(this.ecreateBtn);
            this.employeePage.Controls.Add(this.etitleBox);
            this.employeePage.Controls.Add(this.ewageBox);
            this.employeePage.Controls.Add(this.eidBox);
            this.employeePage.Controls.Add(this.efirstBox);
            this.employeePage.Controls.Add(this.label8);
            this.employeePage.Controls.Add(this.label7);
            this.employeePage.Controls.Add(this.label6);
            this.employeePage.Controls.Add(this.label5);
            this.employeePage.Location = new System.Drawing.Point(4, 33);
            this.employeePage.Name = "employeePage";
            this.employeePage.Padding = new System.Windows.Forms.Padding(3);
            this.employeePage.Size = new System.Drawing.Size(678, 456);
            this.employeePage.TabIndex = 1;
            this.employeePage.Text = "Employees";
            this.employeePage.Click += new System.EventHandler(this.employeePage_Click);
            // 
            // elastBox
            // 
            this.elastBox.BackColor = System.Drawing.Color.Teal;
            this.elastBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elastBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elastBox.ForeColor = System.Drawing.Color.White;
            this.elastBox.Location = new System.Drawing.Point(10, 88);
            this.elastBox.Name = "elastBox";
            this.elastBox.Size = new System.Drawing.Size(181, 29);
            this.elastBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Last Name";
            // 
            // employeeView
            // 
            this.employeeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.employeeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.employeeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeView.ForeColor = System.Drawing.Color.White;
            this.employeeView.FullRowSelect = true;
            this.employeeView.Location = new System.Drawing.Point(211, 6);
            this.employeeView.Name = "employeeView";
            this.employeeView.Size = new System.Drawing.Size(461, 436);
            this.employeeView.TabIndex = 15;
            this.employeeView.UseCompatibleStateImageBehavior = false;
            this.employeeView.View = System.Windows.Forms.View.Details;
            this.employeeView.SelectedIndexChanged += new System.EventHandler(this.employeeView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Wage";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.Width = 115;
            // 
            // eremoveBtn
            // 
            this.eremoveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.eremoveBtn.FlatAppearance.BorderSize = 0;
            this.eremoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eremoveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eremoveBtn.Location = new System.Drawing.Point(10, 403);
            this.eremoveBtn.Name = "eremoveBtn";
            this.eremoveBtn.Size = new System.Drawing.Size(181, 39);
            this.eremoveBtn.TabIndex = 14;
            this.eremoveBtn.Text = "Remove";
            this.eremoveBtn.UseVisualStyleBackColor = false;
            this.eremoveBtn.Click += new System.EventHandler(this.eremoveBtn_Click);
            // 
            // eupdateBtn
            // 
            this.eupdateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.eupdateBtn.FlatAppearance.BorderSize = 0;
            this.eupdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eupdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eupdateBtn.Location = new System.Drawing.Point(10, 355);
            this.eupdateBtn.Name = "eupdateBtn";
            this.eupdateBtn.Size = new System.Drawing.Size(181, 42);
            this.eupdateBtn.TabIndex = 13;
            this.eupdateBtn.Text = "Update";
            this.eupdateBtn.UseVisualStyleBackColor = false;
            this.eupdateBtn.Click += new System.EventHandler(this.eupdateBtn_Click);
            // 
            // ecreateBtn
            // 
            this.ecreateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ecreateBtn.FlatAppearance.BorderSize = 0;
            this.ecreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecreateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ecreateBtn.Location = new System.Drawing.Point(10, 300);
            this.ecreateBtn.Name = "ecreateBtn";
            this.ecreateBtn.Size = new System.Drawing.Size(181, 49);
            this.ecreateBtn.TabIndex = 12;
            this.ecreateBtn.Text = "Create";
            this.ecreateBtn.UseVisualStyleBackColor = false;
            this.ecreateBtn.Click += new System.EventHandler(this.ecreateBtn_Click);
            // 
            // etitleBox
            // 
            this.etitleBox.BackColor = System.Drawing.Color.Teal;
            this.etitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etitleBox.ForeColor = System.Drawing.Color.White;
            this.etitleBox.Location = new System.Drawing.Point(9, 206);
            this.etitleBox.Name = "etitleBox";
            this.etitleBox.Size = new System.Drawing.Size(182, 29);
            this.etitleBox.TabIndex = 7;
            // 
            // ewageBox
            // 
            this.ewageBox.BackColor = System.Drawing.Color.Teal;
            this.ewageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ewageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ewageBox.ForeColor = System.Drawing.Color.White;
            this.ewageBox.Location = new System.Drawing.Point(9, 265);
            this.ewageBox.Name = "ewageBox";
            this.ewageBox.Size = new System.Drawing.Size(115, 29);
            this.ewageBox.TabIndex = 6;
            // 
            // eidBox
            // 
            this.eidBox.BackColor = System.Drawing.Color.Teal;
            this.eidBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eidBox.ForeColor = System.Drawing.Color.White;
            this.eidBox.Location = new System.Drawing.Point(9, 147);
            this.eidBox.Name = "eidBox";
            this.eidBox.Size = new System.Drawing.Size(182, 29);
            this.eidBox.TabIndex = 5;
            // 
            // efirstBox
            // 
            this.efirstBox.BackColor = System.Drawing.Color.Teal;
            this.efirstBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.efirstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efirstBox.ForeColor = System.Drawing.Color.White;
            this.efirstBox.Location = new System.Drawing.Point(10, 29);
            this.efirstBox.Name = "efirstBox";
            this.efirstBox.Size = new System.Drawing.Size(181, 29);
            this.efirstBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Wage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Employee ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(707, 513);
            this.Controls.Add(this.tabControl);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControl.ResumeLayout(false);
            this.merchPage.ResumeLayout(false);
            this.merchPage.PerformLayout();
            this.employeePage.ResumeLayout(false);
            this.employeePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView inventoryView;
        private System.Windows.Forms.ColumnHeader itemCol;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader descrCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage merchPage;
        private System.Windows.Forms.TabPage employeePage;
        private System.Windows.Forms.ListView employeeView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button eremoveBtn;
        private System.Windows.Forms.Button eupdateBtn;
        private System.Windows.Forms.Button ecreateBtn;
        private System.Windows.Forms.TextBox etitleBox;
        private System.Windows.Forms.TextBox ewageBox;
        private System.Windows.Forms.TextBox eidBox;
        private System.Windows.Forms.TextBox efirstBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox elastBox;
        private System.Windows.Forms.Label label9;
    }
}
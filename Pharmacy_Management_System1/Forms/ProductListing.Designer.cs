namespace Pharmacy_Management_System1.Forms
{
    partial class ProductListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListing));
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.qty = new Guna.UI.WinForms.GunaTextBox();
            this.quantity = new Guna.UI.WinForms.GunaTextBox();
            this.Price = new Guna.UI.WinForms.GunaTextBox();
            this.prc = new Guna.UI.WinForms.GunaTextBox();
            this.Pname = new Guna.UI.WinForms.GunaTextBox();
            this.nameLabel = new Guna.UI.WinForms.GunaTextBox();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(1323, 12);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(45, 42);
            this.gunaAdvenceButton1.TabIndex = 73;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.Color.White;
            this.ProductList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.ForeColor = System.Drawing.Color.Black;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 23;
            this.ProductList.Location = new System.Drawing.Point(12, 122);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(180, 464);
            this.ProductList.TabIndex = 75;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.Products_SelectedIndexChanged);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.ForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Location = new System.Drawing.Point(12, 65);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 12;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(180, 36);
            this.gunaTextBox1.TabIndex = 76;
            this.gunaTextBox1.Text = "Product List";
            this.gunaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.Color.Transparent;
            this.qty.BaseColor = System.Drawing.Color.White;
            this.qty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qty.FocusedBaseColor = System.Drawing.Color.White;
            this.qty.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.qty.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qty.Location = new System.Drawing.Point(269, 344);
            this.qty.Name = "qty";
            this.qty.PasswordChar = '\0';
            this.qty.Radius = 12;
            this.qty.SelectedText = "";
            this.qty.Size = new System.Drawing.Size(297, 36);
            this.qty.TabIndex = 82;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.quantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.quantity.FocusedForeColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.White;
            this.quantity.Location = new System.Drawing.Point(269, 305);
            this.quantity.Name = "quantity";
            this.quantity.PasswordChar = '\0';
            this.quantity.Radius = 12;
            this.quantity.ReadOnly = true;
            this.quantity.SelectedText = "";
            this.quantity.Size = new System.Drawing.Size(98, 33);
            this.quantity.TabIndex = 81;
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.Price.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Price.FocusedForeColor = System.Drawing.Color.White;
            this.Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.White;
            this.Price.Location = new System.Drawing.Point(269, 215);
            this.Price.Name = "Price";
            this.Price.PasswordChar = '\0';
            this.Price.Radius = 12;
            this.Price.ReadOnly = true;
            this.Price.SelectedText = "";
            this.Price.Size = new System.Drawing.Size(98, 33);
            this.Price.TabIndex = 80;
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // prc
            // 
            this.prc.BackColor = System.Drawing.Color.Transparent;
            this.prc.BaseColor = System.Drawing.Color.White;
            this.prc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.prc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prc.FocusedBaseColor = System.Drawing.Color.White;
            this.prc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prc.Location = new System.Drawing.Point(269, 254);
            this.prc.Name = "prc";
            this.prc.PasswordChar = '\0';
            this.prc.Radius = 12;
            this.prc.ReadOnly = true;
            this.prc.SelectedText = "";
            this.prc.Size = new System.Drawing.Size(297, 36);
            this.prc.TabIndex = 79;
            this.prc.TextChanged += new System.EventHandler(this.prc_TextChanged);
            // 
            // Pname
            // 
            this.Pname.BackColor = System.Drawing.Color.Transparent;
            this.Pname.BaseColor = System.Drawing.Color.White;
            this.Pname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Pname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pname.FocusedBaseColor = System.Drawing.Color.White;
            this.Pname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Pname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Pname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pname.Location = new System.Drawing.Point(269, 161);
            this.Pname.Name = "Pname";
            this.Pname.PasswordChar = '\0';
            this.Pname.Radius = 12;
            this.Pname.ReadOnly = true;
            this.Pname.SelectedText = "";
            this.Pname.Size = new System.Drawing.Size(297, 36);
            this.Pname.TabIndex = 78;
            this.Pname.TextChanged += new System.EventHandler(this.pname_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.nameLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameLabel.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.nameLabel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.nameLabel.FocusedForeColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(269, 122);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.PasswordChar = '\0';
            this.nameLabel.Radius = 12;
            this.nameLabel.ReadOnly = true;
            this.nameLabel.SelectedText = "";
            this.nameLabel.Size = new System.Drawing.Size(98, 33);
            this.nameLabel.TabIndex = 77;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameLabel.TextChanged += new System.EventHandler(this.nameLabel_TextChanged);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(424, 416);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton2.Radius = 12;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(142, 37);
            this.gunaAdvenceButton2.TabIndex = 83;
            this.gunaAdvenceButton2.Text = "Add to cart";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = null;
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(269, 416);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.gunaAdvenceButton3.Radius = 12;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(147, 37);
            this.gunaAdvenceButton3.TabIndex = 84;
            this.gunaAdvenceButton3.Text = "View Cart";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click_1);
            // 
            // ProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.gunaAdvenceButton3);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.prc);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductListing";
            this.Text = "ProductListing";
            this.Load += new System.EventHandler(this.ProductListing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.ListBox ProductList;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox qty;
        private Guna.UI.WinForms.GunaTextBox quantity;
        private Guna.UI.WinForms.GunaTextBox Price;
        private Guna.UI.WinForms.GunaTextBox prc;
        private Guna.UI.WinForms.GunaTextBox Pname;
        private Guna.UI.WinForms.GunaTextBox nameLabel;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
    }
}
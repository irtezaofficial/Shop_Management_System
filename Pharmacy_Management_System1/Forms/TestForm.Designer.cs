using Pharmacy_Management_System1.Model.User;

namespace Pharmacy_Management_System1
{
    partial class TestForm
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
            this.Register = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(303, 314);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(235, 179);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(211, 20);
            this.Name.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(235, 266);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(211, 20);
            this.password.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(235, 219);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 20);
            this.email.TabIndex = 4;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 717);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Register);
            //this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
    }
}
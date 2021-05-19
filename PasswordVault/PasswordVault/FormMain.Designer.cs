
namespace PasswordVault
{
    partial class FormMain
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
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.pnlAccounts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(22, 23);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(256, 20);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(22, 50);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(171, 23);
            this.btnGeneratePassword.TabIndex = 3;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // pnlAccounts
            // 
            this.pnlAccounts.Location = new System.Drawing.Point(22, 90);
            this.pnlAccounts.Name = "pnlAccounts";
            this.pnlAccounts.Size = new System.Drawing.Size(420, 425);
            this.pnlAccounts.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 543);
            this.Controls.Add(this.pnlAccounts);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Name = "FormMain";
            this.Text = "PasswordVault";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Panel pnlAccounts;
    }
}
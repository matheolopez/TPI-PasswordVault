
namespace PasswordVault
{
    partial class FormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxComment = new System.Windows.Forms.RichTextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(212, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 23);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBoxComment
            // 
            this.txtBoxComment.Location = new System.Drawing.Point(16, 335);
            this.txtBoxComment.Name = "txtBoxComment";
            this.txtBoxComment.ReadOnly = true;
            this.txtBoxComment.Size = new System.Drawing.Size(315, 142);
            this.txtBoxComment.TabIndex = 34;
            this.txtBoxComment.Text = "";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(13, 306);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(62, 13);
            this.lblComments.TabIndex = 33;
            this.lblComments.Text = "Comments :";
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Location = new System.Drawing.Point(13, 255);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(84, 13);
            this.lblPasswordStrength.TabIndex = 32;
            this.lblPasswordStrength.Text = "Weak password";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(263, 230);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(68, 23);
            this.btnShowPassword.TabIndex = 31;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(16, 232);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.ReadOnly = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(241, 20);
            this.txtBoxPassword.TabIndex = 30;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 204);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Password :";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(16, 157);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.ReadOnly = true;
            this.txtBoxLogin.Size = new System.Drawing.Size(241, 20);
            this.txtBoxLogin.TabIndex = 28;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(13, 129);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 27;
            this.lblLogin.Text = "Login :";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(16, 82);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.ReadOnly = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(241, 20);
            this.txtBoxTitle.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title :";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 516);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxComment);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtBoxComment;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
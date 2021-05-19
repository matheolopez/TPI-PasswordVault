
namespace PasswordVault
{
    partial class FormLogin
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(27, 22);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(30, 52);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(157, 20);
            this.txtBoxPassword.TabIndex = 1;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(30, 78);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(157, 23);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 141);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "FormLogin";
            this.Text = "PasswordVault";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnConnection;
    }
}
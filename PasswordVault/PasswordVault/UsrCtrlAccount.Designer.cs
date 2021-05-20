
namespace PasswordVault
{
    partial class UsrCtrlAccount
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCopyUsername = new System.Windows.Forms.Button();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnCopyUsername
            // 
            this.btnCopyUsername.Location = new System.Drawing.Point(188, 17);
            this.btnCopyUsername.Name = "btnCopyUsername";
            this.btnCopyUsername.Size = new System.Drawing.Size(120, 23);
            this.btnCopyUsername.TabIndex = 1;
            this.btnCopyUsername.Text = "Copy username";
            this.btnCopyUsername.UseVisualStyleBackColor = true;
            this.btnCopyUsername.Click += new System.EventHandler(this.btnCopyUsername_Click);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Location = new System.Drawing.Point(188, 46);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(120, 23);
            this.btnCopyPassword.TabIndex = 2;
            this.btnCopyPassword.Text = "Copy password";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(314, 17);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(314, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UsrCtrlAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.btnCopyUsername);
            this.Controls.Add(this.lblTitle);
            this.Name = "UsrCtrlAccount";
            this.Size = new System.Drawing.Size(418, 83);
            this.Load += new System.EventHandler(this.UsrCtrlAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCopyUsername;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}

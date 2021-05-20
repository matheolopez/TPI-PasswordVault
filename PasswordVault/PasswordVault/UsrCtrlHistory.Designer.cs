
namespace PasswordVault
{
    partial class UsrCtrlHistory
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
            this.btnView = new System.Windows.Forms.Button();
            this.lblChangeDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(237, 39);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblChangeDate
            // 
            this.lblChangeDate.AutoSize = true;
            this.lblChangeDate.Location = new System.Drawing.Point(136, 14);
            this.lblChangeDate.Name = "lblChangeDate";
            this.lblChangeDate.Size = new System.Drawing.Size(176, 13);
            this.lblChangeDate.TabIndex = 2;
            this.lblChangeDate.Text = "Change date: DD.MM.YYYY hh.mm";
            // 
            // UsrCtrlHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblChangeDate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblTitle);
            this.Name = "UsrCtrlHistory";
            this.Size = new System.Drawing.Size(318, 68);
            this.Load += new System.EventHandler(this.UsrCtrlHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblChangeDate;
    }
}

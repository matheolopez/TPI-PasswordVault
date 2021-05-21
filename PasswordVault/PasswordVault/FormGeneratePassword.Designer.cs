
namespace PasswordVault
{
    partial class FormGeneratePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneratePassword));
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.trckBarLength = new System.Windows.Forms.TrackBar();
            this.chckBoxNumbers = new System.Windows.Forms.CheckBox();
            this.chckBoxSymbols = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(23, 31);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(202, 20);
            this.txtBoxPassword.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(231, 29);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(29, 71);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length";
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(270, 68);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.ReadOnly = true;
            this.txtBoxLength.Size = new System.Drawing.Size(36, 20);
            this.txtBoxLength.TabIndex = 3;
            // 
            // trckBarLength
            // 
            this.trckBarLength.Location = new System.Drawing.Point(70, 68);
            this.trckBarLength.Maximum = 30;
            this.trckBarLength.Minimum = 8;
            this.trckBarLength.Name = "trckBarLength";
            this.trckBarLength.Size = new System.Drawing.Size(194, 45);
            this.trckBarLength.TabIndex = 4;
            this.trckBarLength.Value = 20;
            this.trckBarLength.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckBarLength_MouseUp);
            // 
            // chckBoxNumbers
            // 
            this.chckBoxNumbers.AutoSize = true;
            this.chckBoxNumbers.Checked = true;
            this.chckBoxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckBoxNumbers.Location = new System.Drawing.Point(32, 112);
            this.chckBoxNumbers.Name = "chckBoxNumbers";
            this.chckBoxNumbers.Size = new System.Drawing.Size(68, 17);
            this.chckBoxNumbers.TabIndex = 5;
            this.chckBoxNumbers.Text = "Numbers";
            this.chckBoxNumbers.UseVisualStyleBackColor = true;
            this.chckBoxNumbers.EnabledChanged += new System.EventHandler(this.chckBoxNumbers_EnabledChanged);
            // 
            // chckBoxSymbols
            // 
            this.chckBoxSymbols.AutoSize = true;
            this.chckBoxSymbols.Checked = true;
            this.chckBoxSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckBoxSymbols.Location = new System.Drawing.Point(166, 112);
            this.chckBoxSymbols.Name = "chckBoxSymbols";
            this.chckBoxSymbols.Size = new System.Drawing.Size(65, 17);
            this.chckBoxSymbols.TabIndex = 6;
            this.chckBoxSymbols.Text = "Symbols";
            this.chckBoxSymbols.UseVisualStyleBackColor = true;
            this.chckBoxSymbols.EnabledChanged += new System.EventHandler(this.chckBoxSymbols_EnabledChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(32, 154);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(124, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FormGeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 189);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chckBoxSymbols);
            this.Controls.Add(this.chckBoxNumbers);
            this.Controls.Add(this.trckBarLength);
            this.Controls.Add(this.txtBoxLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtBoxPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGeneratePassword";
            this.Text = "PasswordVault";
            this.Load += new System.EventHandler(this.FormGeneratePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckBarLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.TrackBar trckBarLength;
        private System.Windows.Forms.CheckBox chckBoxNumbers;
        private System.Windows.Forms.CheckBox chckBoxSymbols;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
    }
}
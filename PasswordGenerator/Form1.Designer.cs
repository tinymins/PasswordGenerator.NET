namespace PasswordGenerator
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
            this.textAccount = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textSalt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textAccount
            // 
            this.textAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAccount.Location = new System.Drawing.Point(12, 12);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(270, 21);
            this.textAccount.TabIndex = 1;
            this.textAccount.TextChanged += new System.EventHandler(this.textAccount_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(12, 65);
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(270, 21);
            this.textPassword.TabIndex = 2;
            // 
            // textSalt
            // 
            this.textSalt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalt.Location = new System.Drawing.Point(12, 39);
            this.textSalt.Name = "textSalt";
            this.textSalt.PasswordChar = '*';
            this.textSalt.Size = new System.Drawing.Size(270, 21);
            this.textSalt.TabIndex = 0;
            this.textSalt.TextChanged += new System.EventHandler(this.textSalt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 100);
            this.Controls.Add(this.textSalt);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textSalt;
    }
}


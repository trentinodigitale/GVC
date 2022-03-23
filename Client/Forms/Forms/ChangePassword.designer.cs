namespace it.dedagroup.GVC.Client.Forms.Forms
{
    partial class ChangePassword
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
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPicture
            // 
            this.LoginPicture.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.Properties.Appearance.Options.UseBackColor = true;
            // 
            // NewPassword
            // 
            // 
            // CurrentPassword
            // 
            this.CurrentPassword.Visible = false;
            // 
            // ConfirmPassword
            // 
            // 
            // LabelCurrentPassword
            // 
            this.LabelCurrentPassword.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(314, 130);
            this.Name = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

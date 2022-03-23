namespace it.dedagroup.GVC.Client.Forms.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Culture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.Images.SetKeyName(0, "FlagGermany.png");
            this.ImageList.Images.SetKeyName(1, "FlagItaly.png");
            this.ImageList.Images.SetKeyName(2, "FlagUsa.png");
            // 
            // LoginPicture
            // 
            this.LoginPicture.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.Properties.Appearance.Options.UseBackColor = true;
            // 
            // Password
            // 
            // 
            // Username
            // 
            // 
            // Culture
            // 
            this.Culture.Visible = false;
            // 
            // LabelCulture
            // 
            this.LabelCulture.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(314, 130);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Culture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

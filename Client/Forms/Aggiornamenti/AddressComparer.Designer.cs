namespace it.dedagroup.GVC.Client.Forms.Aggiornamenti
{
    partial class AddressComparer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressInfo1 = new it.dedagroup.GVC.Client.Forms.Aggiornamenti.AddressInfo();
            this.addressInfo2 = new it.dedagroup.GVC.Client.Forms.Aggiornamenti.AddressInfo();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(631, 291);
            this.splitContainerControl1.SplitterPosition = 143;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(549, 295);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.addressInfo1);
            this.groupControl1.Size = new System.Drawing.Size(627, 139);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.addressInfo2);
            this.groupControl2.Size = new System.Drawing.Size(627, 138);
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Size = new System.Drawing.Size(631, 323);
            // 
            // addressInfo1
            // 
            this.addressInfo1.ApplicationTitle = "";
            this.addressInfo1.ConfirmCancel = true;
            this.addressInfo1.ConfirmCancelMessage = "";
            this.addressInfo1.CurrentSequenceID = null;
            this.addressInfo1.CurrentTaskID = null;
            this.addressInfo1.IsShowing = false;
            this.addressInfo1.Location = new System.Drawing.Point(1, 21);
            this.addressInfo1.Name = "addressInfo1";
            this.addressInfo1.PageCaption = "";
            this.addressInfo1.ReadOnlyControls = true;
            this.addressInfo1.Size = new System.Drawing.Size(621, 115);
            this.addressInfo1.TabIndex = 0;
            // 
            // addressInfo2
            // 
            this.addressInfo2.ApplicationTitle = "";
            this.addressInfo2.ConfirmCancel = true;
            this.addressInfo2.ConfirmCancelMessage = "";
            this.addressInfo2.CurrentSequenceID = null;
            this.addressInfo2.CurrentTaskID = null;
            this.addressInfo2.IsShowing = false;
            this.addressInfo2.Location = new System.Drawing.Point(1, 21);
            this.addressInfo2.Name = "addressInfo2";
            this.addressInfo2.PageCaption = "";
            this.addressInfo2.ReadOnlyControls = true;
            this.addressInfo2.Size = new System.Drawing.Size(621, 112);
            this.addressInfo2.TabIndex = 0;
            // 
            // AddressComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AddressComparer";
            this.Size = new System.Drawing.Size(631, 347);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AddressInfo addressInfo1;
        private AddressInfo addressInfo2;

    }
}

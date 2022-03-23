namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data
{
    partial class Data
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
            this.addressDetail1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo.IndirizzoDetail();
            this.dataFromRI1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.DataFromRI();
            this.dataGenerics1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.DataGenerics();
            this.activities1 = new it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Activities();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.ScrollableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.MaxItemId = 10;
            // 
            // ScrollableContent
            // 
            this.ScrollableContent.Controls.Add(this.activities1);
            this.ScrollableContent.Controls.Add(this.dataGenerics1);
            this.ScrollableContent.Controls.Add(this.dataFromRI1);
            this.ScrollableContent.Controls.Add(this.addressDetail1);
            this.ScrollableContent.Location = new System.Drawing.Point(0, 24);
            this.ScrollableContent.Size = new System.Drawing.Size(787, 592);
            // 
            // BarGridControl
            // 
            this.BarGridControl.OptionsBar.AllowQuickCustomization = false;
            this.BarGridControl.OptionsBar.DisableClose = true;
            this.BarGridControl.OptionsBar.UseWholeRow = true;
            // 
            // addressDetail1
            // 
            this.addressDetail1.ApplicationTitle = "";
            this.addressDetail1.ConfirmCancel = true;
            this.addressDetail1.ConfirmCancelMessage = "";
            this.addressDetail1.CurrentSequenceID = null;
            this.addressDetail1.CurrentTaskID = null;
            this.addressDetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressDetail1.IsShowing = false;
            this.addressDetail1.Location = new System.Drawing.Point(0, 0);
            this.addressDetail1.Name = "addressDetail1";
            this.addressDetail1.PageCaption = "";
            this.addressDetail1.ReadOnlyControls = true;
            this.addressDetail1.Size = new System.Drawing.Size(770, 146);
            this.addressDetail1.TabIndex = 0;
            // 
            // dataFromRI1
            // 
            this.dataFromRI1.ApplicationTitle = "";
            this.dataFromRI1.ConfirmCancel = true;
            this.dataFromRI1.ConfirmCancelMessage = "";
            this.dataFromRI1.CurrentSequenceID = null;
            this.dataFromRI1.CurrentTaskID = null;
            this.dataFromRI1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataFromRI1.IsShowing = false;
            this.dataFromRI1.Location = new System.Drawing.Point(0, 146);
            this.dataFromRI1.Name = "dataFromRI1";
            this.dataFromRI1.PageCaption = "";
            this.dataFromRI1.ReadOnlyControls = true;
            this.dataFromRI1.Size = new System.Drawing.Size(770, 230);
            this.dataFromRI1.TabIndex = 1;
            // 
            // dataGenerics1
            // 
            this.dataGenerics1.ApplicationTitle = "";
            this.dataGenerics1.ConfirmCancel = true;
            this.dataGenerics1.ConfirmCancelMessage = "";
            this.dataGenerics1.CurrentSequenceID = null;
            this.dataGenerics1.CurrentTaskID = null;
            this.dataGenerics1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGenerics1.IsShowing = false;
            this.dataGenerics1.Location = new System.Drawing.Point(0, 376);
            this.dataGenerics1.Name = "dataGenerics1";
            this.dataGenerics1.PageCaption = "";
            this.dataGenerics1.ReadOnlyControls = true;
            this.dataGenerics1.Size = new System.Drawing.Size(770, 139);
            this.dataGenerics1.TabIndex = 2;
            // 
            // activities1
            // 
            this.activities1.ApplicationTitle = "";
            this.activities1.ConfirmCancel = true;
            this.activities1.ConfirmCancelMessage = "";
            this.activities1.CurrentSequenceID = null;
            this.activities1.CurrentTaskID = null;
            this.activities1.Dock = System.Windows.Forms.DockStyle.Top;
            this.activities1.IsShowing = false;
            this.activities1.Location = new System.Drawing.Point(0, 515);
            this.activities1.Name = "activities1";
            this.activities1.PageCaption = "";
            this.activities1.ReadOnlyControls = true;
            this.activities1.Size = new System.Drawing.Size(770, 315);
            this.activities1.TabIndex = 3;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Data";
            this.Size = new System.Drawing.Size(787, 616);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ScrollableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Data.Indirizzo.IndirizzoDetail addressDetail1;
        private Activities activities1;
        private DataGenerics dataGenerics1;
        private DataFromRI dataFromRI1;
    }
}

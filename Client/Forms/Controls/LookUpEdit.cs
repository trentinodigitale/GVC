using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Client.Forms.Controls
{
    public class LookUpEdit : DevExpress.XtraEditors.LookUpEdit
    {
        private new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit fProperties;
    
        public LookUpEdit()
            : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fProperties.Name = "fProperties";
            this.fProperties.NullText = "";
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

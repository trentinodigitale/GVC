using System;
using System.Collections.Generic;
using System.Text;

namespace OeF.Forms.Controls
{
    public partial class CollapseContainer
    {

		#region Fields (2) 

        private System.ComponentModel.Container components;
        private System.Windows.Forms.ImageList imgButtons;

		#endregion Fields 

		#region Methods (1) 


		// Private Methods (1) 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollapseContainer));
            this.imgButtons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();

            this.imgButtons.ImageStream = resources.GetObject("imgButtons.ImageStream") as System.Windows.Forms.ImageListStreamer;
            this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgButtons.Images.SetKeyName(0, "UpArrow.gif");
            this.imgButtons.Images.SetKeyName(1, "DownArrow.gif");
            this.Size = new System.Drawing.Size(179, 189);
            this.ResumeLayout(false);

        }


		#endregion Methods 

    }
}


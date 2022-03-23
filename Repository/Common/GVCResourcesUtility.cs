using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace it.dedagroup.GVC.Repository.Common
{
    public sealed class GVCResourcesUtility
    {
        /// <summary>
        /// Get_16x16s the specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        public static Image Get_16x16(Image image)
        {
            return image.GetThumbnailImage(16, 16, null, System.IntPtr.Zero);
        }
    }
}

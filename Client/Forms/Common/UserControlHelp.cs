using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace it.dedagroup.GVC.Client.Forms.Common
{
    public class UserControlHelp
    {
        public static event EventHandler UpdateDocumentazione;
        public static void UpdateDocumentazioneCall(object item)
        {
            EventHandler eTemp = UserControlHelp.UpdateDocumentazione;
            if (eTemp != null)
            {
                eTemp(item, new EventArgs());
            }
        }

		#region Methods (3) 


		// Public Methods (3) 

        public static void EndEditsBindingSources(System.Windows.Forms.Control.ControlCollection controls)
        {
            if (controls != null &&
                controls.Count > 0)
            {
                foreach (Control control in controls)
                {
                    if (control.GetType().IsSubclassOf(typeof(UserControl)))
                    {
                        PeformActionOnBindingSources(control);
                    }
                    if (control.HasChildren)
                    {
                        EndEditsBindingSources(control.Controls);
                    }
                }
            }
        }

        public static void PeformActionOnBindingSources(object userControl)
        {
            System.Reflection.FieldInfo[] fields = userControl.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (fields != null &&
                fields.Length > 0)
            {
                foreach (System.Reflection.FieldInfo field in fields)
                {
                    if (field.FieldType.IsSubclassOf(typeof(BindingSource)))
                    {
                        BindingSource bindingSource = field.GetValue(userControl) as BindingSource;
                        if (bindingSource != null)
                            bindingSource.EndEdit();
                    }
                }
            }
        }

        /// Sets the enabled and read only.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="isReadOnly">if set to <c>true</c> [is read only].</param>
        public static void SetEnabledAndReadOnly(Control control, Boolean isReadOnly)
        {
            if (control != null)
            {
                if (control.Controls != null && control.Controls.Count > 0)
                {
                    foreach (Control item in control.Controls)
                    {
                        if (item is DevExpress.XtraEditors.SimpleButton)
                        {
                            DevExpress.XtraEditors.SimpleButton bTemp = 
                                    item as DevExpress.XtraEditors.SimpleButton;
                            if (bTemp != null)
                                bTemp.Enabled = !isReadOnly;
                        }
                        else if (item is it.dedagroup.GVC.Client.Forms.Controls.LabelControl)
                        {
                            it.dedagroup.GVC.Client.Forms.Controls.LabelControl lTemp =
                                        item as it.dedagroup.GVC.Client.Forms.Controls.LabelControl;
                            if (lTemp != null && lTemp.Cursor == System.Windows.Forms.Cursors.Hand)
                                lTemp.Enabled = !isReadOnly;
                        }
                        else if (item is OeF.Forms.Controls.CheckEdit ||
                                item is DevExpress.XtraEditors.CheckEdit)
                        {
                            DevExpress.XtraEditors.CheckEdit cTemp =
                                        item as DevExpress.XtraEditors.CheckEdit;
                            if (cTemp != null)
                                cTemp.Properties.ReadOnly = isReadOnly;
                        }
                        else if (item is it.dedagroup.GVC.Client.Forms.Common.IUserCommon)
                        {
                            it.dedagroup.GVC.Client.Forms.Common.IUserCommon
                                uTemp = item as it.dedagroup.GVC.Client.Forms.Common.IUserCommon;

                            if (uTemp != null)
                            {
                                DevExpress.XtraBars.BarManager bTemp = uTemp.GetBarManager();
                                if (bTemp != null)
                                {
                                    foreach (DevExpress.XtraBars.Bar barTemp in bTemp.Bars)
                                    {
                                        foreach (DevExpress.XtraBars.BarItem barItem in bTemp.Items)
                                        {
                                            if (barItem is DevExpress.XtraBars.BarButtonItem)
                                            {
                                                DevExpress.XtraBars.BarButtonItem bbT =
                                                    barItem as DevExpress.XtraBars.BarButtonItem;
                                                if (bbT != null)
                                                {
                                                    bbT.Enabled = !isReadOnly;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            SetEnabledAndReadOnly(item, isReadOnly);
                        }
                    }
                }
            }
        }

        public static Boolean IsTheSubjectAlreadyOpen(UserControlBase contr, int idSoggetto)
        {
            Boolean toReturn = false;

            if (contr.ParentForm != null && contr.ParentForm.MdiParent != null && contr.ParentForm.MdiParent.MdiChildren != null)
            {
                foreach (Control c in contr.ParentForm.MdiParent.MdiChildren)
                {
                    if (c is it.dedagroup.GVC.Client.Forms.Common.BaseForm)
                    {
                        if (c.Controls != null && c.Controls.Count > 0)
                        {
                            if (c.Controls[0] is Cooperative.CooperativeEdit1)
                            {
                                Cooperative.CooperativeEdit1 pTmp = c.Controls[0] as Cooperative.CooperativeEdit1;
                                if (pTmp != null && pTmp.IdSoggetto == idSoggetto)
                                {
                                    toReturn = true;
                                    break;
                                }
                            }
                        }

                    }
                }
            }
            else
            {
                toReturn = true;
            }
            return toReturn;
        }

        public static Boolean IsTheUserControlAlreadyOpen(MDIForm.Main contr, Type pageType, Boolean toFocus)
        {
            Boolean toReturn = false;

            //if (contr.ParentForm != null && contr.ParentForm.MdiParent != null && contr.ParentForm.MdiParent.MdiChildren != null)
            if (contr != null)
            {
                int index = 0;
                foreach (Control c in contr.MdiChildren)
                {
                    if (c is it.dedagroup.GVC.Client.Forms.Common.BaseForm)
                    {
                        if (c.Controls != null && c.Controls.Count > 0)
                        {
                            if (c.Controls[0].GetType() == pageType)
                            {
                                toReturn = true;

                                if (toFocus)
                                {
                                    if (index < contr.MdiChildren.Length)
                                        contr.MdiChildren[index].Activate();
                                }
                            }
                        }

                    }
                    index++;
                }
            }
            else
            {
                toReturn = true;
            }
            return toReturn;
        }

		#endregion Methods 

    }
}

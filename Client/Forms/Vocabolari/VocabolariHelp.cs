using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Client.Forms.Engine;
using it.dedagroup.GVC.Repository.Common.Services;
using System.Windows.Forms;
using it.dedagroup.GVC.Client.Forms.Common;

namespace it.dedagroup.GVC.Client.Forms.Vocabolari
{
    public static class VocabolariHelp
    {
        public static int CurrentIndexUndefined = -999;

        public static DizionarioFDT Save(DizionarioFDT item)
        {
            DizionarioFDT toReturn = GVCSystemEngine.Instance.InvokeService<ICooperatives, DizionarioFDT>
                        (delegate()
                        {
                            return GVCSystemEngine.Instance.Cooperatives.SaveDictionary(item);
                        },
                        true);

            return toReturn;
        }

        public static void Delete(DizionarioFDT item,
                                DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario, 
                                List<DizionarioFDT> listDictionaries,
                                OeF.Forms.BindingSourceBase bindingSourceDizionario)
        {
            if (item != null)
            {
                if (ShowConfirmMessage("Conferma operazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    string[] outcomes =
                            GVCSystemEngine.Instance.InvokeService<ICooperatives, string[]>
                            (delegate()
                            {
                                return GVCSystemEngine.Instance.Cooperatives.DeleteDictionary(item);
                            },
                            true);

                    if (outcomes != null)
                    {
                        if (outcomes.Length == 0)
                        {
                            ShowInformationMessage("Cancellazione avvenuta con successo", string.Empty);

                            gridViewDizionario.BeginDataUpdate();

                            listDictionaries.Remove(item);
                            bindingSourceDizionario.DataSource = listDictionaries.ToArray();

                            //listDictionaries.Clear();
                            //GetListTechnologies();

                            gridViewDizionario.EndDataUpdate();
                            gridViewDizionario.PostEditor();
                        }
                        else
                        {
                            ShowInformationMessage("La cancellazione è stata annullata perchè l'elemento è in uso nelle tabelle referenziate", string.Empty);
                        }
                    }
                    else
                    {
                        ShowInformationMessage("Si sono verificati dei problemi durante la cancellazione dell'elemento", string.Empty);
                    }
                }
            }
        }

        public static void ManageItem(DizionarioFDT item,
                                        int currentIndex,
                                        string formTitle,   
                                        string titoloDettaglio,
                                        Boolean showCodice,
                                        Boolean showAltroFlag,
                                        string titoloAltroFlag,
                                        DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario,
                                        OeF.Forms.BindingSourceBase bindingSourceDizionario,
                                        List<DizionarioFDT> listDictionaries,
                                        IDizionarioEdit page)
        {
            if (item != null && 
                gridViewDizionario != null && 
                bindingSourceDizionario != null && 
                listDictionaries != null && 
                page != null)
            {
                item.EndEdit();

                if (!item.Flag)
                {
                    ShowInformationMessage("Elemento non modificabile (vocabolario chiuso)", string.Empty);
                    return;
                }

                item.BeginEdit();
                if (OpenForEdit(item,formTitle, titoloDettaglio, showCodice, showAltroFlag, titoloAltroFlag, (UserControlDialog)page) == DialogResult.OK)
                {
                    item.EndEdit();
                    UpdateData(item, true,
                                        currentIndex, gridViewDizionario, listDictionaries, bindingSourceDizionario);
                }
                else
                {
                    item.CancelEdit();
                    gridViewDizionario.RefreshData();
                }
            }
        }

        private static DialogResult OpenForEdit(object item,
                                        string formTitle,
                                        string titoloDettaglio, 
                                        Boolean showCodice, 
                                        Boolean showAltroFlag, 
                                        string titoloAltroFlag,
                                        it.dedagroup.GVC.Client.Forms.Common.UserControlDialog page)
        {
            if (page != null)
            {
                DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider er = null;
                page.SetFormTitle(formTitle);
                if (page is IDizionarioEdit)
                {
                    if (page is DizionarioEditWithDetail)
                    {
                        ((DizionarioEditWithDetail)page).SetBindableData(item as DizionarioFDT, titoloDettaglio, showCodice, showAltroFlag, titoloAltroFlag);
                        er = ((DizionarioEditWithDetail)page).ErrorProviderDizionario;
                    }
                    else
                    {
                        ((DizionarioEdit)page).SetBindableData(item as DizionarioFDT, titoloDettaglio, showCodice, showAltroFlag, titoloAltroFlag);
                        er = ((DizionarioEdit)page).ErrorProviderDizionario;
                    }
                }
                else
                {
                    if (page is NumeroSociEdit)
                    {
                        ((NumeroSociEdit)page).SetBindableData(item as ControlloNumeroSociFDT, formTitle, titoloDettaglio);
                        er = ((NumeroSociEdit)page).ErrorProviderDizionario;
                    }
                    else if (page is CadenzaRevisioneEdit)
                    {
                        ((CadenzaRevisioneEdit)page).SetBindableData(item as DizionarioFDT, formTitle, titoloDettaglio);
                        er = ((CadenzaRevisioneEdit)page).ErrorProviderDizionario;
                    }
                }
                
                DialogResult dr = DialogResult.OK;
                while (dr == DialogResult.OK)
                {
                    er.ClearErrors();

                    dr = page.BaseForm.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        if (!er.HasErrors)
                            break;
                    }
                }
                return dr;
            }
            else
                return DialogResult.None;
        }

        private static void UpdateData(DizionarioFDT item, 
                                Boolean toReplace,
                                int currentIndex,
                                DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario,
                                List<DizionarioFDT> listDictionaries,
                                OeF.Forms.BindingSourceBase bindingSourceBaseDizionario)
        {
            DizionarioFDT itemSaved = Save(item);

            if (itemSaved != null && itemSaved.IdElemento >= 0)
            {
                gridViewDizionario.BeginDataUpdate();

                int index = -1;
                if (currentIndex != CurrentIndexUndefined)
                {
                    index = currentIndex;
                }
                if (index >= 0)
                {
                    listDictionaries.RemoveAt(index);
                    listDictionaries.Insert(index, itemSaved);
                }
                else
                {
                    listDictionaries.Add(itemSaved);

                }
                bindingSourceBaseDizionario.DataSource = listDictionaries.ToArray();
                gridViewDizionario.EndDataUpdate();
                gridViewDizionario.RefreshData();
                gridViewDizionario.PostEditor();

                
                ShowInformationMessage("Salvataggio andato a buon fine", string.Empty);
            }
            else
            {
                item.CancelEdit();
                ShowProblemsMessage();
            }
        }

        #region Show messages

        private static DialogResult ShowConfirmMessage(string caption, string message, string data)
        {
            return OeF.Forms.OeFMessageBox.Show(
                                null,
                                message,
                                caption,
                                data,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question/*,
                            MessageBoxDefaultButton.Button2*/
                                                                 );
        }

        private static DialogResult ShowInformationMessage(string message, string data)
        {
            return OeF.Forms.OeFMessageBox.Show(
                                null,
                                message,
                                "GVC Client",
                                data,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information/*,
                            MessageBoxDefaultButton.Button2*/
                                                                 );
        }

        private static void ShowProblemsMessage()
        {
            OeF.Forms.OeFMessageBox.Show("Si è verificato un problema durante l'operazione richiesta.",
                                                 "Attenzione!",
                                                  MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);
        }

        #endregion Show messages

        #region Numero Soci

        public static void ManageNumeroSoci(ControlloNumeroSociFDT item,
                                       int currentIndex,
                                       string formTitle,
                                       string titoloParent,
                                       //Boolean showCodice,
                                       //Boolean showAltroFlag,
                                       //string titoloAltroFlag,
                                       DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario,
                                       OeF.Forms.BindingSourceBase bindingSourceDizionario,
                                       List<ControlloNumeroSociFDT> listDictionaries,
                                       NumeroSociEdit page)
        {
            if (item != null &&
                gridViewDizionario != null &&
                bindingSourceDizionario != null &&
                listDictionaries != null &&
                page != null)
            {
                item.EndEdit();
                item.BeginEdit();
                if (OpenForEdit(item, formTitle, titoloParent, false, false, string.Empty, page) == DialogResult.OK)
                {
                    item.EndEdit();
                    UpdateDataNumeroSoci(item,
                                true,
                                currentIndex,
                                gridViewDizionario,
                                listDictionaries,
                                bindingSourceDizionario);
                }
                else
                {
                    item.CancelEdit();
                    gridViewDizionario.RefreshData();
                }
            }
        }

        private static ControlloNumeroSociFDT SaveControlloNumeroSoci(ControlloNumeroSociFDT item)
        {
            ControlloNumeroSociFDT toReturn = GVCSystemEngine.Instance.InvokeService<ICooperatives, ControlloNumeroSociFDT>
                        (delegate()
                        {
                            return GVCSystemEngine.Instance.Cooperatives.SaveNumeroSoci(item);
                        },
                        true);

            return toReturn;
        }

        private static void UpdateDataNumeroSoci(ControlloNumeroSociFDT item,
                               Boolean toReplace,
                               int currentIndex,
                               DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario,
                               List<ControlloNumeroSociFDT> listDictionaries,
                               OeF.Forms.BindingSourceBase bindingSourceBaseDizionario)
        {
            ControlloNumeroSociFDT itemSaved = SaveControlloNumeroSoci(item);

            if (itemSaved != null && itemSaved.IdRelazione >= 0)
            {
                gridViewDizionario.BeginDataUpdate();

                int index = -1;
                if (currentIndex != CurrentIndexUndefined)
                {
                    index = currentIndex;
                }
                if (index >= 0)
                {
                    listDictionaries.RemoveAt(index);
                    listDictionaries.Insert(index, itemSaved);
                }
                else
                {
                    listDictionaries.Add(itemSaved);

                }
                bindingSourceBaseDizionario.DataSource = listDictionaries.ToArray();
                gridViewDizionario.EndDataUpdate();
                gridViewDizionario.RefreshData();
                gridViewDizionario.PostEditor();


                ShowInformationMessage("Salvataggio andato a buon fine", string.Empty);

                item.IdRelazione = itemSaved.IdRelazione;
            }
            else
            {
                item.CancelEdit();
                ShowProblemsMessage();
            }
        }

        public static Boolean DeleteDetail(ControlloNumeroSociFDT item,
                              DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario,
                              List<ControlloNumeroSociFDT> listDictionaries,
                              OeF.Forms.BindingSourceBase bindingSourceDizionario)
        {
            Boolean toReturn = false;

            if (item != null)
            {
                if (ShowConfirmMessage("Conferma operazione", "Confermi la cancellazione dell'elemento selezionato?", string.Empty) == DialogResult.Yes)
                {
                    toReturn =
                            GVCSystemEngine.Instance.InvokeService<ICooperatives, Boolean>
                            (delegate()
                            {
                                return GVCSystemEngine.Instance.Cooperatives.DeleteNumeroSoci(item);
                            },
                            true);

                    if (toReturn)
                    {
                        ShowInformationMessage("Cancellazione avvenuta con successo", string.Empty);

                        gridViewDizionario.BeginDataUpdate();

                        listDictionaries.Remove(item);
                        bindingSourceDizionario.DataSource = listDictionaries.ToArray();

                        //listDictionaries.Clear();
                        //GetListTechnologies();

                        gridViewDizionario.EndDataUpdate();
                        gridViewDizionario.PostEditor();
                    }
                    else
                    {
                        ShowInformationMessage("Non  stato possibile procedere con la cancellazione", string.Empty);
                    }
                }
            }
            return toReturn;
        }

        #endregion Numero Soci

        #region Cadenza revisione

        public static void ManageCadenzaRev(DizionarioFDT item,
                                      int currentIndex,
                                      string formTitle,
                                      string titoloParent,
                                      DevExpress.XtraGrid.Views.Grid.GridView gridViewDizionario,
                                      OeF.Forms.BindingSourceBase bindingSourceDizionario,
                                      List<DizionarioFDT> listDictionaries,
                                      CadenzaRevisioneEdit page)
        {
            if (item != null &&
                gridViewDizionario != null &&
                bindingSourceDizionario != null &&
                listDictionaries != null &&
                page != null)
            {
                item.EndEdit();
                item.BeginEdit();
                if (OpenForEdit(item, formTitle, titoloParent, false, false, string.Empty, page) == DialogResult.OK)
                {
                    item.EndEdit();
                    UpdateData(item,
                                true,
                                currentIndex,
                                gridViewDizionario,
                                listDictionaries,
                                bindingSourceDizionario);
                }
                else
                {
                    item.CancelEdit();
                    gridViewDizionario.RefreshData();
                }
            }
        }

        #endregion Cadenza revisione
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaGiuridicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.PersonaFisicaFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.SoggettoFDT))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(it.dedagroup.GVC.Repository.Common.FDT.FDTBase))]
    [Serializable]
    public class CooperativaFDT : PersonaGiuridicaFDT, DevExpress.XtraEditors.DXErrorProvider.IDXDataErrorInfo
    {
        //public static event EventHandler<EventArgsCooperativa> LoadLiquidazioniRequest;


        #region Instance Variables (3)

        //private int _idCooperativa;
        //private String _denominazione;
        private RegistroCooperativaFDT _registroCooperativa;
        
        private List<SegnalazioneFDT> _segnalazioniToApply;
        private List<SegnalazioneFDT> _segnalazioniApplied;
        private AggiornamentoFDT _aggiornamento;
        

        #endregion Instance Variables (3)


        #region Public Properties (3)

        /// <summary>
        /// Gets or sets the tipo iscrizione header.
        /// </summary>
        /// <value>The tipo iscrizione header.</value>
        [Bindable(true)]
        public int TipoIscrizioneHeader
        {
            get
            {
                int type = Configurations.TipoIscrizioneHeader.NonIscritta;

                if (_registroCooperativa != null)
                {

                    CancellazioneFDT cC = _registroCooperativa.Cancellazione;
                    if (cC != null && cC.ContainsData)
                    {
                        type = Configurations.TipoIscrizioneHeader.Cancellata;
                    }

                    //if (_registroCooperativa.Cancellazione != null && 
                    //    _registroCooperativa.Cancellazione.Status < it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                    //{
                    //    if (_registroCooperativa.Cancellazione.DataRicevimentoDomanda > DateTime.MinValue)
                    //    {
                    //        type = Configurations.TipoIscrizioneHeader.Cancellata;
                    //    }
                    //}
                    if (type == Configurations.TipoIscrizioneHeader.NonIscritta)
                    {
                        CambioPosizioneFDT cP = _registroCooperativa.Iscrizione;
                        if (cP != null && cP.ContainsData)
                        {
                            type = Configurations.TipoIscrizioneHeader.Iscritta;
                        }

                        //if (_registroCooperativa.CambioPosizioni != null)
                        //{
                        //    if (_registroCooperativa.CambioPosizioni.Length > 0)
                        //    {
                        //        foreach (CambioPosizioneFDT cP in _registroCooperativa.CambioPosizioni)
                        //        {
                        //            if (cP.Status < it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                        //            {
                        //                if (cP.DataRicevimentoDomanda > DateTime.MinValue)
                        //                {
                        //                    type = Configurations.TipoIscrizioneHeader.Iscritta;
                        //                    break;
                        //                }
                        //            }
                        //        }
                                
                        //    }
                        //}
                    }
                }

                return type;
            }
        }

        /// <summary>
        /// Gets the adesione header.
        /// </summary>
        /// <value>The adesione header.</value>
        [Bindable(true)]
        public string AdesioneHeader
        {
            get
            {
                string s = "NON ADERENTE";

                if (_registroCooperativa != null && _registroCooperativa.Adesioni != null
                    && _registroCooperativa.Adesioni.Length > 0)
                {
                    foreach (AdesioneFDT item in _registroCooperativa.Adesioni)
                    {
                        if (item.Status < it.dedagroup.GVC.Repository.Common.Configurations.ObjectStatus.ToHide)
                        {
                            if (item.DataFine.HasValue)
                            {
                                if (item.DataFine.Value > DateTime.Now)
                                {
                                    if (item.Associazione != null)
                                    {
                                        s = item.Associazione.Denominazione;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (item.Associazione != null)
                                {
                                    s = item.Associazione.Denominazione;
                                    break;
                                }
                            }
                        }
                    }
                }

                return s;
            }
        }


        public List<SegnalazioneFDT> Segnalazioni
        {
            get { return _segnalazioniToApply; }
            set { _segnalazioniToApply = value; }
        }


        ///// <summary>
        ///// Gets or sets the denominazione.
        ///// </summary>
        ///// <value>The denominazione.</value>
        //[Bindable(true)]
        //public String Denominazione
        //{
        //    get { return _denominazione; }
        //    set { _denominazione = value; }
        //}

        ///// <summary>
        ///// Gets or sets the id cooperativa.
        ///// </summary>
        ///// <value>The id cooperativa.</value>
        //[Bindable(true)]
        //public int IdCooperativa
        //{
        //    get { return _idCooperativa; }
        //    set { _idCooperativa = value; }
        //}

        /// <summary>
        /// Gets or sets the registro cooperativa.
        /// </summary>
        /// <value>The registro cooperativa.</value>
        [Bindable(true)]
        public RegistroCooperativaFDT RegistroCooperativa
        {
            get { return _registroCooperativa; }
            set { _registroCooperativa = value; }
        }

        public AggiornamentoFDT Aggiornamento
        {
            get { return _aggiornamento; }
            set { _aggiornamento = value; }
        }

        public List<SegnalazioneFDT> SegnalazioniApplied
        {
            get { return _segnalazioniApplied; }
            set { _segnalazioniApplied = value; }
        }

        #endregion Public Properties


        #region Methods

        public void RemoveAppliedSeg()
        {
            if (_segnalazioniApplied != null) 
            {
                SegnalazioneFDT eachSegType;
                for (int i = 0; i < _segnalazioniApplied.Count; i++)
                {
                    eachSegType = _segnalazioniApplied[i];
                    for (int j = 0; j < _segnalazioniToApply.Count; j++) 
                    {
                        if (_segnalazioniToApply[j].IdTipoSegnalazione == eachSegType.IdTipoSegnalazione)
                            _segnalazioniToApply.RemoveAt(j);
                    }
                }
            
            }
        }

        #endregion Methods


        #region IDXDataErrorInfo Members

        public override void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
           
        }

        public override void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
        {
            base.GetPropertyError(propertyName, info);
            //((PersonaGiuridicaFDT)this).GetPropertyError(propertyName, info);
            //base.GetPropertyError(propertyName, info);

            //if (propertyName.Contains("Denominazione") && String.IsNullOrEmpty(Denominazione))
            //{
            //    info.ErrorText = "";
            //    info.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            //}
        }

        #endregion
    }
}

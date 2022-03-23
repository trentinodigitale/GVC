using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace it.dedagroup.GVC.Repository.Common.FDT.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class CartellaFDT : DizionarioFDT
    {
        #region Instance Variables (2)

        private String _path;
        private int _idMaschera;
        private Byte[] _icona;
        private List<DocumentazioneFileSystemFDT> _documenti;

        #endregion Instance Variables

        #region Public Properties (2)

        ///// <summary>
        ///// Gets or sets the Descrizione.
        ///// </summary>
        ///// <value>The Descrizione.</value>
        //[Bindable(true)]
        //public String Descrizione
        //{
        //    get { return _descrizione; }
        //    set { _descrizione = value; }
        //}

        /// <summary>
        /// Gets or sets the Path.
        /// </summary>
        /// <value>The Path.</value>
        [Bindable(true)]
        public String Path
        {
            get { return _path; }
            set { _path = value; }
        }


        /// <summary>
        /// Gets or sets the IdMaschera.
        /// </summary>
        /// <value>The IdMaschera.</value>
        [Bindable(true)]
        public int IdMaschera
        {
            get { return _idMaschera; }
            set { _idMaschera = value; }
        }

        [Bindable(true)]
        public List<DocumentazioneFileSystemFDT> Documenti
        {
            get { return _documenti; }
            set { _documenti = value; }
        }

        [Bindable(true)]
        public Byte[] Icona
        {
            get { return _icona; }
            set { _icona = value; }
        }

        #endregion Public Properties

        #region Private Methods (1)

        private byte[] GetIcon()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            GVCResources.Folder_16x16.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
           
            return ms.ToArray();
        }

        #endregion Private Methods 

        public override void OnCreateInstance()
        {
            base.OnCreateInstance();

            _icona = GetIcon();
        }
    }
}

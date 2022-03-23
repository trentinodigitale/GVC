using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Client.Forms.Cooperative.UserControlCoop.Statuto
{
    public partial class ModificheStatuto : it.dedagroup.GVC.Client.Forms.Common.UserControlBase
    {
        public event EventHandler ModificaStatutaria;
        public event EventHandler NuovoProcedimento;

        public ModificheStatuto()
        {
            InitializeComponent();

            EnableControlAutoSize(new object[] { this }, meetingDetail1, 475);

            meetingDetail1.ModificaStatutaria += new EventHandler(meetingDetail1_ModificaStatutaria);
            meetingDetail1.NuovoProcedimento += new EventHandler(meetingDetail1_NuovoProcedimento);

        }

        public void SetBindableData(CooperativaFDT item)
        {
            constitutiveAct1.SetBindableData(item);

            #region Modifiche Statutarie

            if (meetingDetail1 != null)
            {
                meetingDetail1.SetBindableData(item);
            }

            #endregion Modifiche Statutarie
        }

        private void meetingDetail1_ModificaStatutaria(object sender, EventArgs e)
        {
            EventHandler temp = ModificaStatutaria;
            if (temp != null)
                ModificaStatutaria(null, new EventArgs());
        }

        private void meetingDetail1_NuovoProcedimento(object sender, EventArgs e)
        {
            EventHandler temp = NuovoProcedimento;
            if (temp != null)
                NuovoProcedimento(null, new EventArgs());
        }

        //private void EventSubscription()
        //{
        //    meetingDetail1.AggiornaModifiche += new EventHandler(meetingDetail1_AggiornaModifiche);
        //}

        //void meetingDetail1_AggiornaModifiche(object sender, EventArgs e)
        //{
        //    UpdateModificheStatutarie();
        //}

        //private void UpdateModificheStatutarie()
        //{
        //    this.m
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.rtier.Service;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public sealed class SearchParameters
    {

		#region Fields (11) 

        #region Registro cooperativa

        public static string ASSOCIAZIONE = "ASSOCIAZIONE";
        public static string CODICE_COOPERATIVA = "CODICE_COOPERATIVA";
        public static string NUMERO_REA = "NUMERO_REA";
        public static string DENOMINAZIONE = "DENOMINAZIONE";
        //public static string FLAG_ADERENZA = "FLAG_ADERENZA";
        //public static string DATA_ADERENZA = "DATA_ADERENZA";
        //public static string DATA_ADERENZA_AL = "DATA_ADERENZA_AL";
        public static string STATO_ISCRIZIONE = "STATO_ISCRIZIONE";
        public static string STATO_SOGG_REV = "STATO_SOGG_REV";
        public static string ESENTE_VERSAM_UTILI = "ESENTE_VERSAM_UTILI";
        public static string CADENZA_REV = "CADENZA_REV";
        public static string FORMA_GIURIDICA = "FORMA_GIURIDICA";
        public static string DATA_COSTITUZIONE = "DATA_COSTITUZIONE";
        public static string TIPO_COSTITUZIONE = "TIPO_COSTITUZIONE";
        public static string COD_UFF = "COD_UFF";
        public static string COD_OPERATORE = "COD_OPERATORE";
        public static string DATA_BILANCIO = "DATA_BILANCIO";
        public static string ATTIVITA = "ATTIVITA";
        public static string ATT_FLAG_CCIAA = "ATT_FLAG_CCIAA";
        public static string FLAG_GRUPPO = "FLAG_GRUPPO";
        public static string INDIRIZZO_SEDE = "INDIRIZZO_SEDE";

        #endregion Registro cooperativa

        #region Soggetto

        public static string DATA_NASCITA = "DATA_NASCITA";
        public static string ID_SOGGETTO = "ID_SOGGETTO";
        public static string ID_TIPO_SOGGETTO = "ID_TIPO_SOGGETTO";
        public static string LUOGO_NASCITA = "LUOGO_NASCITA";
        public static string CODICE_FISCALE = "CODICE_FISCALE";
        public static string NOME = "NAME";
        public static string COGNOME = "COGNOME";

        #endregion Soggetto

        #region Annotazione

        public static string ANNOTAZIONE_DATA_DA = "ANNOTAZIONE_DATA_DA";
        public static string ANNOTAZIONE_DATA_A = "ANNOTAZIONE_DATA_A";
        public static string ANNOTAZIONE_ID_TIPO = "ANNOTAZIONE_ID_TIPO";
        public static string ANNOTAZIONE_DESCRIZIONE = "ANNOTAZIONE_DESCRIZIONE";
        public static string ANNOTAZIONE_FLAG_EVASA = "ANNOTAZIONE_FLAG_EVASA";
        public static string ANNOTAZIONE_DATA_SCAD_DA = "ANNOTAZIONE_DATA_SCAD_DA";
        public static string ANNOTAZIONE_DATA_SCAD_A = "ANNOTAZIONE_DATA_SCAD_A";

        #endregion Annotazione

        #region Documentazione

        public static string DOC_ID_TIPO = "DOC_ID_TIPO";
        public static string DOC_TITOLO = "DOC_TITOLO";

        #endregion Documentazione

        #region Fallimenti

        public static string FALLIMENTO_DATA_SENTENZA = "FALLIMENTO_DATA_SENTENZA";
        public static string FALLIMENTO_CURATORE = "FALLIMENTO_CURATORE";
        public static string FALLIMENTO_TRIBUNALE = "FALLIMENTO_TRIBUNALE";
        public static string FALLIMENTO_STATO = "FALLIMENTO_STATO";

        #endregion Fallimenti

        #region Procedimenti

        public static string PROC_DATA_DA = "PROC_DATA_DA";
        public static string PROC_DATA_A = "PROC_DATA_A";
        public static string PROC_TIPO_INIZIATIVA = "PROC_TIPO_INIZIATIVA";
        public static string PROC_TIPO_PROC = "PROC_TIPO_PROC";
        public static string PROC_STATO = "PROC_STATO";
        public static string PROC_DATA_TEORICA_FINE = "PROC_DATA_TEORICA_FINE";
        public static string PROC_DATA_CONCLUSIONE = "PROC_DATA_CONCLUSIONE";

        #endregion Procedimenti

        #region Procedure coatte

        public static string PROCEDURA_COATTA_DATA_INIZIO = "PROCEDURA_COATTA_DATA_INIZIO";
        public static string PROCEDURA_COATTA_ID = "PROCEDURA_COATTA_ID";
        public static string PROCEDURA_COATTA_ID_TIPO = "PROCEDURA_COATTA_ID_TIPO";
        public static string PROCEDURA_COATTA_DATA_CONCLUSIONE = "PROCEDURA_COATTA_DATA_CONCLUSIONE";
        public static string PROCEDURA_COATTA_ID_SOGGETTO = "PROCEDURA_COATTA_ID_SOGGETTO";

        #endregion Procedure coatte

        #region Liquidazioni coatte

        public static string LIQUIDAZIONE_COATTA_DATA_GIUNTA = "LIQUIDAZIONE_COATTA_DATA_GIUNTA";
        public static string LIQUIDAZIONE_COATTA_ID_TIPO = "LIQUIDAZIONE_COATTA_ID_TIPO";
        public static string LIQUIDAZIONE_COATTA_ID_SOGGETTO = "LIQUIDAZIONE_COATTA_ID_SOGGETTO";
        public static string LIQUIDAZIONE_COATTA_DEPOSITO_BFL = "LIQUIDAZIONE_COATTA_DEPOSITO_BFL";
        public static string LIQUIDAZIONE_COATTA_PROCEDURA_CONCLUSA = "LIQUIDAZIONE_COATTA_PROCEDURA_CONCLUSA";
        public static string LIQUIDAZIONE_COATTA_PROCEDURA_REVOCATA = "LIQUIDAZIONE_COATTA_PROCEDURA_REVOCATA";
        public static string LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT = "LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT";
        public static string LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT_ID = "LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT_ID";
        public static string LIQUIDAZIONE_COATTA_ACQUISTO_CREDITI_FISCALI = "LIQUIDAZIONE_COATTA_ACQUISTO_CREDITI_FISCALI";
        public static string LIQUIDAZIONE_COATTA_CODICE_UFFICIO = "LIQUIDAZIONE_COATTA_CODICE_UFFICIO";
        public static string LIQUIDAZIONE_COATTA_ID = "LIQUIDAZIONE_COATTA_ID";

        #endregion Liquidazioni coatte

        #region Liquidazioni coatte

        public static string RELAZIONE_SEMESTRALE_DATA_RIFERIMENTO = "RELAZIONE_SEMESTRALE_DATA_RIFERIMENTO";
        
        #endregion Liquidazioni coatte

        #region Bilanci

        public static string BILANCIO_ID = "BILANCIO_ID";
        public static string BILANCIO_ANNO_DA = "BILANCIO_ANNO_DA";
        public static string BILANCIO_ANNO_A = "BILANCIO_ANNO_A";
        public static string BILANCIO_FLAG_UTILI = "BILANCIO_FLAG_UTILI";
        public static string BILANCIO_FLAG_VERIFICA = "BILANCIO_FLAG_VERIFICA";
        public static string BILANCIO_FLAG_SEGNALAZIONE = "BILANCIO_FLAG_SEGNALAZIONE";
        public static string BILANCIO_TIPO = "BILANCIO_TIPO";
        public static string BILANCIO_MUTUALITA = "BILANCIO_MUTUALITA";

        #endregion Bilanci

        #region Cancellazioni

        public static string CANC_DATA_DETERMINA = "CANC_DATA_DETERMINA";
        public static string CANC_DATA_REG = "CANC_DATA_REG";
        public static string CANC_DATA_ALBO = "CANC_DATA_ALBO";
        public static string CANC_FLAG_RI = "CANC_FLAG_RI";
        public static string CANC_FLAG_REGCOOP = "CANC_FLAG_REGCOOP";
        public static string CANC_FLAG_ALBO = "CANC_FLAG_ALBO";

        #endregion Cancellazioni

        #region Modifiche Stat

        public static string MODSTAT_DATA_ASS_DA = "MODSTAT_DATA_ASS_DA";
        public static string MODSTAT_DATA_ASS_A = "MODSTAT_DATA_ASS_A";
        public static string MODSTAT_ID_TIPO_ASS = "MODSTAT_ID_TIPO_ASS";
        public static string MODSTAT_VECCHIA_DENOMINAZIONE = "MODSTAT_VECCHIA_DENOMINAZIONE";
        public static string MODSTAT_FLAG_COLL = "MODSTAT_FLAG_COLL";
        public static string MODSTAT_ID_TIPO_MODIFICA = "MODSTAT_ID_TIPO_MODIFICA";

        #endregion Modifiche Stat

        #region Revisioni

        public static string REV_ANNO = "REV_ANNO";
        public static string REV_ID_TIPO = "REV_ID_TIPO";
        public static string REV_ID_ESITO = "REV_ID_ESITO";
        public static string REV_ID_ORGANO = "REV_ID_ORGANO";
        public static string REV_ID_REVISORE = "REV_ID_REVISORE";
        public static string REV_ID_LIMITI = "REV_ID_LIMITI";
        public static string REV_DATA_SCAD = "REV_DATA_SCAD";
        public static string REV_ID_INC = "REV_ID_INC";
        public static string REV_FLAG_LIQUID = "REV_FLAG_LIQUID";
        public static string REV_DATA_CONCLUSIONE = "REV_DATA_CONCLUSIONE";
        public static string REV_DATA_REVOCA_DET = "REV_DATA_REVOCA_DET";
        public static string REV_DATA_REVOCA_DEL = "REV_DATA_REVOCA_DEL";

        #endregion Revisioni

        #region Sanzioni

        public static string SANZ_DATA_RILIEVO = "SANZ_DATA_RILIEVO";
        public static string SANZ_DATA_RICORSO = "SANZ_DATA_RICORSO";
        public static string SANZ_DATA_OBLAZIONE = "SANZ_DATA_OBLAZIONE";

        #endregion Sanzioni

        public static string FUNCTION_CALL_GETADESIONI = "FUNCTION_CALL_GETADESIONI";

        #region Gruppi paritetici

        public static string GRUPPO_PARITETICO_NUMERO_ATTO = "GRUPPO_PARITETICO_NUMERO_ATTO";
        public static string GRUPPO_PARITETICO_DATA_ATTO = "GRUPPO_PARITETICO_DATA_ATTO";
        public static string GRUPPO_PARITETICO_DATA_FINO_AL = "GRUPPO_PARITETICO_DATA_FINO_AL";
        public static string GRUPPO_PARITETICO_NOTE = "GRUPPO_PARITETICO_NOTE";
        
        #endregion Gruppi paritetici

        #endregion Fields

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace it.dedagroup.GVC.Repository.rtier.Service.ExportXML
{
    public class ExportCooperative
    {
        /// <summary>
        /// Gateway to the Database 
        /// </summary>
        protected GVC _db;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="db">Istance of the Database</param>
        public ExportCooperative(GVC db)
        {
            _db = db;
        }

        /// <summary>
        /// Property for the Database
        /// </summary>
        protected GVC Database
        {
            get
            {
                return _db;
            }
        }

        public DataSet GetDataToExport(int[] idCooperative)
        {
            DataSet toReturn;
            DataRelation rel;
            StringBuilder sbSqlWhere;

            toReturn = new DataSet();

            sbSqlWhere = new StringBuilder();

            sbSqlWhere.Append("{0} IN (");
            for (int i = 0; i < idCooperative.Length; i++)
            {
                if ((i != 0) && ((i % 1000) == 0))
                {
                    sbSqlWhere.Append(") OR {0} IN (");
                }
                else if (i > 0)
                {
                    sbSqlWhere.Append(", ");
                }

                sbSqlWhere.Append(idCooperative[i]);
            }
            sbSqlWhere.Append(")");

            using (IDataReader reader = _db.ExecuteReader(CreateSoggettiGetCommand(string.Format(sbSqlWhere.ToString(), "SOG.IDOBJ"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsSoggettiToDataTable(reader));
            }


            using (IDataReader reader = _db.ExecuteReader(CreateIndirizziGetCommand(string.Format(sbSqlWhere.ToString(), "IND.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsIndirizziToDataTable(reader));
            }

            rel = new DataRelation("relSoggettiIndirizzi", toReturn.Tables["Soggetti"].Columns["IDOBJ"], toReturn.Tables["Indirizzi"].Columns["IDOBJ_SOGGETTO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateRegistriGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsRegistriToDataTable(reader));
            }

            rel = new DataRelation("relSoggettiRegistri", toReturn.Tables["Soggetti"].Columns["IDOBJ"], toReturn.Tables["Registri"].Columns["IDOBJ_SOGGETTO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateCambioPosizioneGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsCambioPosizioneToDataTable(reader));
            }

            rel = new DataRelation("relRegistriCambioPosizione", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["CambioPosizione"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateAdesioniGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsAdesioniToDataTable(reader));
            }

            rel = new DataRelation("relRegistriAdesioni", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["Adesioni"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateBilanciGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsBilanciToDataTable(reader));
            }

            rel = new DataRelation("relRegistriBilanci", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["Bilanci"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateComunicazioneCaricaSocialGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsComunicazioneCaricaSocialToDataTable(reader));
            }

            rel = new DataRelation("relRegistriComunicazioneCaricaSocial", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["ComunicazioneCaricaSocial"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateCaricheSocialiGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsCaricheSocialiToDataTable(reader));
            }

            rel = new DataRelation("relComunicazioneCaricaSocialCaricheSociali", toReturn.Tables["ComunicazioneCaricaSocial"].Columns["IDOBJ"], toReturn.Tables["CaricheSociali"].Columns["IDOBJ_COMUNICAZIONE"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateComunicazioneBaseSocialeGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsComunicazioneBaseSocialeToDataTable(reader));
            }

            rel = new DataRelation("relRegistriComunicazioneBaseSociale", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["ComunicazioneBaseSociale"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateAssembleeGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsAssembleeToDataTable(reader));
            }

            rel = new DataRelation("relRegistriAssemblee", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["Assemblee"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateModificheStatutarieGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsModificheStatutarieToDataTable(reader));
            }

            rel = new DataRelation("relAssembleeModificheStatutarie", toReturn.Tables["Assemblee"].Columns["IDOBJ"], toReturn.Tables["ModificheStatutarie"].Columns["IDOBJ_ASSEMBLEA"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);


            using (IDataReader reader = _db.ExecuteReader(CreateRevisioniGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsRevisioniToDataTable(reader));
            }

            rel = new DataRelation("relRegistriRevisioni", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["Revisioni"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateIncarichiGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsIncarichiToDataTable(reader));
            }

            rel = new DataRelation("relRevisioniIncarichi", toReturn.Tables["Revisioni"].Columns["IDOBJ"], toReturn.Tables["Incarichi"].Columns["IDOBJ_REVISIONE"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateCompensiIncarichiGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsCompensiIncarichiToDataTable(reader));
            }

            rel = new DataRelation("relIncarichiCompensi", toReturn.Tables["Incarichi"].Columns["IDOBJ"], toReturn.Tables["CompensiIncarichi"].Columns["IDOBJ_INCARICO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateLiquidazioniRevisioniGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsLiquidazioniRevisioniToDataTable(reader));
            }

            rel = new DataRelation("relRevisioniLiquidazioniRevisioni", toReturn.Tables["Revisioni"].Columns["IDOBJ"], toReturn.Tables["LiquidazioniRevisioni"].Columns["IDOBJ_REVISIONE"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateFallimentariGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsFallimentariToDataTable(reader));
            }

            rel = new DataRelation("relRegistriFallimentari", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["Fallimentari"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateProcedureCoatteGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsProcedureCoatteToDataTable(reader));
            }

            rel = new DataRelation("relRegistriProcedureCoatte", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["ProcedureCoatte"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateCompensiProcedureCoatteGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsCompensiProcedureCoatteToDataTable(reader));
            }

            rel = new DataRelation("relProcedureCoatteCompensi", toReturn.Tables["ProcedureCoatte"].Columns["IDOBJ"], toReturn.Tables["CompensiProcedureCoatte"].Columns["IDOBJ_PROCEDURA"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateLiquidazioniProcedureCoatteGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsLiquidazioniProcedureCoatteToDataTable(reader));
            }

            rel = new DataRelation("relProcedureCoatteLiquidazioni", toReturn.Tables["ProcedureCoatte"].Columns["IDOBJ"], toReturn.Tables["LiquidazioniProcedureCoatte"].Columns["IDOBJ_PROCEDURA"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateLiquidazioniCoatteGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsLiquidazioniCoatteToDataTable(reader));
            }

            rel = new DataRelation("relRegistriLiquidazioniCoatte", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["LiquidazioniCoatte"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateRelazioniSemestraliGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsRelazioniSemestraliToDataTable(reader));
            }

            rel = new DataRelation("relLiquidazioniCoatteRelazioniSemestrali", toReturn.Tables["LiquidazioniCoatte"].Columns["IDOBJ"], toReturn.Tables["RelazioniSemestrali"].Columns["IDOBJ_LIQUIDAZIONE"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateAutorizzazioniGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsAutorizzazioniToDataTable(reader));
            }

            rel = new DataRelation("relLiquidazioniCoatteAutorizzazioni", toReturn.Tables["LiquidazioniCoatte"].Columns["IDOBJ"], toReturn.Tables["Autorizzazioni"].Columns["IDOBJ_LIQUIDAZIONE"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateLiquidazioniLiquidazioniCoatteGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsLiquidazioniLiquidazioniCoatteToDataTable(reader));
            }

            rel = new DataRelation("relLiquidazioniCoatteLiquidazioni", toReturn.Tables["LiquidazioniCoatte"].Columns["IDOBJ"], toReturn.Tables["LiquidazioniLiquidazioniCoatte"].Columns["IDOBJ_LIQUIDAZIONE"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            using (IDataReader reader = _db.ExecuteReader(CreateCancellazioniGetCommand(string.Format(sbSqlWhere.ToString(), "R.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsCancellazioniToDataTable(reader));
            }

            rel = new DataRelation("relRegistriCancellazioni", toReturn.Tables["Registri"].Columns["IDOBJ"], toReturn.Tables["Cancellazioni"].Columns["IDOBJ_REGISTRO"]);
            rel.Nested = true;
            toReturn.Relations.Add(rel);

            return toReturn;
        }

        protected virtual IDbCommand CreateSoggettiGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("SOG.IDOBJ, ");
            sql.Append("TSO.descrizione AS TIPO_SOGGETTO, ");
            sql.Append("SOG.FLAG_ASSOCIAZIONE, ");
            sql.Append("SOG.FLAG_PF, ");
            sql.Append("SOG.DENOMINAZIONE, ");
            sql.Append("SOG.CODICE_FISCALE, ");
            sql.Append("SOG.NOTE ");
            sql.Append("FROM GVCTSOGGETTI SOG ");
            sql.Append("left join GVCDTIPI_SOGGETTO TSO ON ");
            sql.Append("SOG.IDOBJ_TIPO_SOGGETTO = TSO.idobj ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateIndirizziGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("IND.IDOBJ, ");
            sql.Append("IND.FLAG_PRINCIPALE, ");
            sql.Append("IND.FLAG_SEDE, ");
            sql.Append("IND.VIA, ");
            sql.Append("IND.IDOBJ_SOGGETTO, ");
            sql.Append("IND.IDOBJ_TIPO_INDIRIZZO, ");
            sql.Append("TIN.DESCRIZIONE AS TIPO_INDIRIZZO, ");
            sql.Append("IND.CIVICO, ");
            sql.Append("IND.CAP, ");
            sql.Append("IND.PROVINCIA, ");
            sql.Append("IND.COMUNE, ");
            sql.Append("IND.FRAZIONE, ");
            sql.Append("IND.STATO, ");
            sql.Append("IND.CODICE_STRADARIO, ");
            sql.Append("IND.TELEFONO, ");
            sql.Append("IND.FAX, ");
            sql.Append("IND.ALTRO, ");
            sql.Append("IND.NOTE, ");
            sql.Append("IND.DATA_INIZIO, ");
            sql.Append("IND.DATA_FINE, ");
            sql.Append("IND.EMAIL, ");
            sql.Append("IND.WEBPAGE ");
            sql.Append("FROM GVCTINDIRIZZI IND ");
            sql.Append("left join GVCDTIPI_INDIRIZZO TIN ON ");
            sql.Append("IND.IDOBJ_TIPO_INDIRIZZO = TIN.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateRegistriGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("R.IDOBJ, ");
            sql.Append("R.IDOBJ_SOGGETTO, ");
            sql.Append("R.NUMERO_REA, ");
            sql.Append("R.NUMERO_RI, ");
            sql.Append("R.NUMERO_ALBO, ");
            sql.Append("R.FORMA_GIURIDICA_CCIAA, ");
            sql.Append("R.DATA_COSTITUZIONE, ");
            sql.Append("R.DURATA, ");
            sql.Append("R.DURATA_ILLIMITATA, ");
            sql.Append("R.BILANCIO_ESERCIZIO_AL, ");
            sql.Append("R.GRUPPO_PARITETICO, ");
            sql.Append("R.DATA_BFL, ");
            sql.Append("R.DATA_DEPOSITO_BFL, ");
            sql.Append("R.NUMERO_SCIOGLIMENTO, ");
            sql.Append("R.ESENTE_VERSAMENTO_UTILI, ");
            sql.Append("R.IMPORTO_VERSAMENTO, ");
            sql.Append("R.CODICE_OPERATORE, ");
            sql.Append("R.CODICE_UFFICIO, ");
            sql.Append("SI.DESCRIZIONE AS STATO_ISCRIZIONE, ");
            sql.Append("TC.DESCRIZIONE AS TIPO_COSTITUZIONE, ");
            sql.Append("IDOBJ_NOTAIO, ");
            sql.Append("FA.DESCRIZIONE AS FORMA_AMMINISTRATIVA, ");
            sql.Append("FG.DESCRIZIONE AS FORMA_GIURIDICA, ");
            sql.Append("CR.DESCRIZIONE AS CADENZA_REVISIONE, ");
            sql.Append("CODICE_COOPERATIVA, ");
            sql.Append("NUMERO_REPERTORIO_NOTAIO, ");
            sql.Append("FORMA_AMM_CCIAA, ");
            sql.Append("DATA_ACQUISIZIONE_ATTO, ");
            sql.Append("DATA_DEPOSITO_ATTO, ");
            sql.Append("NUMERO_ESAME, ");
            sql.Append("DATA_ESAME ");
            sql.Append("FROM GVCTREGISTRI R ");
            sql.Append("left join GVCDSTATI_ISCRIZIONE SI ");
            sql.Append("ON SI.idobj = r.idobj_stato ");
            sql.Append("left join GVCDTIPI_COSTITUZIONE TC ");
            sql.Append("ON TC.idobj = r.idobj_tipo_costituzione ");
            sql.Append("left join GVCDFORME_GIURIDICHE FG ");
            sql.Append("ON FG.idobj = r.idobj_forma_giuridica ");
            sql.Append("left join GVCDCADENZA_REVISIONI CR ");
            sql.Append("ON CR.idobj = r.idobj_cadenza_revisione ");
            sql.Append("left join GVCDFORMA_AMMINISTRATIVA FA ");
            sql.Append("ON FA.idobj = r.IDOBJ_FORMA_AMMINISTRATIVA ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCambioPosizioneGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("CP.IDOBJ, ");
            sql.Append("CP.DATA_DOMANDA, ");
            sql.Append("CP.IDOBJ_REGISTRO, ");
            sql.Append("CP.NUMERO_DETERMINA, ");
            sql.Append("CP.DATA_DETERMINA, ");
            sql.Append("CP.NUMERO_DELIBERA, ");
            sql.Append("CP.DATA_DELIBERA, ");
            sql.Append("CP.SEZIONE, ");
            sql.Append("CP.SOTTOSEZIONE, ");
            sql.Append("CP.CATEGORIA_SOCIALE, ");
            sql.Append("CP.NOTE, ");
            sql.Append("CP.NUMERO_POSIZIONE, ");
            sql.Append("C.DESCRIZIONE AS CATEGORIA, ");
            sql.Append("SC.DESCRIZIONE AS SOTTOCATEGORIA ");
            sql.Append("FROM GVCTCAMBI_POSIZIONE CP ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON CP.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDCATEGORIE C ");
            sql.Append("ON CP.IDOBJ_CATEGORIA = C.IDOBJ ");
            sql.Append("LEFT JOIN GVCDSOTTOCATEGORIE SC ");
            sql.Append("ON CP.IDOBJ_SOTTOCATEGORIA = SC.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateAdesioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("A.IDOBJ, ");
            sql.Append("A.DATA_INIZIO_ADESIONE, ");
            sql.Append("A.REVISORE, ");
            sql.Append("SA.DENOMINAZIONE AS ASSOCIAZIONE, ");
            sql.Append("A.IDOBJ_REGISTRO, ");
            sql.Append("A.DATA_ESAME_INIZIO, ");
            sql.Append("A.DATA_FINE_ADESIONE, ");
            sql.Append("A.DATA_ESAME_FINE, ");
            sql.Append("A.NOTE ");
            sql.Append("FROM GVCTADESIONI A ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON A.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("left join GVCTSOGGETTI SA ");
            sql.Append("ON A.IDOBJ_ASSOCIAZIONE = SA.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateBilanciGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("B.IDOBJ, ");
            sql.Append("B.ANNO_RIFERIMENTO, ");
            sql.Append("B.IDOBJ_REGISTRO, ");
            sql.Append("TB.DESCRIZIONE AS TIPO_BILANCIO, ");
            sql.Append("B.DATA_RIFERIMENTO, ");
            sql.Append("B.DATA_DEPOSITO_RI, ");
            sql.Append("B.DATA_SEGNALAZIONE, ");
            sql.Append("B.REQUISITO_PREVALENZA, ");
            sql.Append("B.IMPORTO_PERCENTO_UTILI, ");
            sql.Append("B.IMPORTO_PATRIMONIO, ");
            sql.Append("B.VERIFICA_PAGAMENTO, ");
            sql.Append("B.NOTE ");
            sql.Append("FROM GVCTBILANCI B ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON B.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_BILANCIO TB ");
            sql.Append("ON B.IDOBJ_TIPO_BILANCIO = TB.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateComunicazioneCaricaSocialGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("C.IDOBJ, ");
            sql.Append("C.DATA_SITUAZIONE, ");
            sql.Append("C.IDOBJ_REGISTRO, ");
            sql.Append("C.DATA_COMUNICAZIONE, ");
            sql.Append("C.DATA_ANTIMAFIA, ");
            sql.Append("C.PROTOCOLLO_ANTIMAFIA, ");
            sql.Append("C.NOTE ");
            sql.Append("FROM GVCTCOM_CARICHE C ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON C.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCaricheSocialiGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("C.IDOBJ, ");
            sql.Append("C.FLAG_LEGALE, ");
            sql.Append("C.FLAG_LIQUIDATORE, ");
            sql.Append("C.ANTIMAFIA, ");
            sql.Append("C.ANTIMAFIA_ARRIVATA, ");
            sql.Append("C.IDOBJ_COMUNICAZIONE, ");
            sql.Append("C.SOCIO_GCS, ");
            sql.Append("C.ANTIMAFIA_PRODOTTA, ");
            sql.Append("TC.DESCRIZIONE AS TIPO_CARICA, ");
            sql.Append("C.DATA_INIZIO, ");
            sql.Append("C.DATA_FINE ");
            sql.Append("FROM GVCRCARICHE C ");
            sql.Append("LEFT JOIN GVCTCOM_CARICHE CC ");
            sql.Append("ON C.IDOBJ_COMUNICAZIONE = CC.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON CC.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_CARICA TC ");
            sql.Append("ON C.IDOBJ_TIPO_CARICA = TC.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateComunicazioneBaseSocialeGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("C.IDOBJ, ");
            sql.Append("C.IDOBJ_REGISTRO, ");
            sql.Append("C.DATA_COMUNICAZIONE, ");
            sql.Append("C.DATA_SITUAZIONE, ");
            sql.Append("C.SOCI_COOPERATORI, ");
            sql.Append("C.SOCI_SOVVENTORI, ");
            sql.Append("C.ALTRI_SOCI, ");
            sql.Append("C.LAVORATORI, ");
            sql.Append("C.LAVORATORI_SOCI, ");
            sql.Append("C.LAVORATORI_REMUNERATI, ");
            sql.Append("C.SOCI_UTENTI, ");
            sql.Append("C.SOCI_VOLONTARI, ");
            sql.Append("C.SOCI_PG, ");
            sql.Append("C.LAVORATORI_TUTTI, ");
            sql.Append("C.PERSONE_SVANTAGGIATE, ");
            sql.Append("C.CONFERIMENTO_CAPITALE, ");
            sql.Append("C.VALORE_QUOTE, ");
            sql.Append("C.VALORE_AZIONE, ");
            sql.Append("C.CAPITALE_SOTTOSCRITTO, ");
            sql.Append("C.CAPITALE_VERSATO, ");
            sql.Append("C.NOTE ");
            sql.Append("FROM GVCTCOM_BASE_SOCIALE C ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON C.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateAssembleeGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("A.IDOBJ, ");
            sql.Append("A.DATA_ASSEMBLEA, ");
            sql.Append("A.IDOBJ_REGISTRO, ");
            sql.Append("TA.DESCRIZIONE AS TIPO_ASSEMBLEA, ");
            sql.Append("A.CONTENUTO, ");
            sql.Append("A.DATA_ISCRIZIONE_RI, ");
            sql.Append("A.NUMERO_ESAME, ");
            sql.Append("A.DATA_ESAME, ");
            sql.Append("A.DATA_EVASIONE, ");
            sql.Append("S.COGNOME || ' ' || S.NOME  AS NOTAIO ");
            sql.Append("FROM GVCTDELIBERE_ASSEMBLEA A ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON A.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_ASSEMBLEA TA ");
            sql.Append("ON A.IDOBJ_TIPO_ASSEMBLEA = TA.IDOBJ ");
            sql.Append("LEFT JOIN GVCTSOGGETTI S ");
            sql.Append("ON A.IDOBJ_NOTAIO = S.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateModificheStatutarieGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("MS.IDOBJ, ");
            sql.Append("MS.DATA_INIZIO, ");
            sql.Append("TM.DESCRIZIONE AS TIPO_MODIFICA, ");
            sql.Append("MS.IDOBJ_ASSEMBLEA, ");
            sql.Append("MS.VECCHIA_DENOMINAZIONE, ");
            sql.Append("MS.NUOVA_DENOMINAZIONE, ");
            sql.Append("FGV.DESCRIZIONE AS VECCHIA_FG, ");
            sql.Append("FGN.DESCRIZIONE AS NUOVA_FG, ");
            sql.Append("MS.NUOVA_DURATA, ");
            sql.Append("MS.NUOVA_ILLIMITATA, ");
            sql.Append("MS.VECCHIO_BILANCIO_AL, ");
            sql.Append("MS.NUOVO_BILANCIO_AL, ");
            sql.Append("MS.DATA_ATTO_FUSIONE, ");
            sql.Append("MS.DATA_ISCRIZIONE_ATTO, ");
            sql.Append("MS.DATA_EFFICACIA_ATTO, ");
            sql.Append("SIV.DESCRIZIONE AS VECCHIO_STATO, ");
            sql.Append("SIN.DESCRIZIONE AS NUOVO_STATO, ");
            sql.Append("MS.NOTE, ");
            sql.Append("S.COGNOME || ' ' || S.NOME  AS NOTAIO ");
            sql.Append("FROM GVCTMODIFICHE_STATUTARIE MS ");
            sql.Append("LEFT JOIN GVCTDELIBERE_ASSEMBLEA A ");
            sql.Append("ON MS.IDOBJ_ASSEMBLEA = A.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON A.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_MODIFICA TM ");
            sql.Append("ON MS.IDOBJ_TIPO_MODIFICA = TM.IDOBJ ");
            sql.Append("LEFT JOIN GVCDFORME_GIURIDICHE FGV ");
            sql.Append("ON MS.IDOBJ_VECCHIA_FG = FGV.IDOBJ ");
            sql.Append("LEFT JOIN GVCDFORME_GIURIDICHE FGN ");
            sql.Append("ON MS.IDOBJ_NUOVA_FG = FGN.IDOBJ ");
            sql.Append("left join GVCDSTATI_ISCRIZIONE SIV ");
            sql.Append("ON MS.IDOBJ_VECCHIO_STATO = SIV.IDOBJ ");
            sql.Append("left join GVCDSTATI_ISCRIZIONE SIN ");
            sql.Append("ON MS.IDOBJ_NUOVO_STATO = SIN.IDOBJ ");
            sql.Append("LEFT JOIN GVCTSOGGETTI S ");
            sql.Append("ON MS.IDOBJ_NOTAIO = S.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateRevisioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("RV.IDOBJ, ");
            sql.Append("RV.ANNO_REVISIONE, ");
            sql.Append("TR.DESCRIZIONE AS TIPO_REVISIONE, ");
            sql.Append("RV.IDOBJ_REGISTRO, ");
            sql.Append("RV.DATA_CONCLUSIONE, ");
            sql.Append("RV.DATA_DEPOSITO_RELAZIONE, ");
            sql.Append("RV.NUMERO_DELIBERA_ESAME, ");
            sql.Append("RV.DATA_DELIBERA_ESAME, ");
            sql.Append("RV.NUMERO_DETERMINA_ESAME, ");
            sql.Append("RV.DATA_DETERMINA_ESAME, ");
            sql.Append("RV.DATA_COMUNICAZIONE_ESITI, ");
            sql.Append("RV.NUMERO_DELIBERA_REVOCA, ");
            sql.Append("RV.DATA_DELIBERA_REVOCA, ");
            sql.Append("RV.NUMERO_DETERMINA_REVOCA, ");
            sql.Append("RV.DATA_DETERMINA_REVOCA, ");
            sql.Append("SG.DENOMINAZIONE AS ORGANO_REVISORE, ");
            sql.Append("ER.DESCRIZIONE AS ESITO_REVISIONE ");
            sql.Append("FROM GVCTREVISIONI RV ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON RV.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_REVISIONE TR ");
            sql.Append("ON RV.IDOBJ_TIPO_REVISIONE = TR.IDOBJ ");
            sql.Append("LEFT JOIN GVCDESITI_REVISIONE ER ");
            sql.Append("ON RV.IDOBJ_ESITO_REVISIONE = ER.IDOBJ ");
            sql.Append("LEFT JOIN GVCTSOGGETTI SG ");
            sql.Append("ON RV.IDOBJ_ORGANO_REVISORE = SG.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateIncarichiGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("I.IDOBJ, ");
            sql.Append("I.IDOBJ_REVISIONE, ");
            sql.Append("I.NUMERO_DELIBERA_INCARICO, ");
            sql.Append("I.DATA_DELIBERA_INCARICO, ");
            sql.Append("I.NUMERO_DETERMINA_INCARICO, ");
            sql.Append("I.DATA_DETERMINA_INCARICO, ");
            sql.Append("I.DATA_SCADENZA_TEORICA, ");
            sql.Append("I.IMPEGNO, ");
            sql.Append("I.NUMERO_DELIBERA_RICUSAZIONE, ");
            sql.Append("I.DATA_DELIBERA_RICUSAZIONE, ");
            sql.Append("I.NUMERO_DETERMINA_RICUSAZIONE, ");
            sql.Append("I.DATA_DETERMINA_RICUSAZIONE ");
            sql.Append("FROM GVCTINCARICHI I ");
            sql.Append("LEFT JOIN GVCTREVISIONI RV ");
            sql.Append("ON I.IDOBJ_REVISIONE = RV.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON RV.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCompensiIncarichiGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("C.IDOBJ, ");
            sql.Append("SG.COGNOME || ' ' || SG.NOME  AS SOGGETTO, ");
            sql.Append("C.PERCENTUALE_CNP, ");
            sql.Append("C.PERCENTUALE_IVA, ");
            sql.Append("C.VALUTA, ");
            sql.Append("C.COMPENSO, ");
            sql.Append("C.SPESE, ");
            sql.Append("C.CASSA, ");
            sql.Append("C.IVA, ");
            sql.Append("C.TOTALE, ");
            sql.Append("C.IDOBJ_INCARICO, ");
            sql.Append("C.TIPO_CONTRIBUTO, ");
            sql.Append("C.NUMERO_DETERMINA, ");
            sql.Append("C.DATA_DETERMINA ");
            sql.Append("FROM GVCTCOMPENSI C ");
            sql.Append("LEFT JOIN GVCTINCARICHI I ");
            sql.Append("ON C.IDOBJ_INCARICO = I.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREVISIONI RV ");
            sql.Append("ON I.IDOBJ_REVISIONE = RV.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON RV.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCTSOGGETTI SG ");
            sql.Append("ON C.IDOBJ_SOGGETTO = SG.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateLiquidazioniRevisioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("LC.IDOBJ, ");
            sql.Append("LC.DATA_DOMANDA, ");
            sql.Append("LC.PERCENTUALE_CONTRIBUTO, ");
            sql.Append("LC.VALUTA, ");
            sql.Append("LC.IMPORTO_DETERMINATO, ");
            sql.Append("LC.IMPORTO_RICHIESTO, ");
            sql.Append("LC.IMPORTO_CONTRIBUTO, ");
            sql.Append("LC.IMPORTO_SPESE, ");
            sql.Append("LC.TIPO_CONTRIBUTO, ");
            sql.Append("LC.NUMERO_DETERMINA, ");
            sql.Append("LC.DATA_DETERMINA, ");
            sql.Append("LC.LIQUIDATO, ");
            sql.Append("LC.NUMERO_MANDATO, ");
            sql.Append("LC.DATA_MANDATO, ");
            sql.Append("LC.NOTE, ");
            sql.Append("LC.IDOBJ_REVISIONE ");
            sql.Append("FROM GVCTLIQUIDAZIONE_COMPENSI LC ");
            sql.Append("LEFT JOIN GVCTREVISIONI RV ");
            sql.Append("ON LC.IDOBJ_REVISIONE = RV.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON RV.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateFallimentariGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("F.IDOBJ, ");
            sql.Append("F.DATA_SENTENZA, ");
            sql.Append("F.IDOBJ_REGISTRO, ");
            sql.Append("F.DATA_FINE, ");
            sql.Append("F.ESITO, ");
            sql.Append("F.TRIBUNALE, ");
            sql.Append("SG.COGNOME || ' ' || SG.NOME AS CURATORE ");
            sql.Append("FROM GVCTFALLIMENTI F ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON F.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCTSOGGETTI SG ");
            sql.Append("ON F.IDOBJ_CURATORE = SG.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateProcedureCoatteGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("PC.IDOBJ, ");
            sql.Append("TP.DESCRIZIONE TIPO_PROCEDURA, ");
            sql.Append("PC.IDOBJ_REGISTRO, ");
            sql.Append("PC.NUMERO_DELIBERA, ");
            sql.Append("PC.DATA_DELIBERA, ");
            sql.Append("PC.NUMERO_DETERMINA, ");
            sql.Append("PC.DATA_DETERMINA, ");
            sql.Append("PC.DATA_INIZIO, ");
            sql.Append("PC.DATA_ISCRIZIONE_RI, ");
            sql.Append("PC.DATA_SCADENZA, ");
            sql.Append("PC.DATA_CONCLUSIONE, ");
            sql.Append("PC.NUMERO_DELIBERA_FINE, ");
            sql.Append("PC.DATA_DELIBERA_FINE, ");
            sql.Append("PC.NUMERO_DETERMINA_FINE, ");
            sql.Append("PC.DATA_DETERMINA_FINE ");
            sql.Append("FROM GVCTPROCEDURE_COATTE PC ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON PC.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_PROCEDURE_COATTE TP ");
            sql.Append("ON PC.IDOBJ_TIPO_PROCEDURA = TP.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCompensiProcedureCoatteGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("C.IDOBJ, ");
            sql.Append("SG.COGNOME || ' ' || SG.NOME  AS SOGGETTO, ");
            sql.Append("C.PERCENTUALE_CNP, ");
            sql.Append("C.PERCENTUALE_IVA, ");
            sql.Append("C.VALUTA, ");
            sql.Append("C.COMPENSO, ");
            sql.Append("C.SPESE, ");
            sql.Append("C.CASSA, ");
            sql.Append("C.IVA, ");
            sql.Append("C.TOTALE, ");
            sql.Append("C.IDOBJ_PROCEDURA, ");
            sql.Append("C.TIPO_CONTRIBUTO, ");
            sql.Append("C.NUMERO_DETERMINA, ");
            sql.Append("C.DATA_DETERMINA ");
            sql.Append("FROM GVCTCOMPENSI C ");
            sql.Append("LEFT JOIN GVCTPROCEDURE_COATTE PC ");
            sql.Append("ON C.IDOBJ_PROCEDURA = PC.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON PC.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCTSOGGETTI SG ");
            sql.Append("ON C.IDOBJ_SOGGETTO = SG.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateLiquidazioniProcedureCoatteGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("LC.IDOBJ, ");
            sql.Append("LC.DATA_DOMANDA, ");
            sql.Append("LC.PERCENTUALE_CONTRIBUTO, ");
            sql.Append("LC.VALUTA, ");
            sql.Append("LC.IMPORTO_DETERMINATO, ");
            sql.Append("LC.IMPORTO_RICHIESTO, ");
            sql.Append("LC.IMPORTO_CONTRIBUTO, ");
            sql.Append("LC.IMPORTO_SPESE, ");
            sql.Append("LC.TIPO_CONTRIBUTO, ");
            sql.Append("LC.NUMERO_DETERMINA, ");
            sql.Append("LC.DATA_DETERMINA, ");
            sql.Append("LC.LIQUIDATO, ");
            sql.Append("LC.NUMERO_MANDATO, ");
            sql.Append("LC.DATA_MANDATO, ");
            sql.Append("LC.NOTE, ");
            sql.Append("LC.IDOBJ_PROCEDURA ");
            sql.Append("FROM GVCTLIQUIDAZIONE_COMPENSI LC ");
            sql.Append("LEFT JOIN GVCTPROCEDURE_COATTE PC ");
            sql.Append("ON LC.IDOBJ_PROCEDURA = PC.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON PC.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateLiquidazioniCoatteGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("LC.IDOBJ, ");
            sql.Append("TL.DESCRIZIONE AS TIPO_LIQUIDAZIONE, ");
            sql.Append("LC.IDOBJ_REGISTRO, ");
            sql.Append("LC.NUMERO_DETERMINA, ");
            sql.Append("LC.DATA_DETERMINA, ");
            sql.Append("LC.NUMERO_DELIBERA, ");
            sql.Append("LC.DATA_DELIBERA, ");
            sql.Append("LC.NUMERO_DELIBERA_GIUNTA, ");
            sql.Append("LC.DATA_DELIBERA_GIUNTA, ");
            sql.Append("LC.DATA_PUBBLICAZIONE, ");
            sql.Append("LC.DATA_DEPOSITO_RI, ");
            sql.Append("LC.DATA_INSOLVENZA, ");
            sql.Append("LC.CODICE_UFFICIO, ");
            sql.Append("LC.DEPOSITO_BFL, ");
            sql.Append("LC.PROCEDURA_REVOCATA, ");
            sql.Append("LC.NUMERO_DETERMINA_REVOCA, ");
            sql.Append("LC.DATA_DETERMINA_REVOCA, ");
            sql.Append("LC.NUMERO_DELIBERA_REVOCA, ");
            sql.Append("LC.DATA_DELIBERA_REVOCA, ");
            sql.Append("LC.PROCEDURA_CONCLUSA ");
            sql.Append("FROM GVCTLIQUIDAZIONI_COATTE LC ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON LC.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_LIQ_COATTE TL ");
            sql.Append("ON LC.IDOBJ_TIPO_LIQUIDAZIONE = TL.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateRelazioniSemestraliGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("RS.IDOBJ, ");
            sql.Append("RS.DATA_RELAZIONE, ");
            sql.Append("RS.IDOBJ_LIQUIDAZIONE, ");
            sql.Append("RS.DATA_PARERE, ");
            sql.Append("RS.DATA_ESAME, ");
            sql.Append("RS.NOTE ");
            sql.Append("FROM GVCTRELAZIONI_SEMESTRALI RS ");
            sql.Append("LEFT JOIN GVCTLIQUIDAZIONI_COATTE LC ");
            sql.Append("ON RS.IDOBJ_LIQUIDAZIONE = LC.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON LC.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateAutorizzazioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("A.IDOBJ, ");
            sql.Append("A.IDOBJ_LIQUIDAZIONE, ");
            sql.Append("TA.DESCRIZIONE TIPO_AUTORIZZAZIONE, ");
            sql.Append("A.DESCRIZIONE, ");
            sql.Append("A.DATA_ISTANZA, ");
            sql.Append("A.NUMERO_DELIBERA, ");
            sql.Append("A.DATA_DELIBERA, ");
            sql.Append("A.NUMERO_DETERMINA, ");
            sql.Append("A.DATA_DETERMINA, ");
            sql.Append("A.NOTE ");
            sql.Append("FROM GVCTAUTORIZZAZIONI A ");
            sql.Append("LEFT JOIN GVCTLIQUIDAZIONI_COATTE LC ");
            sql.Append("ON A.IDOBJ_LIQUIDAZIONE = LC.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON LC.IDOBJ_REGISTRO = R.IDOBJ ");
            sql.Append("LEFT JOIN GVCDTIPI_AUTORIZZAZIONE TA ");
            sql.Append("ON A.IDOBJ_TIPO = TA.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateLiquidazioniLiquidazioniCoatteGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("LC.IDOBJ, ");
            sql.Append("LC.DATA_DOMANDA, ");
            sql.Append("LC.PERCENTUALE_CONTRIBUTO, ");
            sql.Append("LC.VALUTA, ");
            sql.Append("LC.IMPORTO_DETERMINATO, ");
            sql.Append("LC.IMPORTO_RICHIESTO, ");
            sql.Append("LC.IMPORTO_CONTRIBUTO, ");
            sql.Append("LC.IMPORTO_SPESE, ");
            sql.Append("LC.TIPO_CONTRIBUTO, ");
            sql.Append("LC.NUMERO_DETERMINA, ");
            sql.Append("LC.DATA_DETERMINA, ");
            sql.Append("LC.LIQUIDATO, ");
            sql.Append("LC.NUMERO_MANDATO, ");
            sql.Append("LC.DATA_MANDATO, ");
            sql.Append("LC.NOTE, ");
            sql.Append("LC.IDOBJ_LIQUIDAZIONE ");
            sql.Append("FROM GVCTLIQUIDAZIONE_COMPENSI LC ");
            sql.Append("LEFT JOIN GVCTLIQUIDAZIONI_COATTE L ");
            sql.Append("ON LC.IDOBJ_LIQUIDAZIONE = L.IDOBJ ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON L.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCancellazioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("C.IDOBJ, ");
            sql.Append("C.IDOBJ_REGISTRO, ");
            sql.Append("C.TIPO, ");
            sql.Append("C.DATA_DOMANDA, ");
            sql.Append("C.NUMERO_DETERMINA, ");
            sql.Append("C.DATA_DETERMINA, ");
            sql.Append("C.NUMERO_DELIBERA, ");
            sql.Append("C.DATA_DELIBERA, ");
            sql.Append("C.NOTE, ");
            sql.Append("C.DATA_CANC_REGISTRO, ");
            sql.Append("C.DATA_CANC_ALBO ");
            sql.Append("FROM GVCTCANCELLAZIONI C ");
            sql.Append("LEFT JOIN GVCTREGISTRI R ");
            sql.Append("ON C.IDOBJ_REGISTRO = R.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual DataTable MapRecordsSoggettiToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateSoggettiDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateSoggettiDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Soggetti";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("TIPO_SOGGETTO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_ASSOCIAZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_PF", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DENOMINAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_FISCALE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsIndirizziToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateIndirizziDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateIndirizziDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Indirizzi";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("FLAG_PRINCIPALE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_SEDE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VIA", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_SOGGETTO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_TIPO_INDIRIZZO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_INDIRIZZO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CIVICO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CAP", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PROVINCIA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COMUNE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FRAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("STATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_STRADARIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TELEFONO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FAX", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ALTRO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_INIZIO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("EMAIL", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("WEBPAGE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsRegistriToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateRegistriDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateRegistriDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Registri";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("IDOBJ_SOGGETTO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_REA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_RI", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_ALBO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FORMA_GIURIDICA_CCIAA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_COSTITUZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DURATA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DURATA_ILLIMITATA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("BILANCIO_ESERCIZIO_AL", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("GRUPPO_PARITETICO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_BFL", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DEPOSITO_BFL", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_SCIOGLIMENTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ESENTE_VERSAMENTO_UTILI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_VERSAMENTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_OPERATORE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_UFFICIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("STATO_ISCRIZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_COSTITUZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_NOTAIO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FORMA_AMMINISTRATIVA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FORMA_GIURIDICA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CADENZA_REVISIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_COOPERATIVA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_REPERTORIO_NOTAIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FORMA_AMM_CCIAA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ACQUISIZIONE_ATTO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DEPOSITO_ATTO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_ESAME", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ESAME", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsCambioPosizioneToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateCambioPosizioneDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateCambioPosizioneDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "CambioPosizione";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_DOMANDA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SEZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOTTOSEZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CATEGORIA_SOCIALE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_POSIZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CATEGORIA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOTTOCATEGORIA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsAdesioniToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateAdesioniDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateAdesioniDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Adesioni";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_INIZIO_ADESIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("REVISORE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ASSOCIAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ESAME_INIZIO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_FINE_ADESIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ESAME_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsBilanciToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateBilanciDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateBilanciDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Bilanci";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("ANNO_RIFERIMENTO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_BILANCIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_RIFERIMENTO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DEPOSITO_RI", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_SEGNALAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("REQUISITO_PREVALENZA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_PERCENTO_UTILI", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_PATRIMONIO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VERIFICA_PAGAMENTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsComunicazioneCaricaSocialToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateComunicazioneCaricaSocialDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateComunicazioneCaricaSocialDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "ComunicazioneCaricaSocial";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_SITUAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_COMUNICAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ANTIMAFIA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PROTOCOLLO_ANTIMAFIA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsCaricheSocialiToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateCaricheSocialiDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateCaricheSocialiDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "CaricheSociali";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("FLAG_LEGALE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_LIQUIDATORE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ANTIMAFIA", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ANTIMAFIA_ARRIVATA", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_COMUNICAZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOCIO_GCS", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ANTIMAFIA_PRODOTTA", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_CARICA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_INIZIO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsComunicazioneBaseSocialeToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateComunicazioneBaseSocialeDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateComunicazioneBaseSocialeDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "ComunicazioneBaseSociale";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_COMUNICAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_SITUAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOCI_COOPERATORI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOCI_SOVVENTORI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ALTRI_SOCI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LAVORATORI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LAVORATORI_SOCI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LAVORATORI_REMUNERATI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOCI_UTENTI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOCI_VOLONTARI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SOCI_PG", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LAVORATORI_TUTTI", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERSONE_SVANTAGGIATE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CONFERIMENTO_CAPITALE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALORE_QUOTE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALORE_AZIONE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CAPITALE_SOTTOSCRITTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CAPITALE_VERSATO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsAssembleeToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateAssembleeDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateAssembleeDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Assemblee";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_ASSEMBLEA", typeof(System.DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_ASSEMBLEA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CONTENUTO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ISCRIZIONE_RI", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_ESAME", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ESAME", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_EVASIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTAIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsModificheStatutarieToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateModificheStatutarieDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateModificheStatutarieDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "ModificheStatutarie";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_INIZIO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_MODIFICA", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_ASSEMBLEA", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VECCHIA_DENOMINAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUOVA_DENOMINAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VECCHIA_FG", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUOVA_FG", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUOVA_DURATA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUOVA_ILLIMITATA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VECCHIO_BILANCIO_AL", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUOVO_BILANCIO_AL", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ATTO_FUSIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ISCRIZIONE_ATTO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_EFFICACIA_ATTO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VECCHIO_STATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUOVO_STATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTAIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsRevisioniToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateRevisioniDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateRevisioniDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Revisioni";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("ANNO_REVISIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_REVISIONE", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_CONCLUSIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DEPOSITO_RELAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_ESAME", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_ESAME", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA_ESAME", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA_ESAME", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_COMUNICAZIONE_ESITI", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_REVOCA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_REVOCA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA_REVOCA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA_REVOCA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ORGANO_REVISORE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ESITO_REVISIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsIncarichiToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateIncarichiDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateIncarichiDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Incarichi";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("IDOBJ_REVISIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_INCARICO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_INCARICO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA_INCARICO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA_INCARICO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_SCADENZA_TEORICA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPEGNO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_RICUSAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_RICUSAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA_RICUSAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA_RICUSAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsCompensiIncarichiToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateCompensiIncarichiDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateCompensiIncarichiDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "CompensiIncarichi";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("SOGGETTO", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_CNP", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_IVA", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALUTA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COMPENSO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SPESE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CASSA", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IVA", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TOTALE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_INCARICO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_CONTRIBUTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsLiquidazioniRevisioniToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateLiquidazioniRevisioniDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateLiquidazioniRevisioniDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "LiquidazioniRevisioni";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_DOMANDA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_CONTRIBUTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALUTA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_DETERMINATO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_RICHIESTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_CONTRIBUTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_SPESE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_CONTRIBUTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LIQUIDATO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_MANDATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_MANDATO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REVISIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsFallimentariToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateFallimentariDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateFallimentariDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Fallimentari";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_SENTENZA", typeof(System.DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ESITO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TRIBUNALE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CURATORE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsProcedureCoatteToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateProcedureCoatteDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateProcedureCoatteDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "ProcedureCoatte";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("TIPO_PROCEDURA", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_INIZIO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ISCRIZIONE_RI", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_SCADENZA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_CONCLUSIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_FINE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA_FINE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsCompensiProcedureCoatteToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateCompensiProcedureCoatteDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateCompensiProcedureCoatteDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "CompensiProcedureCoatte";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("SOGGETTO", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_CNP", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_IVA", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALUTA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COMPENSO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SPESE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CASSA", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IVA", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TOTALE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_PROCEDURA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_CONTRIBUTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsLiquidazioniProcedureCoatteToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateLiquidazioniProcedureCoatteDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateLiquidazioniProcedureCoatteDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "LiquidazioniProcedureCoatte";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_DOMANDA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_CONTRIBUTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALUTA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_DETERMINATO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_RICHIESTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_CONTRIBUTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_SPESE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_CONTRIBUTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LIQUIDATO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_MANDATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_MANDATO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_PROCEDURA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsLiquidazioniCoatteToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateLiquidazioniCoatteDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateLiquidazioniCoatteDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "LiquidazioniCoatte";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("TIPO_LIQUIDAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_GIUNTA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_GIUNTA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_PUBBLICAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DEPOSITO_RI", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_INSOLVENZA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_UFFICIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DEPOSITO_BFL", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PROCEDURA_REVOCATA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA_REVOCA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA_REVOCA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA_REVOCA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA_REVOCA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PROCEDURA_CONCLUSA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsRelazioniSemestraliToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateRelazioniSemestraliDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateRelazioniSemestraliDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "RelazioniSemestrali";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_RELAZIONE", typeof(System.DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_LIQUIDAZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_PARERE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ESAME", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsAutorizzazioniToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateAutorizzazioniDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateAutorizzazioniDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Autorizzazioni";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("IDOBJ_LIQUIDAZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_AUTORIZZAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DESCRIZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_ISTANZA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsLiquidazioniLiquidazioniCoatteToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateLiquidazioniLiquidazioniCoatteDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateLiquidazioniLiquidazioniCoatteDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "LiquidazioniLiquidazioniCoatte";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("DATA_DOMANDA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PERCENTUALE_CONTRIBUTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VALUTA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_DETERMINATO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_RICHIESTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_CONTRIBUTO", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IMPORTO_SPESE", typeof(System.Double));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_CONTRIBUTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LIQUIDATO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_MANDATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_MANDATO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_LIQUIDAZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

        protected virtual DataTable MapRecordsCancellazioniToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateCancellazioniDataTable();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateCancellazioniDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Cancellazioni";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DOMANDA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DETERMINA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DELIBERA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_CANC_REGISTRO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_CANC_ALBO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }

    }
}

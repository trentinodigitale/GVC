using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Client.Forms
{
    public static partial class StaticClassTemp
    {

        public static EsitoRevisioneFDT[] GetListRevisionOutcomeTypes()
        {
            string[] types = new string[] { "Diffida",
                                            "Prescrizione",
                                            "Provvedimento",
                                            "Regolare"};
            List<EsitoRevisioneFDT> list = new List<EsitoRevisioneFDT>();
            EsitoRevisioneFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new EsitoRevisioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static IndirizzoFDT GetAddress()
        {
            IndirizzoFDT item = new IndirizzoFDT();
            item.IdIndirizzo = 1;
            item.IdTipoIndirizzo = 1;
            item.IdSoggetto = 1;
            item.Note = "note";
            item.Altro = "altre indicazioni";
            item.Telefono = "0461239806";
            item.Cap = "38100";
            item.Principale = true;
            item.Provincia = "TN";
            item.Via = "via Canestrini";
            item.CodiceStradario = "022205";
            item.UrlPage = "www.cooperativamuratori.it";
            item.DataInizio = DateTime.Now;
            item.Comune = "Trento";
            item.NumeroCivico = "5";
            item.Email = "muratori@cooperativa.it";
            item.DataFine = DateTime.MinValue;
            item.Fax = "";
            item.Frazione = "";

            return item;
        }

        public static TipoIndirizzoFDT[] GetAddressTypes()
        {
            string[] types = new string[] { "Recapito",
                                            "Sede legale",
                                            "Sede amministrativa",
                                            "Studio",
                                            "Domicilio",
                                            "Sede liquidazione",
                                            "Sede lavoro",
                                            "Sede secondaria",
                                            "Residenza"};
            List<TipoIndirizzoFDT> listAddrTypes = new List<TipoIndirizzoFDT>();
            TipoIndirizzoFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoIndirizzoFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                listAddrTypes.Add(item);
            }
            return listAddrTypes.ToArray();
        }

        public static TipoCaricaSocialeFDT[] GetListSocialPositionsTypes()
        {
            string[] types = new string[] { "Presidente C.D.A.",
                                            "Vice Presidente C.D.A.",
                                            "Presidente assemblea",
                                            "Consigliere",
                                            "Socio",
                                            "Direttore",
                                            "Presidente collegio sindacale",
                                            "Sindaco effettivo",
                                            "Sindaco supplente",
                                            "Liquidatore",
                                            "Amministratore unico"};
            List<TipoCaricaSocialeFDT> listSocPositions = new List<TipoCaricaSocialeFDT>();
            TipoCaricaSocialeFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoCaricaSocialeFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];
                item.Attiva = (i % 2 == 0) ? true : false;
                item.Anti_Mafia = false;

                listSocPositions.Add(item);
            }
            return listSocPositions.ToArray();
        }

        public static TipoAttivitaFDT[] GetListActivityTypes()
        {
            string[] types = new string[] { "Altre attività di servizi",
                                            "Attività di organizzazioni associative",
                                            "Attività di organizzazioni economiche, di datori di lavoro e professionali",
                                            "Attività di organizzazioni economiche e di datori di lavoro",
                                            "Edilizia (costruzioni edifici)",
                                            "Lavori generali di costruzione di edifici"};

            string[] typesCode = new string[] { "S",
                                                "94",
                                                "94.1",
                                                "94.11",
                                                "45210",
                                                "45211"};

            List<TipoAttivitaFDT> list = new List<TipoAttivitaFDT>();

            for (int i = 0; i < types.Length; i++)
            {
                TipoAttivitaFDT item = new TipoAttivitaFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];
                item.Codice = typesCode[i];

                list.Add(item);
            }

            return list.ToArray();
        }

        public static CategoriaFDT[] GetListCategories()
        {
            string[] desc = new string[] { "Agricole",
                                            "Cooperative di produzione",
                                            "Cooperative di lavoro agricolo",
                                            "Cooperative sociali",
                                            "Cooperative di conferimento prodotti agricoli e allevamento",
                                            "Cooperative edilizie di abitazione"};

            string[] oldCode = new string[] {   "A",
                                                "PR",
                                                "LA",
                                                "SO",
                                                "PA",
                                                "ED"};

            string[] newCode = new string[] {   "",
                                                "CPR",
                                                "CLA",
                                                "",
                                                "CCP",
                                                "CED"};

            List<CategoriaFDT> list = new List<CategoriaFDT>();

            for (int i = 0; i < newCode.Length; i++)
            {
                CategoriaFDT item = new CategoriaFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.GSCCode = oldCode[i];
                item.CodiceNuovo = newCode[i];
                item.Attiva = true;

                list.Add(item);
            }

            return list.ToArray();
        }

        public static CategoriaSocialeFDT[] GetListSocialCategories()
        {
            string[] desc = new string[] { "Sociale"};
            List<CategoriaSocialeFDT> list = new List<CategoriaSocialeFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                CategoriaSocialeFDT item = new CategoriaSocialeFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = true;

                list.Add(item);
            }

            return list.ToArray();
        }

        public static SottoCategoriaSocialeFDT[] GetListSocialSubCategories()
        {
            string[] desc = new string[] { "Gestione servizi socio sanitari",
                                            "Inserimento lavorativo",
                                            "Consorzi",
                                            "Cooperative di solidarietà sociale"};
            List<SottoCategoriaSocialeFDT> list = new List<SottoCategoriaSocialeFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                SottoCategoriaSocialeFDT item = new SottoCategoriaSocialeFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = true;

                list.Add(item);
            }

            return list.ToArray();
        }

        public static StatoCooperativaFDT[] GetListStatus()
        {
            string[] desc = new string[] { "Normale",
                                            "Fallimento",
                                            "In fallimento",
                                            "Liquidazione coatta",
                                            "Liquidazione coatta amm.",
                                            "Scioglimento volontario",
                                            "Scioglimento per scissione",
                                            "Incorporata per fusione",
                                            "Cessata per incorporazione",
                                            "Trasferimento fuori provincia",
                                            "Trasformazione in altra forma giuridica"};

            bool[] actives = new bool[] { true,
                                            false,
                                            true,
                                            true,
                                            true,
                                            true,
                                            true,
                                            false,
                                            true,
                                            true,
                                            true
                                            };

            bool[] actives1 = new bool[] { true,
                                            false,
                                            false,
                                            false,
                                            false,
                                            true,
                                            false,
                                            false,
                                            false,
                                            false,
                                            false
                                            };

            List<StatoCooperativaFDT> list = new List<StatoCooperativaFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                StatoCooperativaFDT item = new StatoCooperativaFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = actives[i];
                item.SoggettaRevisione = actives1[i];

                list.Add(item);
            }

            return list.ToArray();
        }

        public static FormaGiuridicaFDT[] GetListJuridicalForms()
        {
            string[] desc = new string[] { "Banca popolare",
                                            "Consorzio",
                                            "Cooperativa",
                                            "Ente mutualistico",
                                            "Recuperato",
                                            "Piccola",
                                            "Società mutuo soccorso",
                                            "Cooperativa SPA",
                                            "Cooperativa SRL",
                                            "Confidi",
                                            "Consorzio agrario",
                                            "Società cooperativa europea"};

            bool[] actives = new bool[] { false,
                                            true,
                                            false,
                                            true,
                                            false,
                                            false,
                                            true,
                                            true,
                                            true,
                                            true,
                                            true,
                                            true
                                            };

            List<FormaGiuridicaFDT> list = new List<FormaGiuridicaFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                FormaGiuridicaFDT item = new FormaGiuridicaFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = actives[i];

                list.Add(item);
            }

            return list.ToArray();
        }

        public static TipoCostituzioneFDT[] GetListConstitutionTypes()
        {
            string[] desc = new string[] { "Fusione",
                                            "Normale",
                                            "Scissione",
                                            "Trasferimento",
                                            "Trasferimento in provincia"};

            bool[] actives = new bool[] { true,
                                            true,
                                            true,
                                            false,
                                            true
                                            };

            List<TipoCostituzioneFDT> list = new List<TipoCostituzioneFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                TipoCostituzioneFDT item = new TipoCostituzioneFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = actives[i];

                list.Add(item);
            }

            return list.ToArray();
        }

        public static TipoRevisioneFDT[] GetListRevisionTypes()
        {
            string[] desc = new string[] { "Annuale",
                                            "Biennale",
                                            "Straordinaria",
                                            "Biennale ordinaria",
                                            "Biennale straordinaria"};

            bool[] actives = new bool[] { false,
                                            false,
                                            false,
                                            true,
                                            true
                                            };

            List<TipoRevisioneFDT> list = new List<TipoRevisioneFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                TipoRevisioneFDT item = new TipoRevisioneFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = actives[i];

                list.Add(item);
            }

            return list.ToArray();
        }

        public static CadenzaRevisioneFDT[] GetListRevisionCadences()
        {
            string[] desc = new string[] { "Annuale",
                                            "Annuale e certificazione",
                                            "Biennale ordinaria",
                                            "Biennale con certificazione"};

            bool[] actives = new bool[] { false,
                                            false,
                                            true,
                                            true
                                            };

            int[] freq = new int[] {        1,
                                            1,
                                            2,
                                            2,};

            List<CadenzaRevisioneFDT> list = new List<CadenzaRevisioneFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                CadenzaRevisioneFDT item = new CadenzaRevisioneFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                item.Attiva = actives[i];
                item.Frequenza = freq[i];

                list.Add(item);
            }

            return list.ToArray();
        }

        public static ComunicazioneCaricaSocialeFDT[] GetListCommunicationsSocialPositions()
        {
            List<ComunicazioneCaricaSocialeFDT> list = new List<ComunicazioneCaricaSocialeFDT>();

            for (int i = 0; i < 1; i++)
            {
                ComunicazioneCaricaSocialeFDT item = new ComunicazioneCaricaSocialeFDT();
                item.IdComunicazioneCaricaSociale = i;

                item.DataComunicazioneAntimafia = new DateTime(1999, 11, 15);
                item.NumeroProtocolloAntimafia = "3470";

                item.DataComunicazione = new DateTime(1999, 12, 30);
                item.DataSituazione = new DateTime(1999, 12, 30);

                //item.Note = "note tmp (" + i.ToString() + ")";

                item.Cariche = GetListSocialPositions(i);

                item.Documentazioni = GetListDocumentationForComunications();

                list.Add(item);
            }

            return list.ToArray();
        }

        public static TipoSoggettoFDT[] GetListSubjectType()
        {
            string[] desc = new string[] { "Cooperativa",
                                            "Notaio",
                                            "Tribunale"};

            List<TipoSoggettoFDT> list = new List<TipoSoggettoFDT>();

            for (int i = 0; i < desc.Length; i++)
            {
                TipoSoggettoFDT item = new TipoSoggettoFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];
                
                list.Add(item);
            }

            return list.ToArray();
        }

        public static PersonaFisicaFDT GetPeople(int index, int commSocial)
        {
            PersonaFisicaFDT item = new PersonaFisicaFDT();

            item.IdSoggetto = index;
            item.IdTipoSoggetto = 2 - index;

            switch (index)
            {
                case 0:
                    item.Nome = "Ermano_" + commSocial.ToString();
                    item.Cognome = "Valentinelli";
                    item.CodiceFiscale = "RMNVLN847743974";
                    break;
                case 1:
                    item.Nome = "Manuel_" + commSocial.ToString();
                    item.Cognome = "Borile";
                    item.CodiceFiscale = "BRLMNL82T05A952N";
                    break;
                case 2:
                    item.Nome = "Gloria_" + commSocial.ToString();
                    item.Cognome = "Santi";
                    item.CodiceFiscale = "SNT8DH8TUT8HGTIH";
                    break;
                default:
                    item.Nome = "Mario";
                    item.Cognome = "Stelzer";
                    item.CodiceFiscale = "RMNVLN847743974";
                    break;
            }

            if (index == 5)
            {
                item.Indirizzi = new IndirizzoFDT[] { GetAddress() };
            }

            //item.CognomeAcquisito;
            //item.Associazione;
            //item.ComuneNascita;
            //item.DataNascita;
            //item.StatoNascita;
            //item.Cellulare;
            //item.Cittadinanza;
            //item.StatoCivile;
            //item.Sesso;
         
            return item;
        }

        public static CaricaSocialeFDT[] GetListSocialPositions(int commSocial)
        {
            List<CaricaSocialeFDT> list = new List<CaricaSocialeFDT>();

            string[] desc = new string[] { 
                "Passardi Silvano",
                "Facchin Agostino",
                "Pauletto Angelo",
                "Poletti Donato",
                "Primolan Domenico"
            };

            int[] pos = new int[] { 0, 3, 3, 3, 3 };

            for (int i = 0; i < desc.Length; i++)
            {
                CaricaSocialeFDT item = new CaricaSocialeFDT();
                item.IdCarica = i + commSocial;
                //item.IdTipoCarica = pos[i];

                item.LegaleRappresentante = (i == 0) ? true : false;
                item.Liquidatore = false;

                //item.PersonaFisica = GetPeople(i, commSocial);
                item.DescrizioneGSC = desc[i];

                item.RichiestaAntimafiaArrivata = true;
                item.RichiestaAntimafiaProdotta = true;
                item.RichiestaAntimafia = true;

                list.Add(item);
            }

            return list.ToArray();
        }


        public static DizionarioFDT[] GetListDocumentationTypes()
        {
            List<DizionarioFDT> list = new List<DizionarioFDT>();

            DizionarioFDT item = new DizionarioFDT();
            item.IdElemento = 1;
            item.Descrizione = "Verbale di revisione";
            list.Add(item);

            item = new DizionarioFDT();
            item.IdElemento = 2;
            item.Descrizione = "Parere commissione";
            list.Add(item);

            item = new DizionarioFDT();
            item.IdElemento = 3;
            item.Descrizione = "Determina iscrizione";
            list.Add(item);

            item = new DizionarioFDT();
            item.IdElemento = 4;
            item.Descrizione = "Certificazione antimafia";
            list.Add(item);

            item = new DizionarioFDT();
            item.IdElemento = 5;
            item.Descrizione = "Certificazione iscrizione";
            list.Add(item);

            return list.ToArray();
        }


        public static DizionarioFDT[] GetListSections()
        {
            List<DizionarioFDT> list = new List<DizionarioFDT>();

            DizionarioFDT item = new DizionarioFDT();
            item.IdElemento = 1;
            item.Descrizione = "PREVALENTE";
            list.Add(item);

            item = new DizionarioFDT();
            item.IdElemento = 2;
            item.Descrizione = "DIVERSE";
            list.Add(item);

            item = new DizionarioFDT();
            item.IdElemento = 3;
            item.Descrizione = "MUTUO SOCCORSO";
            list.Add(item);

            return list.ToArray();
        }

        public static DizionarioFDT[] GetListSubSections(int section)
        {
            List<DizionarioFDT> list = new List<DizionarioFDT>();

            if (section == 1)
            {
                DizionarioFDT item = new DizionarioFDT();
                item.IdElemento = 1;
                item.Descrizione = "Sempre (di diritto)";
                list.Add(item);

                item = new DizionarioFDT();
                item.IdElemento = 2;
                item.Descrizione = "A verifica annuale";
                list.Add(item);
            }
            else
            {
                DizionarioFDT item = new DizionarioFDT();
                item.IdElemento = 3;
                item.Descrizione = "Non prevalente";
                list.Add(item);

                item = new DizionarioFDT();
                item.IdElemento = 4;
                item.Descrizione = "Non soggette";
                list.Add(item);
            }
            return list.ToArray();
        }

        public static CooperativaFDT GetCooperativeFDT()
        {
            CooperativaFDT item = new CooperativaFDT();

            item.Denominazione = "COOPERATIVA MURATORI TRIDENTINI Piccola Società Cooperativa a Responsabilità Limitata - (in L.C.A.)";
            item.Associazione = false;
            item.CodiceFiscale = "00384470225";

            item.Indirizzi = new IndirizzoFDT[] { GetAddress() };
            item.RegistroCooperativa = GetCooperativeRegistryFDT();

            return item;
        }

        public static RegistroCooperativaFDT GetCooperativeRegistryFDT()
        {
            RegistroCooperativaFDT item = new RegistroCooperativaFDT();

            item.IdFormaAmm = 1;
            //item.BilancioEsercizioAl = "31.12";
            //item.Categoria = "CPR";
            item.NumeroREA = "91434";
            item.IdTipoCostituzione = 1;

            item.DataCostituzione = new DateTime(1978, 01, 23);
            item.Durata = new DateTime(2050, 12, 31);
            //item.UndeterminedEnd = false;
            item.DurataIllimitata = 1;

            //item.IdCadenzaRevisione = 2;
            item.CodiceCooperativa = 1101;
            //item.DataDeliberaCommissione;
            //item.NumeroDeliberaCommissione;
            //item.DataDetermina = new DateTime(1978, 3, 30);
            //item.NumeroDetermina = "445";
            //item.ProcessoChiuso = true;

            //item.FormaGiuridica = "5";
            item.FormaGiuridicaParix = "PICCOLA SOCIETA' COOPERATIVA A RESPONSABILITA' LIMITATA";
            //item.NumeroIscrizioneAlboNaz = 100;

            item.NumeroRepertorioNotarile = "24528";
            item.Notaio = GetPeople(5, 1);
            //item.ProcessTime = 60;
            //item.RegistrationOfficeProcessDate = new DateTime(1798, 1, 10);
            item.IdStatoIscrizione = 4;
            //item.DataRicevimentoDomanda = new DateTime(1798, 1, 10);

            //item.Sezione = 1;
            //item.SottoSezione = 1;

            //item.CategoriaSociale = 1;
            //item.IdSottoCategoriaSociale = -1;

            //item.DataFineProcessoTeorica = new DateTime(1798, 1, 10).AddDays(60);
            item.NumeroScioglimento = 1843;

            item.Documentazioni = GetListDocumentationGeneral();
            item.Revisioni = GetListRevisions();
            item.Assemblee = GetListMeetingDeliberations();
            item.Adesioni = GetListAdhesion();
            item.ComunicazioniPosizioneCaricaSociale = GetListCommunicationsSocialPositions();
            item.ComunicazioniBaseSociale = GetListSocialBase();
            item.Attivita = GetListActivities();
            item.AttivitaParix = GetListActivitiesParix();
            //item.BudgetDeposits = GetListBudgetDeposits();
            item.ProcedureFallimentari = GetListFailureProcedures();
            item.LiquidazioniCoatte = GetListForcedLiquidations();
            item.ProcedureCoatte = GetListForcedProcedures();
            //item.MutualPayments = GetListMutualPayments();
            //item.MutualRequirements = GetListMutualRequirements();
            //item.CambioPosizioni = GetListPositionChanges();
            item.ScadenzaAnnotazioni = GetListRemarkExpirations();
            //item.ResidualPayments = GetListResidualPayments();
            //item.Indirizzi = new IndirizzoFDT[]{GetAddress()};

            return item;
        }

        public static DocumentazioneFDT[] GetListDocumentationGeneral()
        {
            List<DocumentazioneFDT> toReturn = new List<DocumentazioneFDT>();

            DocumentazioneFDT d = new DocumentazioneFDT();
            d.DataDocumento = new DateTime(1978, 3, 30);
            d.IdDocumentazione = 1;
            d.IdTipoDocumentazione = 5;
            d.Note = "";
            d.NumeroProtocollo = "0001000";
            d.Titolo = "Iscrizione all'albo delle cooperative";
            if (System.Diagnostics.Debugger.IsAttached)
            {
                d.NomeFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Attachments\\CERTNORM.pdf");
            }
            toReturn.Add(d);

            return toReturn.ToArray();
        }

        public static DocumentazioneFDT[] GetListDocumentationForComunications()
        {
            List<DocumentazioneFDT> toReturn = new List<DocumentazioneFDT>();

            DocumentazioneFDT d = new DocumentazioneFDT();
            d.DataDocumento = DateTime.Now;
            d.IdDocumentazione = 1;
            d.IdTipoDocumentazione = 4;
            d.Note = "";
            d.NumeroProtocollo = "012200";
            d.Titolo = "Certificazione antimafia";
            d.NomeFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Attachments\\CertificazioneAntimafia.mht");

            toReturn.Add(d);

            for (int i = 0; i < 2; i++)
            {
                d = new DocumentazioneFDT();
                d.DataDocumento = DateTime.Now;
                d.IdDocumentazione = i;
                d.IdTipoDocumentazione = i + 1;
                d.Note = "note documentazione " + i.ToString(); ;
                d.NumeroProtocollo = "000" + i.ToString() + "00";
                d.Titolo = "titolo " + " " + i.ToString();

                toReturn.Add(d);
            }

            return toReturn.ToArray();
        }

        public static DocumentazioneFDT[] GetListDocumentation(string from)
        {
            List<DocumentazioneFDT> toReturn = new List<DocumentazioneFDT>();

            for (int i = 0; i < 2; i++)
            {
                DocumentazioneFDT d = new DocumentazioneFDT();
                d.DataDocumento = DateTime.Now;
                d.IdDocumentazione = i;
                d.IdTipoDocumentazione = i + 1;
                d.Note = "note documentazione " + i.ToString();
                d.NumeroProtocollo = "000" + i.ToString() + "00";
                d.Titolo = "Documentazione " + from + " " + i.ToString();

                toReturn.Add(d);
            }

            toReturn[0].NomeFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Attachments\\CertificazioneAntimafia.mht");

            return toReturn.ToArray();
        }

        public static AdesioneFDT[] GetListAdhesion()
        {
            List<AdesioneFDT> toReturn = new List<AdesioneFDT>();


            AdesioneFDT a = new AdesioneFDT();

            PersonaFisicaFDT p = new PersonaFisicaFDT();
            p.Nome = "FEDERAZIONE TRENTINA DELLA COOPERAZIONE";
            p.Cognome = "";
            //a.Associazione = p;

            a.DataInizio = new DateTime(1978, 1, 23);
            a.DataFine = new DateTime(1978, 09, 19);

            //a.DataInzioEsameCommissione = new DateTime(2008, 10, 31 - i);
            //a.DataFineEsameCommissione = new DateTime(2008, 11, 23 - i);

            a.IdAdesione = 1;
            a.Revisore = false;
            //a.Note = "Note adesione";

            a.Documentazioni = GetListDocumentation("adesione_" + 1.ToString());
            toReturn.Add(a);

            a = new AdesioneFDT();

            CooperativaFDT p2 = new CooperativaFDT();
            p2.Denominazione = "FEDERAZIONE TRENTINA DELLA COOPERAZIONE";
            //a.Associazione = p2;

            a.DataInizio = new DateTime(2001, 1, 20);
            a.DataUltimaModifica = new DateTime(2004, 11, 30);

            //a.DataInzioEsameCommissione = new DateTime(2008, 10, 31 - i);
            //a.DataFineEsameCommissione = new DateTime(2008, 11, 23 - i);

            a.IdAdesione = 2;
            a.Revisore = false;
            a.Note = "Note adesione";

            a.Documentazioni = GetListDocumentation("adesione_" + 2.ToString());

            toReturn.Add(a);


            return toReturn.ToArray();
        }

        public static FormaAmministrativaFDT[] GetListAdministrativeForm()
        {
            FormaAmministrativaFDT item = new FormaAmministrativaFDT();
            item.IdElemento = 1;
            item.Descrizione = "Consiglio di amministrazione";

            return new FormaAmministrativaFDT[] { item };
        }

        public static TipoScadenzaFDT[] GetListExpirationTypes()
        {
            string[] types = new string[] { "Anagrafica",
                                            "Adesioni",
                                            "Revisioni",
                                            "Comunicazioni cariche sociali",
                                            "Comunicazioni quote",
                                            "Cambio categoria",
                                            "Certificazioni",
                                            "Procedure coatte",
                                            "Liquidazioni coatte",
                                            "Assemblea modifiche statutarie"};
            List<TipoScadenzaFDT> list = new List<TipoScadenzaFDT>();
            TipoScadenzaFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoScadenzaFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static TipoProceduraCoattaFDT[] GetListForcedProcedureTypes()
        {
            string[] types = new string[] { "Cancellazione sanzionatoria",
                                            "Commissariamento",
                                            "Diffida formale",
                                            "Sostituzione liquidatore",
                                            "Tutoraggio",
                                            "Sanzioni amministrative",
                                            "Cancellazione RI 2545/18 cc"};
            List<TipoProceduraCoattaFDT> list = new List<TipoProceduraCoattaFDT>();
            TipoProceduraCoattaFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoProceduraCoattaFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];
                item.Attiva = true;

                list.Add(item);
            }
            return list.ToArray();
        }

        public static TipoLiquidazioneCoattaFDT[] GetListForcedLiquidationTypes()
        {
            string[] types = new string[] { "Liquidazione coatta",
                                            "Liquidazione coatta amministrative"};
            List<TipoLiquidazioneCoattaFDT> list = new List<TipoLiquidazioneCoattaFDT>();
            TipoLiquidazioneCoattaFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoLiquidazioneCoattaFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static ProceduraCoattaFDT[] GetListForcedProcedures()
        {
            List<ProceduraCoattaFDT> toReturn = new List<ProceduraCoattaFDT>();

            ProceduraCoattaFDT fp1 = new ProceduraCoattaFDT();
            fp1.IdProceduraCoatta = 1;
            fp1.IdTipoProceduraCoatta = 2;
            //fp1.ProcessoChiuso = false;
            //fp1.DurataProcessoUfficio = 60;
            //fp1.DataInizioProcesso = new DateTime(2003, 10, 22);
            fp1.DataInzioProcedura = new DateTime(2003, 10, 22);
            //fp1.DataFineProcedura
            fp1.DataScadenzaProcedura = new DateTime(2003, 3, 30);
            //fp1.DataInizioProcesso
            //fp1.DataFineProcessoTeorica = fp1.DataInizioProcesso.AddDays(60);
            fp1.DataDeliberaCommissione = new DateTime(2003, 10, 9);
            fp1.NumeroDeliberaCommissione = "385";
            //fp1.DataDetermina
            //fp1.NumeroDetermina
            //fp1.DataDeliberaCommissioneFineIncarico
            //fp1.NumeroDeliberaCommissioneFineIncarico
            //fp1.DataDeterminaFineIncarico
            //fp1.NumeroDeterminaFineIncarico
            fp1.CompensiCommissari = GetListCounterBalanceCommissionerFP(1).ToArray();
            fp1.Liquidazioni = GetListCounterBalanceLiqu(1);
       

            toReturn.Add(fp1);

            ProceduraCoattaFDT fp2 = new ProceduraCoattaFDT();
            fp2.IdProceduraCoatta = 2;
            fp2.IdTipoProceduraCoatta = 1;
            //fp2.ProcessoChiuso = true;
            //fp2.DurataProcessoUfficio = 60;
            //fp2.DataInizioProcesso = new DateTime(2001, 7, 9);
            fp2.DataInzioProcedura = new DateTime(2001, 7, 9);
            fp2.DataFineProcedura = new DateTime(2001, 12, 11);
            fp2.DataScadenzaProcedura = new DateTime(2003, 10, 9);
            //fp2.DataInizioProcesso
            ////fp2.DataFineProcessoTeorica = fp2.DataInizioProcesso.AddDays(60);
            fp2.DataDeliberaCommissione = new DateTime(2001, 6, 1);
            fp2.NumeroDeliberaCommissione = "121";
            //fp2.DataDetermina
            //fp2.NumeroDetermina
            //fp2.DataDeliberaCommissioneFineIncarico
            //fp2.NumeroDeliberaCommissioneFineIncarico
            //fp2.DataDeterminaFineIncarico
            //fp2.NumeroDeterminaFineIncarico
            fp1.CompensiCommissari = GetListCounterBalanceCommissionerFP(1).ToArray();
            fp1.Liquidazioni = GetListCounterBalanceLiqu(1);
         

            toReturn.Add(fp2);

            return toReturn.ToArray();
        }

        public static LiquidazioneCoattaFDT[] GetListForcedLiquidations()
        {
            List<LiquidazioneCoattaFDT> toReturn = new List<LiquidazioneCoattaFDT>();

            LiquidazioneCoattaFDT fl = new LiquidazioneCoattaFDT();
            fl.DepositoBFL = true;
            fl.DataDeliberaCommissione = new DateTime(2001, 6, 11);
            fl.NumeroDeliberaCommissione = "799";
            fl.DataDeliberaGiunta = new DateTime(2001, 6, 1);
            fl.NumeroDeliberaGiunta = "108";
            fl.DataDetermina = new DateTime(2001, 5, 1);
            //fl.NumeroDetermina
            //fl.DataPubblicazioneGU = new DateTime(2001, 6, 11);
            fl.IdLiquidazioneCoatta = 1;
            fl.IdTipoLiquidazioneCoatta = 1;
            fl.DataSentenzaInsolvenza = new DateTime(2002, 4, 23);
            fl.ProceduraTerminata = false;
            fl.ProceduraRevocata = false;
            //fl.ProcessoChiuso = false;
            //fl.CodiceUfficio
            //fl.DurataProcessoUfficio
            //fl.DataInizioProcesso = new DateTime(2001, 3, 1);
            //fl.CompensiCommissari = GetListCounterBalanceCommissionerFL(1);
            fl.RelazioniSemestrali = GetListSixMonthReports(String.Empty);
            fl.Liquidazioni = GetListCounterBalanceLiqu(1);
            fl.Autorizzazioni = GetListAuthorizations(String.Empty);
          
            toReturn.Add(fl);

            return toReturn.ToArray();
        }

        private static List<CompensoFDT> GetListCounterBalanceCommissionerFP(int index)
        {
            List<CompensoFDT> toReturn = new List<CompensoFDT>();
            CompensoFDT c = new CompensoFDT();

            if (index == 1)
            {
                c.Valuta = 1;
                c.ImportoCompenso = 2626.54;

                PersonaFisicaFDT p = new PersonaFisicaFDT();
                p.Nome = "Maurizio";
                p.Cognome = "Scozzi";
                c.Revisore = p;
            }
            else
            {
                c.Valuta = 1;
                c.ImportoCompenso = 2 * 1000;

                PersonaFisicaFDT p = new PersonaFisicaFDT();
                p.Nome = "Massimo2";
                p.Cognome = "Degasperi2";
                c.Revisore = p;
            }

            toReturn.Add(c);

            return toReturn;
        }

        private static List<CompensoFDT> GetListCounterBalanceCommissionerFL(int index)
        {
            List<CompensoFDT> toReturn = new List<CompensoFDT>();
            CompensoFDT c = new CompensoFDT();

            if (index == 1)
            {
                c.Valuta = 1;
                c.ImportoCompenso = 1 * 1000;

                PersonaFisicaFDT p = new PersonaFisicaFDT();
                p.Nome = "Alessandro";
                p.Cognome = "Tonina";
                p.CodiceFiscale = "TNNLSN63C21L378W";
                p.Sesso = "M";
                c.Revisore = p;
            }
            else
            {
                c.Valuta = 1;
                c.ImportoCompenso = 2 * 1000;

                PersonaFisicaFDT p = new PersonaFisicaFDT();
                p.Nome = "Massimo";
                p.Cognome = "Degasperi";
                c.Revisore = p;
            }

            toReturn.Add(c);

            return toReturn;
        }

        private static CompensoLiquidazioneFDT[] GetListCounterBalanceLiqu(int index)
        {
            List<CompensoLiquidazioneFDT> toReturn = new List<CompensoLiquidazioneFDT>();

            CompensoLiquidazioneFDT c = new CompensoLiquidazioneFDT();

            if (index == 1)
            {
                //c.ImportoSpeseBFL;
                //c.TipoContributo;
                c.Valuta = 0;
                //c.DataDetermina;
                //c.NumeroDetermina;
                //c.ImportoDefinito;
                //c.IdCompensoLiquidazione;
                c.Liquidato = true;
                //c.ProcessoChiuso;
                //c.Note;
                //c.DataLiquidazioneUfficio = new DateTime(2002, 9, 1);
                //c.DurataProcessoUfficio = 60;
                c.ImportoErogato = 2700;
                //c.PercentualeContributoPAT;
                //c.DataMandatoPagamento;
                //c.NumeroMandatoPagamento;
                //c.ImportoRichiesto;
                //c.DataRicevimentoDomanda = new DateTime(2002, 7, 6);
            }
            else
            {
                //c.ImportoSpeseBFL;
                //c.TipoContributo;
                c.Valuta = 0;
                //c.DataDetermina;
                //c.NumeroDetermina;
                //c.ImportoDefinito;
                //c.IdCompensoLiquidazione;
                c.Liquidato = true;
                //c.ProcessoChiuso;
                //c.Note;
                //c.DataLiquidazioneUfficio = new DateTime(2002, 9, 1);
                //c.DurataProcessoUfficio = 60;
                c.ImportoErogato = 4500;
                //c.PercentualeContributoPAT;
                //c.DataMandatoPagamento;
                //c.NumeroMandatoPagamento;
                //c.ImportoRichiesto;
                //c.DataRicevimentoDomanda = new DateTime(2002, 7, 1);
            }

            toReturn.Add(c);

            return toReturn.ToArray();
        }

        //public static BudgetDepositFDT[] GetListBudgetDeposits()
        //{
        //    List<BudgetDepositFDT> toReturn = new List<BudgetDepositFDT>();

        //    BudgetDepositFDT item = new BudgetDepositFDT();
        //    item.IDBudgetDate = 1;
        //    item.DepositDate = new DateTime(2008, 4, 2);
        //    item.BudgetDate = new DateTime(2007, 12, 31);
        //    item.BudgetType = "Bilancio semestrale";
        //    item.Note = "note";

        //    toReturn.Add(item);

        //    return toReturn.ToArray();
        //}

        public static ProceduraFallimentareFDT[] GetListFailureProcedures()
        {
            List<ProceduraFallimentareFDT> toReturn = new List<ProceduraFallimentareFDT>();

            ProceduraFallimentareFDT item = new ProceduraFallimentareFDT();
            item.IdProceduraFallimentare = 1;
            item.DataSentenza = new DateTime(2008, 11, 1);
            //item.IdTribunale = 1;
            item.IdCuratore = 2;
            item.DataFineProcedura = new DateTime(2008, 11, 10);
            //item.Stato = 1; //Concluso

            PersonaFisicaFDT p = new PersonaFisicaFDT();
            p.Nome = "Manuel";
            p.Cognome = "Borile";

            PersonaFisicaFDT p1 = new PersonaFisicaFDT();
            p1.Nome = "Tribunale di Trento";
            p1.Cognome = "";

            //item.Tribunale = p1;
            item.Curatore = p;

            toReturn.Add(item);

            return toReturn.ToArray();
        }

        //public static MutualPaymentFDT[] GetListMutualPayments()
        //{
        //    List<MutualPaymentFDT> toReturn = new List<MutualPaymentFDT>();

        //    MutualPaymentFDT item = new MutualPaymentFDT();
        //    item.IDMutualPayment = 1;
        //    item.BudgetDate = new DateTime(2008, 02, 1);
        //    item.CurrencyAmount = "€";
        //    item.Amount = 19280;
        //    item.Note = "note";

        //    toReturn.Add(item);

        //    return toReturn.ToArray();
        //}

        //public static MutualRequirementFDT[] GetListMutualRequirements()
        //{
        //    List<MutualRequirementFDT> toReturn = new List<MutualRequirementFDT>();

        //    MutualRequirementFDT item = new MutualRequirementFDT();
        //    item.IDMutualRequirement = 1;
        //    item.ReferenceDate = new DateTime(2007, 1, 1);
        //    item.ReqirementFlag = 0;
        //    item.Note = "Note";

        //    toReturn.Add(item);

        //    return toReturn.ToArray();
        //}

        public static ScadenziarioFDT[] GetListRemarkExpirations()
        {
            List<ScadenziarioFDT> toReturn = new List<ScadenziarioFDT>();

            ScadenziarioFDT item = new ScadenziarioFDT();
            item.IdScadenziario = 1;
            item.DataAnnotazione = new DateTime(2008, 10, 1);
            item.IdTipoScadenziario = 1;
            //item.RiservataUfficio = 1;
            item.Descrizione = "Descrizione";
            //item.Evasa = 0;
            item.DataScadenza = new DateTime(2008, 11, 15);
            //item.DataEvasione
            
            toReturn.Add(item);

            return toReturn.ToArray();
        }

        //public static ResidualPaymentFDT[] GetListResidualPayments()
        //{
        //    List<ResidualPaymentFDT> toReturn = new List<ResidualPaymentFDT>();

        //    ResidualPaymentFDT item = new ResidualPaymentFDT();
        //    item.IDResidualPayment = 1;
        //    item.PaymentDate = new DateTime(2008, 11, 15);
        //    item.CurrencyAmount = "€";
        //    item.Amount = 1000;
        //    item.IDType = 0;
        //    item.Note = "note";

        //    toReturn.Add(item);

        //    return toReturn.ToArray();
        //}

        public static AutorizzazioneFDT[] GetListAuthorizations(string from)
        {
            List<AutorizzazioneFDT> toReturn = new List<AutorizzazioneFDT>();

            AutorizzazioneFDT item = new AutorizzazioneFDT();
            item.NumeroDeliberaCommissione = "125";
            item.DataDeliberaCommissione = new DateTime(2001, 7, 13);
            item.DataIstanza = new DateTime(2001, 6, 27);
            item.IdAutorizzazione = 1;
            item.DescrizioneDatoStorico = "Nomina terzi";
            item.Note = "legale";
            item.IdTipoAutorizzazione = 1;

            toReturn.Add(item);

            AutorizzazioneFDT item2 = new AutorizzazioneFDT();
            item2.NumeroDeliberaCommissione = "29";
            item2.DataDeliberaCommissione = new DateTime(2002, 3, 22);
            item2.DataIstanza = new DateTime(2002, 2, 18);
            item2.IdAutorizzazione = 2;
            item2.DescrizioneDatoStorico = "Arbitrato";
            item2.IdTipoAutorizzazione = 1;

            toReturn.Add(item2);

            return toReturn.ToArray();
        }

        public static RelazioneSemestraleFDT[] GetListSixMonthReports(string from)
        {
            List<RelazioneSemestraleFDT> toReturn = new List<RelazioneSemestraleFDT>();

            RelazioneSemestraleFDT item = new RelazioneSemestraleFDT();
            item.IdRelazioneSemestrale = 1;
            //item.DataRicevimentoRelazione = new DateTime(2002, 2, 05);
            item.DataEsitoCommissione = new DateTime(2002, 3, 22);
            //item.DurataProcessoUfficio = 60;
            //////item.DataFineTeorica = item.DataRicevimentoRelazione.AddDays(item.DurataProcessoUfficio);

            toReturn.Add(item);

            RelazioneSemestraleFDT item2 = new RelazioneSemestraleFDT();
            item2.IdRelazioneSemestrale = 2;
            //item2.DataRicevimentoRelazione = new DateTime(2003, 7, 29);
            item2.DataEsitoCommissione = new DateTime(2003, 9, 25);
            item2.Note = "lettera";
            //item2.DurataProcessoUfficio = 60;
            //item2.DataFineTeorica = item2.DataRicevimentoRelazione.AddDays(item2.DurataProcessoUfficio);

            toReturn.Add(item2);
           

            return toReturn.ToArray();
        }

        public static CambioPosizioneFDT[] GetListPositionChanges()
        {
            List<CambioPosizioneFDT> toReturn = new List<CambioPosizioneFDT>();

            CambioPosizioneFDT item = new CambioPosizioneFDT();
            item.IdCambioPosizione = 1;
            item.NumeroDeliberaCommissione = "445";
            item.DataDeliberaCommissione = new DateTime(1978, 3, 30);
            item.NumeroDetermina = "39";
            item.DataDetermina = new DateTime(2005, 3, 23);
            //item.IdTipoCambioCategoria = 0;
            
            //item.VecchiaCategoria = 2;
            //item.IdTipoCambioSezione = 1;

            item.IdCategoria = 1;
            item.Sezione = 1;
            item.CategoriaSociale = 1;
            item.IdSottoCategoria = 1;
           
            //item.VecchiaSezione = 3;
            //item.DataProcessoUfficio = new DateTime(1978, 3, 31);
            //item.DurataProcessoUfficio = 60;
            item.DataRicevimentoDomanda = new DateTime(1978, 3, 31);
            

            toReturn.Add(item);

            item = new CambioPosizioneFDT();
            item.IdCambioPosizione = 2;
            item.NumeroDeliberaCommissione = "445";
            item.DataDeliberaCommissione = new DateTime(1978, 3, 30).AddYears(4);
            item.NumeroDetermina = "39";
            item.DataDetermina = new DateTime(2005, 3, 23);
            //item.IdTipoCambioCategoria = 0;
            item.IdCategoria = 2;
            //item.VecchiaCategoria = 2;
            //item.IdTipoCambioSezione = 1;
            item.Sezione = 1;
            //item.VecchiaSezione = 3;

            //item.DataProcessoUfficio = new DateTime(1978, 3, 10).AddYears(4);
            //item.DurataProcessoUfficio = 60;
            item.DataRicevimentoDomanda = new DateTime(1978, 3, 4).AddYears(4);

            item.IdCategoria = 2;
            item.Sezione = 2;
            item.CategoriaSociale = 1;
            item.IdSottoCategoria = 1;

            toReturn.Add(item);

            return toReturn.ToArray();
        }

        //public static TipoCambioCategoriaFDT[] GetListCategoryChangeTypes(string from)
        //{
        //    string[] types = new string[] { "ISCR. PROVVISORIA AL NUOVO REGISTRO 2005",
        //                                    "CAMBIO CATEGORIA",
        //                                    "ALTRO"};

        //    List<TipoCambioCategoriaFDT> list = new List<TipoCambioCategoriaFDT>();
        //    TipoCambioCategoriaFDT item = null;
        //    for (int i = 0; i < types.Length; i++)
        //    {
        //        item = new TipoCambioCategoriaFDT();
        //        item.IdElemento = i;
        //        item.Descrizione = types[i];

        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        //public static TipoCambioSezioneFDT[] GetListSectionChangeTypes(string from)
        //{
        //    string[] types = new string[] { "TRASFERIMENTO A SEZIONE NON PREVALENTI",
        //                                    "TRASFERIMENTO A SEZIONE PREVALENTI"};

        //    List<TipoCambioSezioneFDT> list = new List<TipoCambioSezioneFDT>();
        //    TipoCambioSezioneFDT item = null;
        //    for (int i = 0; i < types.Length; i++)
        //    {
        //        item = new TipoCambioSezioneFDT();
        //        item.IdElemento = i;
        //        item.Descrizione = types[i];

        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        //public static TipoCambioCategoriaSocialeFDT[] GetListSocialCategoryChangeTypes(string from)
        //{
        //    string[] types = new string[] { "ISCRIZIONE A SOCIALI",
        //                                    "CANCELLAZIONE DA SOCIALI",
        //                                    "CAMBIO SOTTOCATEGORIA PER SOCIALI",
        //                                    "ALTRO"};

        //    List<TipoCambioCategoriaSocialeFDT> list = new List<TipoCambioCategoriaSocialeFDT>();
        //    TipoCambioCategoriaSocialeFDT item = null;
        //    for (int i = 0; i < types.Length; i++)
        //    {
        //        item = new TipoCambioCategoriaSocialeFDT();
        //        item.IdElemento = i;
        //        item.Descrizione = types[i];

        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        //public static TipoCambioSottoCatSocialeFDT[] GetListSocialSubCategoryChangeTypes(string from)
        //{
        //    string[] types = new string[] { "ISCRIZIONE A SOCIALI",
        //                                    "CANCELLAZIONE DA SOCIALI",
        //                                    "CAMBIO SOTTOCATEGORIA PER SOCIALI",
        //                                    "ALTRO"};

        //    List<TipoCambioSottoCatSocialeFDT> list = new List<TipoCambioSottoCatSocialeFDT>();
        //    TipoCambioSottoCatSocialeFDT item = null;
        //    for (int i = 0; i < types.Length; i++)
        //    {
        //        item = new TipoCambioSottoCatSocialeFDT();
        //        item.IdElemento = i;
        //        item.Descrizione = types[i];

        //        list.Add(item);
        //    }
        //    return list.ToArray();
        //}

        public static CittadinanzaFDT[] GetListCitizenships(string from)
        {
            string[] types = new string[] { "ITALIANA",
                                            "ESTERA"};

            List<CittadinanzaFDT> list = new List<CittadinanzaFDT>();
            CittadinanzaFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new CittadinanzaFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static TipoAutorizzazioneFDT[] GetListAuthorizationTypes()
        {
            string[] types = new string[] { "AUTORIZZAZIONE AL DEPOSITO DEL BFL",
                                            "NOMINA LEGALE"};

            List<TipoAutorizzazioneFDT> list = new List<TipoAutorizzazioneFDT>();
            TipoAutorizzazioneFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoAutorizzazioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static DizionarioFDT[] GetListRegistryTypes(string from)
        {
            string[] types = new string[] { "COOPERATIVA",
                                            "PERSONA GIURIDICA",
                                            "PERSONA FISICA"};

            List<DizionarioFDT> list = new List<DizionarioFDT>();
            DizionarioFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoAutorizzazioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static DizionarioFDT[] GetListMutualRequirementTypes()
        {
            string[] types = new string[] { "Sussiste",
                                            "Non sussiste",
                                            "Regime derogatorio"};

            List<DizionarioFDT> list = new List<DizionarioFDT>();
            DizionarioFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoAutorizzazioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static DizionarioFDT[] GetListResidualPaymentTypes()
        {
            string[] types = new string[] { "Acconto",
                                            "Saldo"};

            List<TipoAutorizzazioneFDT> list = new List<TipoAutorizzazioneFDT>();
            TipoAutorizzazioneFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoAutorizzazioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static DizionarioFDT[] GetListFailureTypes()
        {
            string[] types = new string[] { "Concluso",
                                            "Revocato"};

            List<TipoAutorizzazioneFDT> list = new List<TipoAutorizzazioneFDT>();
            TipoAutorizzazioneFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoAutorizzazioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }

        public static DizionarioFDT[] GetListContributionTypes()
        {
            string[] types = new string[] { "Anticipo",
                                            "Saldo"};

            List<TipoAutorizzazioneFDT> list = new List<TipoAutorizzazioneFDT>();
            TipoAutorizzazioneFDT item = null;
            for (int i = 0; i < types.Length; i++)
            {
                item = new TipoAutorizzazioneFDT();
                item.IdElemento = i;
                item.Descrizione = types[i];

                list.Add(item);
            }
            return list.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public sealed class TipoStatoIscrizione
    {

		#region Fields (4) 

        public const int NORMALE = 1;
        public const int SCIOGLIMENTO_VOLONTARIO = 5;
        public const int SCIOGLIMENTO_SCISSIONE = 6;
        public const int CESSATA_INCORPORAZIONE = 7;
        public const int TRASFERIMENTO_FUORI_PROV = 8;
        public const int TRASFORMAZIONE_FORMA_GIURIDICA = 9;

        public const int FALLIMENTO = 2;
        public const int LIQUIDAZIONE_COATTA = 3;
        public const int LIQUIDAZIONE_COATTA_AMM = 4;

		#endregion Fields 

    }
}

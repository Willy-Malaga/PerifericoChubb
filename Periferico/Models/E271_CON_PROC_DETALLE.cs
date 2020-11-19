using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ConProcDetalle
    {
        [DataMember(Name = "coInProcedimiento", IsRequired = true, Order = 0)]
        public string coInProcedimiento { get; set; }
        [DataMember(Name = "coInRestriccion", IsRequired = true, Order = 1)]
        public string coInRestriccion { get; set; }
        [DataMember(Name = "coProcedimiento", IsRequired = true, Order = 2)]
        public string coProcedimiento { get; set; }
        [DataMember(Name = "imDeducible", IsRequired = true, Order = 3)]
        public string imDeducible { get; set; }
        [DataMember(Name = "poCuExDecimal", IsRequired = true, Order = 4)]
        public string poCuExDecimal { get; set; }
        [DataMember(Name = "nuFrecuencia", IsRequired = true, Order = 5)]
        public string nuFrecuencia { get; set; }
        [DataMember(Name = "coSexo", IsRequired = true, Order = 6)]
        public string coSexo { get; set; }
        [DataMember(Name = "tiNuDias", IsRequired = true, Order = 7)]
        public string tiNuDias { get; set; }
        [DataMember(Name = "teMsgObservacion", IsRequired = true, Order = 8)]
        public string teMsgObservacion { get; set; }
        [DataMember(Name = "idFuentePE", IsRequired = true, Order = 9)]
        public string idFuentePE { get; set; }
        [DataMember(Name = "coTiEspera", IsRequired = true, Order = 10)]
        public string coTiEspera { get; set; }
        [DataMember(Name = "deTiEspera", IsRequired = true, Order = 11)]
        public string deTiEspera { get; set; }
        [DataMember(Name = "feFinVigencia", IsRequired = true, Order = 12)]
        public string feFinVigencia { get; set; }
        [DataMember(Name = "teMsgTiEspera", IsRequired = true, Order = 13)]
        public string teMsgTiEspera { get; set; }
        [DataMember(Name = "idFuenteTE", IsRequired = true, Order = 14)]
        public string idFuenteTE { get; set; }
        [DataMember(Name = "coExCarencia", IsRequired = true, Order = 15)]
        public string coExCarencia { get; set; }
        [DataMember(Name = "deExCarencia", IsRequired = true, Order = 16)]
        public string deExCarencia { get; set; }
        [DataMember(Name = "teMsgExCarencia", IsRequired = true, Order = 17)]
        public string teMsgExCarencia { get; set; }
        [DataMember(Name = "idFuenteEC", IsRequired = true, Order = 18)]
        public string idFuenteEC { get; set; }
    }
}

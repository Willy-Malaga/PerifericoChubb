using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ResSctrDetalle
    {
        [DataMember(Name = "tiCaContratante", IsRequired = true, Order = 0)]
        public string tiCaContratante { get; set; }
        [DataMember(Name = "noEmApPaContratante", IsRequired = true, Order = 1)]
        public string noEmApPaContratante { get; set; }
        [DataMember(Name = "coEmContratante", IsRequired = true, Order = 2)]
        public string coEmContratante { get; set; }
        [DataMember(Name = "idCaReContratante", IsRequired = true, Order = 3)]
        public string idCaReContratante { get; set; }
        [DataMember(Name = "reIdContratante", IsRequired = true, Order = 4)]
        public string reIdContratante { get; set; }
        [DataMember(Name = "tiCaLuAtencion", IsRequired = true, Order = 5)]
        public string tiCaLuAtencion { get; set; }
        [DataMember(Name = "noEmLuAtencion", IsRequired = true, Order = 6)]
        public string noEmLuAtencion { get; set; }
        [DataMember(Name = "coEmReLuAtencion", IsRequired = true, Order = 7)]
        public string coEmReLuAtencion { get; set; }
        [DataMember(Name = "idCaReLuAtencion", IsRequired = true, Order = 8)]
        public string idCaReLuAtencion { get; set; }
        [DataMember(Name = "reIdLuAtencion", IsRequired = true, Order = 9)]
        public string reIdLuAtencion { get; set; }
        [DataMember(Name = "coLuAtencion", IsRequired = true, Order = 10)]
        public string coLuAtencion { get; set; }
        [DataMember(Name = "deTiAccidente", IsRequired = true, Order = 11)]
        public string deTiAccidente { get; set; }
        [DataMember(Name = "feAfiliacion", IsRequired = true, Order = 12)]
        public string feAfiliacion { get; set; }
        [DataMember(Name = "feOcAccidente", IsRequired = true, Order = 13)]
        public string feOcAccidente { get; set; }
    }
}

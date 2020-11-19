using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E278SolCg
    {
        [DataMember(Name = "noTransaccion", IsRequired = true, Order = 0)]
        public string noTransaccion { get; set; }
        [DataMember(Name = "idRemitente", IsRequired = true, Order = 1)]
        public string idRemitente { get; set; }
        [DataMember(Name = "idReceptor", IsRequired = true, Order = 2)]
        public string idReceptor { get; set; }
        [DataMember(Name = "feTransaccion", IsRequired = true, Order = 3)]
        public string feTransaccion { get; set; }
        [DataMember(Name = "hoTransaccion", IsRequired = true, Order = 4)]
        public string hoTransaccion { get; set; }
        [DataMember(Name = "idCorrelativo", IsRequired = true, Order = 5)]
        public string idCorrelativo { get; set; }
        [DataMember(Name = "idTransaccion", IsRequired = true, Order = 6)]
        public string idTransaccion { get; set; }
        [DataMember(Name = "tiFinalidad", IsRequired = true, Order = 7)]
        public string tiFinalidad { get; set; }
        [DataMember(Name = "caPaciente", IsRequired = true, Order = 8)]
        public string caPaciente { get; set; }
        [DataMember(Name = "apPaternoPaciente", IsRequired = true, Order = 9)]
        public string apPaternoPaciente { get; set; }
        [DataMember(Name = "noPaciente", IsRequired = true, Order = 10)]
        public string noPaciente { get; set; }
        [DataMember(Name = "apMaternoPaciente", IsRequired = true, Order = 11)]
        public string apMaternoPaciente { get; set; }
        [DataMember(Name = "coTiDoPaciente", IsRequired = true, Order = 12)]
        public string coTiDoPaciente { get; set; }
        [DataMember(Name = "nuDoPaciente", IsRequired = true, Order = 13)]
        public string nuDoPaciente { get; set; }
        [DataMember(Name = "nuCarGarantia", IsRequired = true, Order = 14)]
        public string nuCarGarantia { get; set; }
        [DataMember(Name = "esCarGarantia", IsRequired = true, Order = 15)]
        public string esCarGarantia { get; set; }
        [DataMember(Name = "nuSoCarGarantia", IsRequired = true, Order = 16)]
        public string nuSoCarGarantia { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E997ResAut
    {
        [DataMember(Name = "noTransaccion", IsRequired = true, Order = 1)]
        public string noTransaccion { get; set; }
        [DataMember(Name = "idRemitente", IsRequired = true, Order = 2)]
        public string idRemitente { get; set; }
        [DataMember(Name = "idReceptor", IsRequired = true, Order = 3)]
        public string idReceptor { get; set; }
        [DataMember(Name = "feTransaccion", IsRequired = true, Order = 4)]
        public string feTransaccion { get; set; }
        [DataMember(Name = "hoTransaccion", IsRequired = true, Order = 5)]
        public string hoTransaccion { get; set; }
        [DataMember(Name = "idCorrelativo", IsRequired = true, Order = 6)]
        public string idCorrelativo { get; set; }
        [DataMember(Name = "idTransaccion", IsRequired = true, Order = 7)]
        public string idTransaccion { get; set; }
        [DataMember(Name = "nuAutorizacion", IsRequired = true, Order = 8)]
        public string nuAutorizacion { get; set; }
        [DataMember(Name = "coSeguridad", IsRequired = true, Order = 9)]
        public string coSeguridad { get; set; }
        [DataMember(Name = "coError", IsRequired = true, Order = 10)]
        public string coError { get; set; }
        [DataMember(Name = "inCoErrorEncontrado", IsRequired = true, Order = 11)]
        public string inCoErrorEncontrado { get; set; }

        [DataMember(Name = "codError", IsRequired = true, Order = 12)]
        public string codError { get; set; }
        [DataMember(Name = "descError", IsRequired = true, Order = 13)]
        public string descError { get; set; }
    }
}

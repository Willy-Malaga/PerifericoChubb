using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E278ContEntVinc
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
        [DataMember(Name = "caIPRESS", IsRequired = true, Order = 8)]
        public string caIPRESS { get; set; }
        [DataMember(Name = "noIPRESS", IsRequired = true, Order = 9)]
        public string noIPRESS { get; set; }
        [DataMember(Name = "tiDoIPRESS", IsRequired = true, Order = 10)]
        public string tiDoIPRESS { get; set; }
        [DataMember(Name = "nuRucIPRESS", IsRequired = true, Order = 11)]
        public string nuRucIPRESS { get; set; }
    }
}

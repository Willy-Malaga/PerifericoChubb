using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ResDeriva
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
        [DataMember(Name = "caRemitente", IsRequired = true, Order = 8)]
        public string caRemitente { get; set; }
        [DataMember(Name = "caReceptor", IsRequired = true, Order = 9)]
        public string caReceptor { get; set; }
        [DataMember(Name = "nuRucReceptor", IsRequired = true, Order = 10)]
        public string nuRucReceptor { get; set; }

        [DataMember(Name = "listDetalleResponse", IsRequired = true, Order = 11)]
        public List<E271ResDerivaDetalle> listDetalleResponse { get; set; }

        [DataMember(Name = "codError", IsRequired = true, Order = 12)]
        public string codError { get; set; }
        [DataMember(Name = "descError", IsRequired = true, Order = 13)]
        public string descError { get; set; }
    }
}

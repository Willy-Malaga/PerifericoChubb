using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ConMedDetalle
    {
        //[DataMember(Name = "codServicio",IsRequired=true, Order =0)]
        //public string codServicio {get;set;}
        [DataMember(Name = "coSeCIE10", IsRequired = true, Order = 0)]
        public string coSeCIE10 { get; set; }
        //[DataMember(Name = "codRestriccion",IsRequired=true, Order =1)]
        //public string codRestriccion {get;set;}
        [DataMember(Name = "coRestriccion", IsRequired = true, Order = 1)]
        public string coRestriccion { get; set; }
        [DataMember(Name = "dePreexistencia", IsRequired = true, Order = 2)]
        public string dePreexistencia { get; set; }
        [DataMember(Name = "msgObsPr", IsRequired = true, Order = 3)]
        public string msgObsPr { get; set; }
        [DataMember(Name = "idFuenteRE", IsRequired = true, Order = 4)]
        public string idFuenteRE { get; set; }
        [DataMember(Name = "esCobertura", IsRequired = true, Order = 5)]
        public string esCobertura { get; set; }
        [DataMember(Name = "moDiagnostico", IsRequired = true, Order = 6)]
        public string moDiagnostico { get; set; }
        [DataMember(Name = "tiEspera", IsRequired = true, Order = 7)]
        public string tiEspera { get; set; }
    }
}

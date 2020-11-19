using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271SolAutDetalleRes
    {
        //[DataMember(Name = "codRestricciones", IsRequired = true, Order = 0)]
        //public String codRestricciones { get; set; }
        [DataMember(Name = "CIE10Restricciones", IsRequired = true, Order = 0)]
        public String CIE10Restricciones { get; set; }
        [DataMember(Name = "idRestricciones", IsRequired = true, Order = 1)]
        public String idRestricciones { get; set; }
        [DataMember(Name = "obsRestricciones", IsRequired = true, Order = 2)]
        public String obsRestricciones { get; set; }
        [DataMember(Name = "deRestricciones", IsRequired = true, Order = 3)]
        public String deRestricciones { get; set; }
        [DataMember(Name = "msgRestricciones", IsRequired = true, Order = 4)]
        public String msgRestricciones { get; set; }
        [DataMember(Name = "monTopeRestricciones", IsRequired = true, Order = 5)]
        public String monTopeRestricciones { get; set; }
        [DataMember(Name = "feFinEsperaRestricciones", IsRequired = true, Order = 6)]
        public String feFinEsperaRestricciones { get; set; }
    }
}

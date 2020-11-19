using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271SolAutDetalleProEsp
    {
        [DataMember(Name = "coInProcedimiento", IsRequired = true, Order = 0)]
        public String coInProcedimiento { get; set; }
        [DataMember(Name = "coTiProConAmbulatoria", IsRequired = true, Order = 1)]
        public String coTiProConAmbulatoria { get; set; }
        [DataMember(Name = "nuPlanConAmbulatoria", IsRequired = true, Order = 2)]
        public String nuPlanConAmbulatoria { get; set; }
        [DataMember(Name = "imDeducible", IsRequired = true, Order = 3)]
        public String imDeducible { get; set; }
        [DataMember(Name = "poConAmbulatoria", IsRequired = true, Order = 4)]
        public String poConAmbulatoria { get; set; }
        [DataMember(Name = "frConAmbulatoria", IsRequired = true, Order = 5)]
        public String frConAmbulatoria { get; set; }
        [DataMember(Name = "geConAmbulatoria", IsRequired = true, Order = 6)]
        public String geConAmbulatoria { get; set; }
        [DataMember(Name = "caConAmbulatoria", IsRequired = true, Order = 7)]
        public String caConAmbulatoria { get; set; }
        [DataMember(Name = "msgConAmbulatoria", IsRequired = true, Order = 8)]
        public String msgConAmbulatoria { get; set; }
    }
}

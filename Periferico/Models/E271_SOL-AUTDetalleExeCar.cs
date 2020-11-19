using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271SolAutDetalleExeCar
    {
        [DataMember(Name = "coExCarencia", IsRequired = true, Order = 0)]
        public String coExCarencia { get; set; }
        [DataMember(Name = "idExCarencia", IsRequired = true, Order = 1)]
        public String idExCarencia { get; set; }
        [DataMember(Name = "deExCarencia", IsRequired = true, Order = 2)]
        public String deExCarencia { get; set; }
        [DataMember(Name = "msgExCarencia", IsRequired = true, Order = 3)]
        public String msgExCarencia { get; set; }
    }
}

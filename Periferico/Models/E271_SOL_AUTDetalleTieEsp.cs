using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271SolAutDetalleTieEsp
    {
        [DataMember(Name = "coTiEspera", IsRequired = true, Order = 0)]
        public String coTiEspera { get; set; }
        [DataMember(Name = "idTiEspera", IsRequired = true, Order = 1)]
        public String idTiEspera { get; set; }
        [DataMember(Name = "deTiEspera", IsRequired = true, Order = 2)]
        public String deTiEspera { get; set; }
        [DataMember(Name = "feFinVigenciaTiEspera", IsRequired = true, Order = 3)]
        public String feFinVigenciaTiEspera { get; set; }
        [DataMember(Name = "msgTiEspera", IsRequired = true, Order = 4)]
        public String msgTiEspera { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ResDerivaDetalle
    {
        [DataMember(Name = "caPaciente", IsRequired = true, Order = 0)]
        public string caPaciente { get; set; }
        [DataMember(Name = "apPaternoPaciente", IsRequired = true, Order = 1)]
        public string apPaternoPaciente { get; set; }
        [DataMember(Name = "noPaciente", IsRequired = true, Order = 2)]
        public string noPaciente { get; set; }
        [DataMember(Name = "coAfPaciente", IsRequired = true, Order = 3)]
        public string coAfPaciente { get; set; }
        [DataMember(Name = "apMaternoPaciente", IsRequired = true, Order = 4)]
        public string apMaternoPaciente { get; set; }
        [DataMember(Name = "coTiDoPaciente", IsRequired = true, Order = 5)]
        public string coTiDoPaciente { get; set; }
        [DataMember(Name = "nuDoPaciente", IsRequired = true, Order = 6)]
        public string nuDoPaciente { get; set; }
        [DataMember(Name = "coParentesco", IsRequired = true, Order = 7)]
        public string coParentesco { get; set; }
        [DataMember(Name = "tiDoTrabajoAfiliado", IsRequired = true, Order = 8)]
        public string tiDoTrabajoAfiliado { get; set; }
        [DataMember(Name = "nuDoTrabajoAfiliado", IsRequired = true, Order = 9)]
        public string nuDoTrabajoAfiliado { get; set; }
        [DataMember(Name = "nuAtencion", IsRequired = true, Order = 10)]
        public string nuAtencion { get; set; }
        [DataMember(Name = "teMsgLibre1", IsRequired = true, Order = 11)]
        public string teMsgLibre1 { get; set; }
        [DataMember(Name = "coTiProducto", IsRequired = true, Order = 12)]
        public string coTiProducto { get; set; }
        [DataMember(Name = "deProducto", IsRequired = true, Order = 13)]
        public string deProducto { get; set; }
        [DataMember(Name = "coTiCobertura", IsRequired = true, Order = 14)]
        public string coTiCobertura { get; set; }
        [DataMember(Name = "coSubTiCobertura", IsRequired = true, Order = 15)]
        public string coSubTiCobertura { get; set; }
        [DataMember(Name = "feAtSalud", IsRequired = true, Order = 16)]
        public string feAtSalud { get; set; }
        [DataMember(Name = "noLuAtencion", IsRequired = true, Order = 17)]
        public string noLuAtencion { get; set; }
        [DataMember(Name = "coLuAtencion", IsRequired = true, Order = 18)]
        public string coLuAtencion { get; set; }
        [DataMember(Name = "tiDoContratante", IsRequired = true, Order = 19)]
        public string tiDoContratante { get; set; }
        [DataMember(Name = "idCaReferencia", IsRequired = true, Order = 20)]
        public string idCaReferencia { get; set; }
        [DataMember(Name = "reIdContratante", IsRequired = true, Order = 21)]
        public string reIdContratante { get; set; }
    }
}

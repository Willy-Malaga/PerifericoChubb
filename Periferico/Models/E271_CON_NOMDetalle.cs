using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ConNomDetalle
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
        [DataMember(Name = "coEsPaciente", IsRequired = true, Order = 5)]
        public string coEsPaciente { get; set; }
        [DataMember(Name = "tiDoPaciente", IsRequired = true, Order = 6)]
        public string tiDoPaciente { get; set; }
        [DataMember(Name = "nuDoPaciente", IsRequired = true, Order = 7)]
        public string nuDoPaciente { get; set; }
        [DataMember(Name = "nuContratoPaciente", IsRequired = true, Order = 8)]
        public string nuContratoPaciente { get; set; }
        [DataMember(Name = "coProducto", IsRequired = true, Order = 9)]
        public string coProducto { get; set; }
        [DataMember(Name = "coDescripcion", IsRequired = true, Order = 10)]
        public string coDescripcion { get; set; }
        [DataMember(Name = "nuSCTR", IsRequired = true, Order = 11)]
        public string nuSCTR { get; set; }
        [DataMember(Name = "coParentesco", IsRequired = true, Order = 12)]
        public string coParentesco { get; set; }
        [DataMember(Name = "nuPlan", IsRequired = true, Order = 13)]
        public string nuPlan { get; set; }
        [DataMember(Name = "feNacimiento", IsRequired = true, Order = 14)]
        public string feNacimiento { get; set; }
        [DataMember(Name = "genero", IsRequired = true, Order = 15)]
        public string genero { get; set; }
        [DataMember(Name = "esMarital", IsRequired = true, Order = 16)]
        public string esMarital { get; set; }
        [DataMember(Name = "tiCaContratante", IsRequired = true, Order = 17)]
        public string tiCaContratante { get; set; }
        [DataMember(Name = "noPaContratante", IsRequired = true, Order = 18)]
        public string noPaContratante { get; set; }
        [DataMember(Name = "noContratante", IsRequired = true, Order = 19)]
        public string noContratante { get; set; }
        [DataMember(Name = "noMaContratante", IsRequired = true, Order = 20)]
        public string noMaContratante { get; set; }
        [DataMember(Name = "tiDoContratante", IsRequired = true, Order = 21)]
        public string tiDoContratante { get; set; }
        [DataMember(Name = "idReContratante", IsRequired = true, Order = 22)]
        public string idReContratante { get; set; }
        [DataMember(Name = "coReContratante", IsRequired = true, Order = 23)]
        public string coReContratante { get; set; }
    }
}

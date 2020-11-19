using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ResCgDetalle
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
        [DataMember(Name = "monPago", IsRequired = true, Order = 7)]
        public string monPago { get; set; }
        [DataMember(Name = "tiCaContratante", IsRequired = true, Order = 8)]
        public string tiCaContratante { get; set; }
        [DataMember(Name = "noPaContratante", IsRequired = true, Order = 9)]
        public string noPaContratante { get; set; }
        [DataMember(Name = "noContratante", IsRequired = true, Order = 10)]
        public string noContratante { get; set; }
        [DataMember(Name = "noMaContratante", IsRequired = true, Order = 11)]
        public string noMaContratante { get; set; }
        [DataMember(Name = "tiDoContratante", IsRequired = true, Order = 12)]
        public string tiDoContratante { get; set; }
        [DataMember(Name = "idCaReContratante", IsRequired = true, Order = 13)]
        public string idCaReContratante { get; set; }
        [DataMember(Name = "nuCaReContratante", IsRequired = true, Order = 14)]
        public string nuCaReContratante { get; set; }
        [DataMember(Name = "deCarGarantia", IsRequired = true, Order = 15)]
        public string deCarGarantia { get; set; }
        [DataMember(Name = "nuSoCarGarantia", IsRequired = true, Order = 16)]
        public string nuSoCarGarantia { get; set; }
        [DataMember(Name = "nuCarGarantia", IsRequired = true, Order = 17)]
        public string nuCarGarantia { get; set; }
        [DataMember(Name = "veCarGarantia", IsRequired = true, Order = 18)]
        public string veCarGarantia { get; set; }
        [DataMember(Name = "esCarGarantia", IsRequired = true, Order = 19)]
        public string esCarGarantia { get; set; }
        [DataMember(Name = "coProducto", IsRequired = true, Order = 20)]
        public string coProducto { get; set; }
        [DataMember(Name = "coProcedimiento", IsRequired = true, Order = 21)]
        public string coProcedimiento { get; set; }
        [DataMember(Name = "deProcedimiento", IsRequired = true, Order = 22)]
        public string deProcedimiento { get; set; }
        [DataMember(Name = "nuPlan", IsRequired = true, Order = 23)]
        public string nuPlan { get; set; }
        [DataMember(Name = "tiPlanSalud", IsRequired = true, Order = 24)]
        public string tiPlanSalud { get; set; }
        [DataMember(Name = "coMoneda", IsRequired = true, Order = 25)]
        public string coMoneda { get; set; }
        [DataMember(Name = "feCarGarantia", IsRequired = true, Order = 26)]
        public string feCarGarantia { get; set; }
    }
}

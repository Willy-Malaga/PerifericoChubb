using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ConCodDetalle
    {

        [DataMember(Name = "infBeneficio", IsRequired = true, Order = 0)]
        public string infBeneficio { get; set; }
        [DataMember(Name = "nuCobertura", IsRequired = true, Order = 1)]
        public string nuCobertura { get; set; }
        [DataMember(Name = "beMaxInicial", IsRequired = true, Order = 2)]
        public string beMaxInicial { get; set; }
        [DataMember(Name = "moCobertura", IsRequired = true, Order = 3)]
        public string moCobertura { get; set; }
        [DataMember(Name = "coInRestriccion", IsRequired = true, Order = 4)]
        public string coInRestriccion { get; set; }
        [DataMember(Name = "canServicio", IsRequired = true, Order = 5)]
        public string canServicio { get; set; }
        [DataMember(Name = "idProducto", IsRequired = true, Order = 6)]
        public string idProducto { get; set; }
        [DataMember(Name = "coTiCobertura", IsRequired = true, Order = 7)]
        public string coTiCobertura { get; set; }
        [DataMember(Name = "coSubTiCobertura", IsRequired = true, Order = 8)]
        public string coSubTiCobertura { get; set; }
        [DataMember(Name = "msgObs", IsRequired = true, Order = 9)]
        public string msgObs { get; set; }
        [DataMember(Name = "msgConEspeciales", IsRequired = true, Order = 10)]
        public string msgConEspeciales { get; set; }
        [DataMember(Name = "coTiMoneda", IsRequired = true, Order = 11)]
        public string coTiMoneda { get; set; }
        [DataMember(Name = "coPagoFijo", IsRequired = true, Order = 12)]
        public string coPagoFijo { get; set; }
        [DataMember(Name = "coCalServicio", IsRequired = true, Order = 13)]
        public string coCalServicio { get; set; }
        [DataMember(Name = "canCalServicio", IsRequired = true, Order = 14)]
        public string canCalServicio { get; set; }
        [DataMember(Name = "coPagoVariable", IsRequired = true, Order = 15)]
        public string coPagoVariable { get; set; }
        [DataMember(Name = "flagCaGarantia", IsRequired = true, Order = 16)]
        public string flagCaGarantia { get; set; }
        [DataMember(Name = "deflagCaGarantia", IsRequired = true, Order = 17)]
        public string deflagCaGarantia { get; set; }
        [DataMember(Name = "feFinCarencia", IsRequired = true, Order = 18)]
        public string feFinCarencia { get; set; }
        [DataMember(Name = "feFinEspera", IsRequired = true, Order = 19)]
        public string feFinEspera { get; set; }
    }
}

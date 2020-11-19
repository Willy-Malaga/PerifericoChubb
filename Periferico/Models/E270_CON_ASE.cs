using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E270ConAse
    {
        [DataMember(Name = "noTransaccion", IsRequired = true, Order = 0)]
        public string noTransaccion { get; set; }

        [DataMember(Name = "idRemitente", IsRequired = true, Order = 1)]
        public string idRemitente { get; set; }

        [DataMember(Name = "idReceptor", IsRequired = true, Order = 2)]
        public string idReceptor { get; set; }

        [DataMember(Name = "feTransaccion", IsRequired = true, Order = 4)]
        public string feTransaccion { get; set; }

        [DataMember(Name = "hoTransaccion", IsRequired = true, Order = 5)]
        public string hoTransaccion { get; set; }

        [DataMember(Name = "idCorrelativo", IsRequired = true, Order = 6)]
        public string idCorrelativo { get; set; }

        [DataMember(Name = "idTransaccion", IsRequired = true, Order = 7)]
        public string idTransaccion { get; set; }

        [DataMember(Name = "tiFinalidad", IsRequired = true, Order = 8)]
        public string tiFinalidad { get; set; }

        [DataMember(Name = "caRemitente", IsRequired = true, Order = 9)]
        public string caRemitente { get; set; }

        [DataMember(Name = "nuRucRemitente", IsRequired = true, Order = 10)]
        public string nuRucRemitente { get; set; }

        [DataMember(Name = "txRequest", IsRequired = true, Order = 11)]
        public string txRequest { get; set; }

        [DataMember(Name = "caReceptor", IsRequired = true, Order = 12)]
        public string caReceptor { get; set; }

        [DataMember(Name = "caPaciente", IsRequired = true, Order = 13)]
        public string caPaciente { get; set; }

        [DataMember(Name = "apPaternoPaciente", IsRequired = true, Order = 14)]
        public string apPaternoPaciente { get; set; }

        [DataMember(Name = "noPaciente", IsRequired = true, Order = 15)]
        public string noPaciente { get; set; }

        [DataMember(Name = "coAfPaciente", IsRequired = true, Order = 16)]
        public string coAfPaciente { get; set; }

        [DataMember(Name = "apMaternoPaciente", IsRequired = true, Order = 17)]
        public string apMaternoPaciente { get; set; }

        [DataMember(Name = "tiDocumento", IsRequired = true, Order = 18)]
        public string tiDocumento { get; set; }

        [DataMember(Name = "nuDocumento", IsRequired = true, Order = 19)]
        public string nuDocumento { get; set; }

        [DataMember(Name = "coProducto", IsRequired = true, Order = 20)]
        public string coProducto { get; set; }

        [DataMember(Name = "deProducto", IsRequired = true, Order = 21)]
        public string deProducto { get; set; }

        [DataMember(Name = "coInProducto", IsRequired = true, Order = 22)]
        public string coInProducto { get; set; }

        [DataMember(Name = "nuCobertura", IsRequired = true, Order = 23)]
        public string nuCobertura { get; set; }

        [DataMember(Name = "deCobertura", IsRequired = true, Order = 24)]
        public string deCobertura { get; set; }

        [DataMember(Name = "caServicio", IsRequired = true, Order = 25)]
        public string caServicio { get; set; }

        [DataMember(Name = "coCalservicio", IsRequired = true, Order = 26)]
        public string coCalservicio { get; set; }

        [DataMember(Name = "beMaxInicial", IsRequired = true, Order = 27)]
        public string beMaxInicial { get; set; }

        [DataMember(Name = "coTiCobertura", IsRequired = true, Order = 28)]
        public string coTiCobertura { get; set; }

        [DataMember(Name = "coSuTiCobertura", IsRequired = true, Order = 29)]
        public string coSuTiCobertura { get; set; }

        [DataMember(Name = "coAplicativoTx", IsRequired = true, Order = 30)]
        public string coAplicativoTx { get; set; }

        [DataMember(Name = "coEspecialidad", IsRequired = true, Order = 31)]
        public string coEspecialidad { get; set; }

        [DataMember(Name = "coParentesco", IsRequired = true, Order = 32)]
        public string coParentesco { get; set; }

        [DataMember(Name = "nuPlan", IsRequired = true, Order = 33)]
        public string nuPlan { get; set; }

        [DataMember(Name = "nuAutOrigen", IsRequired = true, Order = 34)]
        public string nuAutOrigen { get; set; }

        [DataMember(Name = "tiAccidente", IsRequired = true, Order = 35)]
        public string tiAccidente { get; set; }

        [DataMember(Name = "feAccidente", IsRequired = true, Order = 36)]
        public string feAccidente { get; set; }

        [DataMember(Name = "tiCaContratante", IsRequired = true, Order = 37)]
        public string tiCaContratante { get; set; }

        [DataMember(Name = "noPaContratante", IsRequired = true, Order = 38)]
        public string noPaContratante { get; set; }

        [DataMember(Name = "noContratante", IsRequired = true, Order = 39)]
        public string noContratante { get; set; }

        [DataMember(Name = "noMaContratante", IsRequired = true, Order = 40)]
        public string noMaContratante { get; set; }

        [DataMember(Name = "tiDoContratante", IsRequired = true, Order = 41)]
        public string tiDoContratante { get; set; }

        [DataMember(Name = "idReContratante", IsRequired = true, Order = 42)]
        public string idReContratante { get; set; }

        [DataMember(Name = "coReContratante", IsRequired = true, Order = 43)]
        public string coReContratante { get; set; }
    }
}

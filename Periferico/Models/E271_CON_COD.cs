using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ConCod
    {

        [DataMember(Name = "noTransaccion", IsRequired = true, Order = 0)]
        public string noTransaccion { get; set; }
        [DataMember(Name = "idRemitente", IsRequired = true, Order = 1)]
        public string idRemitente { get; set; }
        [DataMember(Name = "idReceptor", IsRequired = true, Order = 2)]
        public string idReceptor { get; set; }
        [DataMember(Name = "feTransaccion", IsRequired = true, Order = 3)]
        public string feTransaccion { get; set; }
        [DataMember(Name = "hoTransaccion", IsRequired = true, Order = 4)]
        public string hoTransaccion { get; set; }
        [DataMember(Name = "idCorrelativo", IsRequired = true, Order = 5)]
        public string idCorrelativo { get; set; }
        [DataMember(Name = "idTransaccion", IsRequired = true, Order = 6)]
        public string idTransaccion { get; set; }
        [DataMember(Name = "tiFinalidad", IsRequired = true, Order = 7)]
        public string tiFinalidad { get; set; }
        [DataMember(Name = "caRemitente", IsRequired = true, Order = 8)]
        public string caRemitente { get; set; }
        [DataMember(Name = "userRemitente", IsRequired = true, Order = 9)]
        public string userRemitente { get; set; }
        [DataMember(Name = "passRemitente", IsRequired = true, Order = 10)]
        public string passRemitente { get; set; }
        [DataMember(Name = "feUpFoto", IsRequired = true, Order = 11)]
        public string feUpFoto { get; set; }
        [DataMember(Name = "caReceptor", IsRequired = true, Order = 12)]
        public string caReceptor { get; set; }
        [DataMember(Name = "nuRucReceptor", IsRequired = true, Order = 13)]
        public string nuRucReceptor { get; set; }
        [DataMember(Name = "caPaciente", IsRequired = true, Order = 14)]
        public string caPaciente { get; set; }
        [DataMember(Name = "apPaternoPaciente", IsRequired = true, Order = 15)]
        public string apPaternoPaciente { get; set; }
        [DataMember(Name = "noPaciente", IsRequired = true, Order = 16)]
        public string noPaciente { get; set; }
        [DataMember(Name = "coAfPaciente", IsRequired = true, Order = 17)]
        public string coAfPaciente { get; set; }
        [DataMember(Name = "apMaternoPaciente", IsRequired = true, Order = 18)]
        public string apMaternoPaciente { get; set; }
        [DataMember(Name = "coEsPaciente", IsRequired = true, Order = 19)]
        public string coEsPaciente { get; set; }
        [DataMember(Name = "tiDoPaciente", IsRequired = true, Order = 20)]
        public string tiDoPaciente { get; set; }
        [DataMember(Name = "nuDoPaciente", IsRequired = true, Order = 21)]
        public string nuDoPaciente { get; set; }
        [DataMember(Name = "nuIdenPaciente", IsRequired = true, Order = 22)]
        public string nuIdenPaciente { get; set; }
        [DataMember(Name = "nuContratoPaciente", IsRequired = true, Order = 23)]
        public string nuContratoPaciente { get; set; }
        [DataMember(Name = "nuPoliza", IsRequired = true, Order = 24)]
        public string nuPoliza { get; set; }
        [DataMember(Name = "nuCertificado", IsRequired = true, Order = 25)]
        public string nuCertificado { get; set; }
        [DataMember(Name = "coTiPoliza", IsRequired = true, Order = 26)]
        public string coTiPoliza { get; set; }
        [DataMember(Name = "coProducto", IsRequired = true, Order = 27)]
        public string coProducto { get; set; }
        [DataMember(Name = "deProducto", IsRequired = true, Order = 28)]
        public string deProducto { get; set; }
        [DataMember(Name = "nuPlan", IsRequired = true, Order = 29)]
        public string nuPlan { get; set; }
        [DataMember(Name = "tiPlanSalud", IsRequired = true, Order = 30)]
        public string tiPlanSalud { get; set; }
        [DataMember(Name = "coMoneda", IsRequired = true, Order = 31)]
        public string coMoneda { get; set; }
        [DataMember(Name = "coParentesco", IsRequired = true, Order = 32)]
        public string coParentesco { get; set; }
        [DataMember(Name = "soBeneficio", IsRequired = true, Order = 33)]
        public string soBeneficio { get; set; }
        [DataMember(Name = "nuSoBeneficio", IsRequired = true, Order = 34)]
        public string nuSoBeneficio { get; set; }
        [DataMember(Name = "feNacimiento", IsRequired = true, Order = 35)]
        public string feNacimiento { get; set; }
        [DataMember(Name = "genero", IsRequired = true, Order = 36)]
        public string genero { get; set; }
        [DataMember(Name = "esMarital", IsRequired = true, Order = 37)]
        public string esMarital { get; set; }
        [DataMember(Name = "feIniVigencia", IsRequired = true, Order = 38)]
        public string feIniVigencia { get; set; }
        [DataMember(Name = "feFinVigencia", IsRequired = true, Order = 39)]
        public string feFinVigencia { get; set; }
        [DataMember(Name = "tiCaContratante", IsRequired = true, Order = 40)]
        public string tiCaContratante { get; set; }
        [DataMember(Name = "noPaContratante", IsRequired = true, Order = 41)]
        public string noPaContratante { get; set; }
        [DataMember(Name = "noContratante", IsRequired = true, Order = 42)]
        public string noContratante { get; set; }
        [DataMember(Name = "noMaContratante", IsRequired = true, Order = 43)]
        public string noMaContratante { get; set; }
        [DataMember(Name = "tiDoContratante", IsRequired = true, Order = 44)]
        public string tiDoContratante { get; set; }
        [DataMember(Name = "idReContratante", IsRequired = true, Order = 45)]
        public string idReContratante { get; set; }
        [DataMember(Name = "coReContratante", IsRequired = true, Order = 46)]
        public string coReContratante { get; set; }
        [DataMember(Name = "caTitular", IsRequired = true, Order = 47)]
        public string caTitular { get; set; }
        [DataMember(Name = "noPaTitular", IsRequired = true, Order = 48)]
        public string noPaTitular { get; set; }
        [DataMember(Name = "noTitular", IsRequired = true, Order = 49)]
        public string noTitular { get; set; }
        [DataMember(Name = "coAfTitular", IsRequired = true, Order = 50)]
        public string coAfTitular { get; set; }
        [DataMember(Name = "noMaTitular", IsRequired = true, Order = 51)]
        public string noMaTitular { get; set; }
        [DataMember(Name = "tiDoTitular", IsRequired = true, Order = 52)]
        public string tiDoTitular { get; set; }
        [DataMember(Name = "nuDoTitular", IsRequired = true, Order = 53)]
        public string nuDoTitular { get; set; }
        [DataMember(Name = "feInsTitular", IsRequired = true, Order = 54)]
        public string feInsTitular { get; set; }


        [DataMember(Name = "listDetalleResponse", IsRequired = true, Order = 55)]
        public List<E271ConCodDetalle> listDetalle { get; set; }

        [DataMember(Name = "codError", IsRequired = true, Order = 56)]
        public string codError { get; set; }
        [DataMember(Name = "descError", IsRequired = true, Order = 57)]
        public string descError { get; set; }
    }
}

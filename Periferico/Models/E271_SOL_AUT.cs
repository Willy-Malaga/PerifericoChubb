using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271SolAut
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
        [DataMember(Name = "nuRucRemitente", IsRequired = true, Order = 9)]
        public string nuRucRemitente { get; set; }
        [DataMember(Name = "caReceptor", IsRequired = true, Order = 10)]
        public string caReceptor { get; set; }
        [DataMember(Name = "coAdmisionista", IsRequired = true, Order = 11)]
        public string coAdmisionista { get; set; }
        [DataMember(Name = "caPaciente", IsRequired = true, Order = 12)]
        public string caPaciente { get; set; }
        [DataMember(Name = "apPaternoPaciente", IsRequired = true, Order = 13)]
        public string apPaternoPaciente { get; set; }
        [DataMember(Name = "noPaciente", IsRequired = true, Order = 14)]
        public string noPaciente { get; set; }
        [DataMember(Name = "coAfPaciente", IsRequired = true, Order = 15)]
        public string coAfPaciente { get; set; }
        [DataMember(Name = "apMaternoPaciente", IsRequired = true, Order = 16)]
        public string apMaternoPaciente { get; set; }
        [DataMember(Name = "coEsPaciente", IsRequired = true, Order = 17)]
        public string coEsPaciente { get; set; }
        [DataMember(Name = "tiDoPaciente", IsRequired = true, Order = 18)]
        public string tiDoPaciente { get; set; }
        [DataMember(Name = "nuDoPaciente", IsRequired = true, Order = 19)]
        public string nuDoPaciente { get; set; }
        [DataMember(Name = "nuIdenEmpleador", IsRequired = true, Order = 20)]
        public string nuIdenEmpleador { get; set; }
        [DataMember(Name = "nuContratoPaciente", IsRequired = true, Order = 21)]
        public string nuContratoPaciente { get; set; }
        [DataMember(Name = "nuPoliza", IsRequired = true, Order = 22)]
        public string nuPoliza { get; set; }
        [DataMember(Name = "nuCertificado", IsRequired = true, Order = 23)]
        public string nuCertificado { get; set; }
        [DataMember(Name = "coTiPolizaAfiliacion", IsRequired = true, Order = 24)]
        public string coTiPolizaAfiliacion { get; set; }
        [DataMember(Name = "coProducto", IsRequired = true, Order = 25)]
        public string coProducto { get; set; }
        [DataMember(Name = "deProducto", IsRequired = true, Order = 26)]
        public string deProducto { get; set; }
        [DataMember(Name = "nuPlan", IsRequired = true, Order = 27)]
        public string nuPlan { get; set; }
        [DataMember(Name = "tiPlanSalud", IsRequired = true, Order = 28)]
        public string tiPlanSalud { get; set; }
        [DataMember(Name = "coMoneda", IsRequired = true, Order = 29)]
        public string coMoneda { get; set; }
        [DataMember(Name = "coParentesco", IsRequired = true, Order = 30)]
        public string coParentesco { get; set; }
        [DataMember(Name = "soBeneficio", IsRequired = true, Order = 31)]
        public string soBeneficio { get; set; }
        [DataMember(Name = "nuSoBeneficio", IsRequired = true, Order = 32)]
        public string nuSoBeneficio { get; set; }
        [DataMember(Name = "coEspecialidad", IsRequired = true, Order = 33)]
        public string coEspecialidad { get; set; }
        [DataMember(Name = "feNacimiento", IsRequired = true, Order = 34)]
        public string feNacimiento { get; set; }
        [DataMember(Name = "genero", IsRequired = true, Order = 35)]
        public string genero { get; set; }
        [DataMember(Name = "esMarital", IsRequired = true, Order = 36)]
        public string esMarital { get; set; }
        [DataMember(Name = "feIniVigencia", IsRequired = true, Order = 37)]
        public string feIniVigencia { get; set; }
        [DataMember(Name = "feFinVigencia", IsRequired = true, Order = 38)]
        public string feFinVigencia { get; set; }
        [DataMember(Name = "esCobertura", IsRequired = true, Order = 39)]
        public string esCobertura { get; set; }
        [DataMember(Name = "nuDecAccidente", IsRequired = true, Order = 40)]
        public string nuDecAccidente { get; set; }
        [DataMember(Name = "idInfAccidente", IsRequired = true, Order = 41)]
        public string idInfAccidente { get; set; }
        [DataMember(Name = "deTiAccidente", IsRequired = true, Order = 42)]
        public string deTiAccidente { get; set; }
        [DataMember(Name = "feAfiliacion", IsRequired = true, Order = 43)]
        public string feAfiliacion { get; set; }
        [DataMember(Name = "feOcuAccidente", IsRequired = true, Order = 44)]
        public string feOcuAccidente { get; set; }
        [DataMember(Name = "nuAtencion", IsRequired = true, Order = 45)]
        public string nuAtencion { get; set; }
        [DataMember(Name = "idDerFarmacia", IsRequired = true, Order = 46)]
        public string idDerFarmacia { get; set; }
        [DataMember(Name = "tiProducto", IsRequired = true, Order = 47)]
        public string tiProducto { get; set; }
        [DataMember(Name = "deProductoDeFarmacia", IsRequired = true, Order = 48)]
        public string deProductoDeFarmacia { get; set; }
        [DataMember(Name = "feAtencion", IsRequired = true, Order = 49)]
        public string feAtencion { get; set; }
        [DataMember(Name = "nuCobertura", IsRequired = true, Order = 50)]
        public string nuCobertura { get; set; }
        [DataMember(Name = "obsCobertura", IsRequired = true, Order = 51)]
        public string obsCobertura { get; set; }
        [DataMember(Name = "msgObs", IsRequired = true, Order = 52)]
        public string msgObs { get; set; }
        [DataMember(Name = "msgConEspeciales", IsRequired = true, Order = 53)]
        public string msgConEspeciales { get; set; }
        [DataMember(Name = "caContratante", IsRequired = true, Order = 54)]
        public string caContratante { get; set; }
        [DataMember(Name = "noPaContratante", IsRequired = true, Order = 55)]
        public string noPaContratante { get; set; }
        [DataMember(Name = "noContratante", IsRequired = true, Order = 56)]
        public string noContratante { get; set; }
        [DataMember(Name = "noMaContratante", IsRequired = true, Order = 57)]
        public string noMaContratante { get; set; }
        [DataMember(Name = "tiDoContratante", IsRequired = true, Order = 58)]
        public string tiDoContratante { get; set; }
        [DataMember(Name = "idReContratante", IsRequired = true, Order = 59)]
        public string idReContratante { get; set; }
        [DataMember(Name = "coReContratante", IsRequired = true, Order = 60)]
        public string coReContratante { get; set; }
        [DataMember(Name = "caTitular", IsRequired = true, Order = 61)]
        public string caTitular { get; set; }
        [DataMember(Name = "noPaTitular", IsRequired = true, Order = 62)]
        public string noPaTitular { get; set; }
        [DataMember(Name = "noTitular", IsRequired = true, Order = 63)]
        public string noTitular { get; set; }
        [DataMember(Name = "coAfTitular", IsRequired = true, Order = 64)]
        public string coAfTitular { get; set; }
        [DataMember(Name = "noMaTitular", IsRequired = true, Order = 65)]
        public string noMaTitular { get; set; }
        [DataMember(Name = "tiDoTitular", IsRequired = true, Order = 66)]
        public string tiDoTitular { get; set; }
        [DataMember(Name = "idReTitular", IsRequired = true, Order = 67)]
        public string idReTitular { get; set; }
        [DataMember(Name = "nuDoTitular", IsRequired = true, Order = 68)]
        public string nuDoTitular { get; set; }
        [DataMember(Name = "feIncTitular", IsRequired = true, Order = 69)]
        public string feIncTitular { get; set; }
        [DataMember(Name = "nuCobPreExistencia", IsRequired = true, Order = 70)]
        public string nuCobPreExistencia { get; set; }
        [DataMember(Name = "beMaxInicial", IsRequired = true, Order = 71)]
        public string beMaxInicial { get; set; }
        [DataMember(Name = "canServicio", IsRequired = true, Order = 72)]
        public string canServicio { get; set; }
        [DataMember(Name = "idDeProducto", IsRequired = true, Order = 73)]
        public string idDeProducto { get; set; }
        [DataMember(Name = "coTiCobertura", IsRequired = true, Order = 74)]
        public string coTiCobertura { get; set; }
        [DataMember(Name = "coSubTiCobertura", IsRequired = true, Order = 75)]
        public string coSubTiCobertura { get; set; }
        [DataMember(Name = "msgObsPre", IsRequired = true, Order = 76)]
        public string msgObsPre { get; set; }
        [DataMember(Name = "msgConEspecialesPre", IsRequired = true, Order = 77)]
        public string msgConEspecialesPre { get; set; }
        [DataMember(Name = "coTiMoneda", IsRequired = true, Order = 78)]
        public string coTiMoneda { get; set; }
        [DataMember(Name = "coPagoFijo", IsRequired = true, Order = 79)]
        public string coPagoFijo { get; set; }
        [DataMember(Name = "coCalServicio", IsRequired = true, Order = 80)]
        public string coCalServicio { get; set; }
        [DataMember(Name = "canCalServicio", IsRequired = true, Order = 81)]
        public string canCalServicio { get; set; }
        [DataMember(Name = "coPagoVariable", IsRequired = true, Order = 82)]
        public string coPagoVariable { get; set; }
        [DataMember(Name = "flagCG", IsRequired = true, Order = 83)]
        public string flagCG { get; set; }
        [DataMember(Name = "deflagCG", IsRequired = true, Order = 84)]
        public string deflagCG { get; set; }
        [DataMember(Name = "feFinCarencia", IsRequired = true, Order = 85)]
        public string feFinCarencia { get; set; }
        [DataMember(Name = "feFinEspera", IsRequired = true, Order = 86)]
        public string feFinEspera { get; set; }

        [DataMember(Name = "listDetalleProEsp", IsRequired = true, Order = 87)]
        public List<E271SolAutDetalleProEsp> listDetalleProEsp { get; set; }

        [DataMember(Name = "listDetalleTieEsp", IsRequired = true, Order = 88)]
        public List<E271SolAutDetalleTieEsp> listDetalleTieEsp { get; set; }

        [DataMember(Name = "listDetalleExeCar", IsRequired = true, Order = 89)]
        public List<E271SolAutDetalleExeCar> listDetalleExeCar { get; set; }

        [DataMember(Name = "listDetalleRes", IsRequired = true, Order = 90)]
        public List<E271SolAutDetalleRes> listDetalleRes { get; set; }

        [DataMember(Name = "caRegafi", IsRequired = true, Order = 91)]
        public string caRegafi { get; set; }
        [DataMember(Name = "noPaRegafi", IsRequired = true, Order = 92)]
        public string noPaRegafi { get; set; }
        [DataMember(Name = "noRegafi", IsRequired = true, Order = 93)]
        public string noRegafi { get; set; }
        [DataMember(Name = "coAfRegafi", IsRequired = true, Order = 94)]
        public string coAfRegafi { get; set; }
        [DataMember(Name = "noMaRegafi", IsRequired = true, Order = 95)]
        public string noMaRegafi { get; set; }
        [DataMember(Name = "tiDoRegafi", IsRequired = true, Order = 96)]
        public string tiDoRegafi { get; set; }
        [DataMember(Name = "idReRegafi", IsRequired = true, Order = 97)]
        public string idReRegafi { get; set; }
        [DataMember(Name = "nuDoRegafi", IsRequired = true, Order = 98)]
        public string nuDoRegafi { get; set; }
        [DataMember(Name = "feNaRegafi", IsRequired = true, Order = 99)]
        public string feNaRegafi { get; set; }
        [DataMember(Name = "geRegafi", IsRequired = true, Order = 100)]
        public string geRegafi { get; set; }
        [DataMember(Name = "coPaisRegafi", IsRequired = true, Order = 101)]
        public string coPaisRegafi { get; set; }
    }
}

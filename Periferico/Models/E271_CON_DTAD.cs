using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Periferico.Models
{
    public class E271ConDtad
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
        [DataMember(Name = "caReceptor", IsRequired = true, Order = 9)]
        public string caReceptor { get; set; }
        [DataMember(Name = "nuRucReceptor", IsRequired = true, Order = 10)]
        public string nuRucReceptor { get; set; }
        [DataMember(Name = "caPaciente", IsRequired = true, Order = 11)]
        public string caPaciente { get; set; }
        [DataMember(Name = "apPaternoPaciente", IsRequired = true, Order = 12)]
        public string apPaternoPaciente { get; set; }
        [DataMember(Name = "noPaciente", IsRequired = true, Order = 13)]
        public string noPaciente { get; set; }
        [DataMember(Name = "coAfPaciente", IsRequired = true, Order = 14)]
        public string coAfPaciente { get; set; }
        [DataMember(Name = "apMaternoPaciente", IsRequired = true, Order = 15)]
        public string apMaternoPaciente { get; set; }
        [DataMember(Name = "deDirPaciente1", IsRequired = true, Order = 16)]
        public string deDirPaciente1 { get; set; }
        [DataMember(Name = "deDirPaciente2", IsRequired = true, Order = 17)]
        public string deDirPaciente2 { get; set; }
        [DataMember(Name = "coUbigeoPaciente", IsRequired = true, Order = 18)]
        public string coUbigeoPaciente { get; set; }
        [DataMember(Name = "noContacto", IsRequired = true, Order = 19)]
        public string noContacto { get; set; }
        [DataMember(Name = "emContacto", IsRequired = true, Order = 20)]
        public string emContacto { get; set; }
        [DataMember(Name = "nuTeContacto", IsRequired = true, Order = 21)]
        public string nuTeContacto { get; set; }
        [DataMember(Name = "tiCaCalificador", IsRequired = true, Order = 22)]
        public string tiCaCalificador { get; set; }
        [DataMember(Name = "apPaNoEmCalificador", IsRequired = true, Order = 23)]
        public string apPaNoEmCalificador { get; set; }
        [DataMember(Name = "noEmCalificador", IsRequired = true, Order = 24)]
        public string noEmCalificador { get; set; }
        [DataMember(Name = "apMaCalificador", IsRequired = true, Order = 25)]
        public string apMaCalificador { get; set; }

        [DataMember(Name = "codError", IsRequired = true, Order = 26)]
        public string codError { get; set; }
        [DataMember(Name = "descError", IsRequired = true, Order = 27)]
        public string descError { get; set; }
    }
}

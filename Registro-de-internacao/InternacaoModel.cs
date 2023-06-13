using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_internacao
{
    [Table("mvtHospRegInt")]
    public class InternacaoModel
    {
        [Key()]
        public string codInternacao { get; set; }
        public string prontuario { get; set; }
        public string dataEntrada { get; set; }
        public string horaEntrada { get; set; }
        public string dataSaida { get; set; }
        public string horaSaida { get; set; }
        public string cns { get; set; }
        public string clinicaMedica { get; set; }
        public string localizacao { get; set; }
        public string leito { get; set; }
        public string centroDeCusto { get; set; }
        public string hipoteseDiagnostica { get; set; }
        public string medico { get; set; }
        public string crm { get; set; }
        public string diagnostico { get; set; }
        public string situacao { get; set; }
        [ForeignKey("mvtHospCadPac")]
        [Column("codPaciente")]
        public string pacienteId { get; set; }
        public virtual PacienteModel PacienteModel { get; set; }
        public virtual PacienteModel NomeModel { get; set; }
        public virtual PacienteModel MaeModel { get; set; }
        public virtual PacienteModel DataNascModel { get; set; }

        [ForeignKey("mvtCadCentroCusto")]
        [Column("codCentroCusto")]
        public string centroCustoId { get; set; }
        public virtual CentroCustoModel CentroCustoModel { get; set; }
    }
}

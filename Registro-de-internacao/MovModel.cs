using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_internacao
{
    [Table("mvtMovPac")]
    public class MovModel
    {
        [Key()]
        public string codSequencia { get; set; }
        public string codPaciente { get; set; }
        public string dataMov { get; set; }
        public string horaMov { get; set; }
        public string motivo { get; set; }
        public string localizacao { get; set; }
        public string leito { get; set; }
        public string centroDeCusto { get; set; }
        public string clinicaMedica { get; set; }
        public string medico { get; set; }
        public string crm { get; set; }

        [ForeignKey("mvtHospCadPac")]
        [Column("codPaciente")]
        public string pacienteId { get; set; }
        public virtual PacienteModel PacienteModel { get; set; }


    }
}

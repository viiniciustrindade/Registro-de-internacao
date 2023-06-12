using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_internacao
{
    [Table("mvtCadCentroCusto")]
    public class CentroCustoModel
    {
        [Key()]
        public string codCentroCusto { get; set; }
        public string nomeCentroCusto { get; set; }
    }
}

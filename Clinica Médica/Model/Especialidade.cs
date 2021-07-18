using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Médica.Model
{
    public class Especialidade
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string NomeEspecialidade { get; set; }
    }
}

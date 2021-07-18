using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Médica.Model
{
    public class Medico
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(12)]
        public string CRM { get; set; }
        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public TimeSpan TempoMedio { get; set; }
        public Especialidade Especialidade { get; set; }
        public int? EspecialidadeId { get; set; }

        [NotMapped]
        public string NomeEspecialidade
        {
            get { 
                return (Especialidade != null)? Especialidade.NomeEspecialidade : ""; 
            }
        }
    }
}

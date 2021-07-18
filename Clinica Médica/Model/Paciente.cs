using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Médica.Model
{
    public class Paciente
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required]
        [MaxLength(20)]
        public string Telefone { get; set; }
        [Required]
        [MaxLength(250)]
        public string Profissao { get; set; }

        [NotMapped]
        public DateTime DataView
        {
            get
            {
                return DataNascimento.Date;
            }
        }
    }
}

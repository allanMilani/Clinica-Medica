using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Clinica_Médica.Model
{
    public class Agenda
    {
        public int ID { get; set; }
        [Required]
        public Medico Medico { get; set; }
        public int? MedicoId{ get; set; }
        [Required]
        public Paciente Paciente { get; set; }
        public int? PacienteId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataHoraConsulta { get; set; }
       
        [DataType(DataType.Time)]
        public TimeSpan HoraInicio { get; set; }
       
        [DataType(DataType.Time)]
        public TimeSpan HoraFim { get; set; }
       
        [DataType(DataType.Text)]
        public string Anotacoes { get; set; } 

        [NotMapped]
        public string NomeMedico
        {
            get
            {
                return (Medico != null) ? Medico.Nome: "";
            }
        }

        [NotMapped]
        public string NomePaciente
        {
            get
            {
                return (Paciente != null) ? Paciente.Nome : "";
            }
        }
    }
}

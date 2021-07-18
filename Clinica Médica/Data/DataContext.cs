using Clinica_Médica.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Médica.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AKD2DBIU;Database=ClinicaMedica;User=allan;Password=Senh@123;MultipleActiveResultSets=true");
        }
        
        public DbSet<Especialidade> TBEspecialidade { get; set; }
        public DbSet<Medico> TBMedico { get; set; }
        public DbSet<Paciente> TBPaciente { get; set; }
        public DbSet<Agenda> TBAgenda { get; set; }

    }
}

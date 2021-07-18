using Clinica_Médica.Data;
using Clinica_Médica.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Médica.Controller
{
    public class MedicoController
    {
        internal static void Salvar(Medico item)
        {
            TimeSpan horaInvalida = new TimeSpan(00, 00, 00);

            if (item.CRM.Trim() == "")
                throw new Exception("CRM inválido");

            if (item.Nome.Trim() == "")
                throw new Exception("Nome inválido");


            if (TimeSpan.Compare(horaInvalida, item.TempoMedio) == 0)
                throw new Exception("Tempo médio da consulta inválido");

            item.EspecialidadeId = item.Especialidade.ID;
            item.Especialidade = null;

            using (DataContext dc = new DataContext()) {
                dc.TBMedico.Add(item);
                dc.SaveChanges();
            }
        }

        internal static List<Medico> Pesquisar(Medico item)
        {
            using (DataContext dc = new DataContext()) {
                string consulta = "SELECT * FROM TBMedico WHERE 1 = 1 ";
                List<object> parametros = new List<object>();
                if(item.Nome != null)
                {
                    consulta += " AND Nome LIKE @nome";
                    parametros.Add(new SqlParameter("@nome", "%"+item.Nome+"%"));
                }

                if (item.CRM != null) {
                    consulta += " AND CRM LIKE @crm";
                    parametros.Add(new SqlParameter("@crm", "%"+item.CRM+"%"));
                }

                if(item.Especialidade != null)
                {
                    consulta += " AND EspecialidadeId = @especialidadeId";
                    parametros.Add(new SqlParameter("@especialidadeId", item.Especialidade.ID));
                }

                return dc.TBMedico.FromSqlRaw(consulta, parametros.ToArray()).Include(esp => esp.Especialidade).OrderBy(x => x.Nome).ToList();
            }
        }

        internal static List<Medico> ListarMedicosEspecialidades()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBMedico.Include(esp => esp.Especialidade).OrderBy(x => x.Nome).ToList();
            }
        }

        internal static List<Medico> Listar()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBMedico.OrderBy(x => x.Nome).ToList();
            }
        }

        internal static void Remover(Medico item)
        {
            using (DataContext dc = new DataContext()) {
                dc.TBMedico.Remove(item);
                dc.SaveChanges();
            }
        }

        internal static void Atualizar(Medico item)
        {
            TimeSpan horaInvalida = new TimeSpan(00, 00, 00);
            if (item.CRM.Trim() == "")
                throw new Exception("CRM inválido");

            if (item.Nome.Trim() == "")
                throw new Exception("Nome inválido");


            if (TimeSpan.Compare(horaInvalida, item.TempoMedio) == 0)
                throw new Exception("Tempo médio da consulta inválido");

            using (DataContext dc = new DataContext())
            {
                dc.TBMedico.Update(item);
                dc.SaveChanges();
            }
        }
    }
}

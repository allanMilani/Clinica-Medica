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
    public class PacienteController
    {
        internal static void Salvar(Paciente item)
        {
            if (item.Nome.Trim() == "")
                throw new Exception("Nome inválido");

            if (item.Profissao.Trim() == "")
                throw new Exception("Profissão inválida");

            if (item.Telefone.Trim() == "")
                throw new Exception("Telefone inválido");

            if (item.DataNascimento > DateTime.Today)
                throw new Exception("Data de nascimento inválida");

            using(DataContext dc = new DataContext())
            {
                dc.TBPaciente.Add(item);
                dc.SaveChanges();
            }

        }

        internal static List<Paciente> Listar()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBPaciente.OrderBy(x => x.Nome).ToList();
            }
        }

        internal static List<Paciente> Pesquisar(Paciente item)
        {
            using (DataContext dc = new DataContext())
            {
                string consulta = "SELECT * FROM TBPaciente WHERE 1 = 1 ";
                List<object> parametros = new List<object>();
                if(item.Nome != null && item.Nome.Trim() != "")
                {
                    consulta += " AND Nome LIKE @nome ";
                    parametros.Add(new SqlParameter("@nome", "%"+item.Nome+"%"));
                }

                if(item.DataNascimento < DateTime.Today)
                {
                    consulta += " AND DataNascimento = @dataNascimento ";
                    parametros.Add(new SqlParameter("@dataNascimento", item.DataNascimento));
                }

                if(item.Telefone != null && item.Telefone.Trim() != "")
                {
                    consulta += " AND Telefone LIKE @telefone";
                    parametros.Add(new SqlParameter("@telefone", "%"+ item.Telefone +"%"));
                }

                if(item.Profissao != null && item.Profissao.Trim() != "")
                {
                    consulta += " AND Profissao LIKE @profissao ";
                    parametros.Add(new SqlParameter("@profissao", "%"+item.Profissao+"%"));
                }

                return dc.TBPaciente.FromSqlRaw(consulta, parametros.ToArray()).OrderBy(x => x.Nome).ToList();
            }
        }

        internal static void Atualizar(Paciente pacienteSelecionado)
        {
            if (pacienteSelecionado.Nome.Trim() == "")
                throw new Exception("Nome inválido");

            if (pacienteSelecionado.Profissao.Trim() == "")
                throw new Exception("Profissão inválida");

            if (pacienteSelecionado.Telefone.Trim() == "")
                throw new Exception("Telefone inválido");

            if (pacienteSelecionado.DataNascimento > DateTime.Today)
                throw new Exception("Data de nascimento inválida");

            using (DataContext dc = new DataContext())
            {
                dc.TBPaciente.Update(pacienteSelecionado);
                dc.SaveChanges();
            }
        }

        internal static void Remover(Paciente item)
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBPaciente.Remove(item);
                dc.SaveChanges();
            }
        }
    }
}

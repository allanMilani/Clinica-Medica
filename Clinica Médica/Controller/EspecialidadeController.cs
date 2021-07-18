using Clinica_Médica.Data;
using Clinica_Médica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Médica.Controller
{
    public class EspecialidadeController
    {
        public static void Salvar(Especialidade item)
        {
           if(item.NomeEspecialidade.Trim() == "")
            {
                throw new Exception("Nome de Especialidade inválido!");
            }

           using (DataContext dc = new DataContext())
            {
                dc.TBEspecialidade.Add(item);
                dc.SaveChanges();
            }
        }

        internal static List<Especialidade> Listar()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBEspecialidade.OrderBy(x => x.NomeEspecialidade).ToList();
            }
        }

        internal static List<Especialidade> Pesquisar(Especialidade item)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBEspecialidade
                    .Where(x => x.NomeEspecialidade.Contains(item.NomeEspecialidade))
                    .OrderBy(x => x.NomeEspecialidade)
                    .ToList();
            }
        }

        internal static void Remover(Especialidade item)
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBEspecialidade.Remove(item);
                dc.SaveChanges();
            }
        }

        internal static void Atualizar(Especialidade item)
        {
            if (item.NomeEspecialidade.Trim() == "")
                throw new Exception("Nome da especialidade inválida");

            using (DataContext dc = new DataContext()) {
                dc.TBEspecialidade.Update(item);
                dc.SaveChanges();
            }
        }
    }
}

using Clinica_Médica.Data;
using Clinica_Médica.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Clinica_Médica.Controller
{
    public class AgendaController
    {
        public static bool ExisteConsulta(DateTime dataHoraConsulta, Medico Medico)
        {
            using (DataContext dc = new DataContext())
            {
                var result = dc.TBAgenda.Join(
                        dc.TBMedico,
                        age => age.MedicoId,
                        med => med.ID,
                        (age, med) => new { age, med }
                    ).Select(
                        x => new
                        {
                            x.age.DataHoraConsulta
                        }
                    ).Where(c => c.DataHoraConsulta >= dataHoraConsulta && c.DataHoraConsulta <= dataHoraConsulta.Add(Medico.TempoMedio)).ToList();

                return (result.Count() <= 0 || result == null) ? false : true;

            }
        }

        internal static List<Agenda> PesquisarPaciente(Paciente paciente)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBAgenda
                    .Include(pac => pac.Paciente)
                    .Include(med => med.Medico)
                    .Include(esp => esp.Medico.Especialidade)
                    .Where(age => age.PacienteId == paciente.ID)
                    .ToList();
            }
        }

        internal static List<Agenda> Pesquisa(Medico medicoCb, DateTime value)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBAgenda
                    .Include(pac => pac.Paciente)
                    .Include(med => med.Medico)
                    .Where(age => age.DataHoraConsulta.Date == value.Date && age.MedicoId == medicoCb.ID)
                    .ToList();
            }
        }

        internal static void AtualizarAnotacoes(Agenda agendaSelecionada)
        {
            if (agendaSelecionada.Anotacoes != null && agendaSelecionada.Anotacoes.Trim() != "")
            {
                agendaSelecionada.Anotacoes = Cryptografar(agendaSelecionada.Anotacoes);
                using (DataContext dc = new DataContext())
                {
                    dc.TBAgenda.Update(agendaSelecionada);
                    dc.SaveChanges();
                }
            }
        }

        internal static List<Agenda> ListarAgenda(DateTime value)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBAgenda
                        .Include(pac => pac.Paciente)
                        .Include(med => med.Medico)
                        .Where(age => age.DataHoraConsulta.Date == value.Date)
                        .ToList();
            }
        }

        internal static void Salvar(Agenda item)
        {
            if (item.Medico == null)
                throw new Exception("Médico inválido");


            if (item.Paciente == null)
                throw new Exception("Paciente inválido");


            if (item.DataHoraConsulta.Date < DateTime.Today.Date)
                throw new Exception("Data inválida");


            if (ExisteConsulta(item.DataHoraConsulta, item.Medico) == true)
                throw new Exception("Agendamento indisponivel");

            item.MedicoId = item.Medico.ID;
            item.Medico = null;

            item.PacienteId = item.Paciente.ID;
            item.Paciente = null;

            using (DataContext dc = new DataContext())
            {
                dc.TBAgenda.Add(item);
                dc.SaveChanges();
            }

        }

        internal static void Atualizar(Agenda agendaSelecionada)
        {
            if (agendaSelecionada.Medico == null)
                throw new Exception("Médico inválido");


            if (agendaSelecionada.Paciente == null)
                throw new Exception("Paciente inválido");


            if (agendaSelecionada.DataHoraConsulta.Date < DateTime.Today.Date)
                throw new Exception("Data inválida");


            if (ExisteConsulta(agendaSelecionada.DataHoraConsulta, agendaSelecionada.Medico) == true)
                throw new Exception("Agendamento indisponivel");

            using (DataContext dc = new DataContext())
            {
                dc.TBAgenda.Update(agendaSelecionada);
                dc.SaveChanges();
            }
        }

        internal static void Remover(Agenda item)
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBAgenda.Remove(item);
                dc.SaveChanges();
            }
        }

        private static string Cryptografar(string texto)
        {
            string chaveCriptografia = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(texto);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chaveCriptografia, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    texto = Convert.ToBase64String(ms.ToArray());
                }
            }
            return texto;
        }

        public static string Descriptografar(string texto)
        {
            string chaveCriptografia = "abc123";
            texto = texto.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(texto);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chaveCriptografia, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    texto = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return texto;
        }
    }
}

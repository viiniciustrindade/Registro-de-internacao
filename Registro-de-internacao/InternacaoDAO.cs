using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_internacao
{
    public class InternacaoDAO
    {
        private SqlConnection Connection { get; }
        public InternacaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(InternacaoModel internacao, PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtHospRegInt(codPaciente, prontuario, dataEntrada, horaEntrada, dataSaida, horaSaidade, CNS, clinicaMedica, localizacao, leito, centroDeCusto," +
                        $"hipoteseDiagnostica, medico, CRM, diagnostico, situacao) VALUES(@codPaciente, @prontuario, @dataEntrada, @horaEntrada, @dataSaida, @horaSaidade, @CNS, @clinicaMedica, @localizacao, @leito, @centroDeCusto," +
                        $"@hipoteseDiagnostica, @medico, @CRM, @diagnostico, @situacao)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
                    command.Parameters.Add(new SqlParameter("@prontuario", internacao.prontuario));
                    command.Parameters.Add(new SqlParameter("@dataEntrada", internacao.dataEntrada));
                    command.Parameters.Add(new SqlParameter("@horaEntrada", internacao.horaEntrada));
                    command.Parameters.Add(new SqlParameter("@dataSaida", internacao.dataSaida));
                    command.Parameters.Add(new SqlParameter("@horaSaidade", internacao.horaSaida));
                    command.Parameters.Add(new SqlParameter("@CNS", internacao.cns));
                    command.Parameters.Add(new SqlParameter("@clinicaMedica", internacao.clinicaMedica));
                    command.Parameters.Add(new SqlParameter("@localizacao", internacao.localizacao));
                    command.Parameters.Add(new SqlParameter("@leito", internacao.leito));
                    command.Parameters.Add(new SqlParameter("@centroDeCusto", internacao.centroDeCusto));
                    command.Parameters.Add(new SqlParameter("@hipoteseDiagnostica", internacao.hipoteseDiagnostica));
                    command.Parameters.Add(new SqlParameter("@medico", internacao.medico));
                    command.Parameters.Add(new SqlParameter("@CRM", internacao.crm));
                    command.Parameters.Add(new SqlParameter("@diagnostico", internacao.diagnostico));
                    command.Parameters.Add(new SqlParameter("@situacao", internacao.situacao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Alterar(InternacaoModel internacao, PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtHospRegInt(codPaciente, prontuario, dataEntrada, horaEntrada, dataSaida, horaSaidade, CNS, clinicaMedica, localizacao, leito, centroDeCusto," +
                        $"hipoteseDiagnostica, medico, CRM, diagnostico, situacao) VALUES(@codPaciente, @prontuario, @dataEntrada, @horaEntrada, @dataSaida, @horaSaidade, @CNS, @clinicaMedica, @localizacao, @leito, @centroDeCusto," +
                        $"@hipoteseDiagnostica, @medico, @CRM, @diagnostico, @situacao)");

                    command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
                    command.Parameters.Add(new SqlParameter("@prontuario", internacao.prontuario));
                    command.Parameters.Add(new SqlParameter("@dataEntrada", internacao.dataEntrada));
                    command.Parameters.Add(new SqlParameter("@horaEntrada", internacao.horaEntrada));
                    command.Parameters.Add(new SqlParameter("@dataSaida", internacao.dataSaida));
                    command.Parameters.Add(new SqlParameter("@horaSaidade", internacao.horaSaida));
                    command.Parameters.Add(new SqlParameter("@CNS", internacao.cns));
                    command.Parameters.Add(new SqlParameter("@clinicaMedica", internacao.clinicaMedica));
                    command.Parameters.Add(new SqlParameter("@localizacao", internacao.localizacao));
                    command.Parameters.Add(new SqlParameter("@leito", internacao.leito));
                    command.Parameters.Add(new SqlParameter("@centroDeCusto", internacao.centroDeCusto));
                    command.Parameters.Add(new SqlParameter("@hipoteseDiagnostica", internacao.hipoteseDiagnostica));
                    command.Parameters.Add(new SqlParameter("@medico", internacao.medico));
                    command.Parameters.Add(new SqlParameter("@CRM", internacao.crm));
                    command.Parameters.Add(new SqlParameter("@diagnostico", internacao.diagnostico));
                    command.Parameters.Add(new SqlParameter("@situacao", internacao.situacao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
    }
}

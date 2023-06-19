using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_internacao
{
    public class InternacaoDAO
    {
        private SqlConnection Connection { get; }
        public InternacaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(PacienteModel paciente, InternacaoModel internacao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtHospRegInt(codPaciente, dataEntrada, horaEntrada, dataSaida, horaSaidade, CNS, clinicaMedica, localizacao, leito, centroDeCusto," +
                        $"hipoteseDiagnostica, medico, CRM, diagnostico, situacao) VALUES(@codPaciente, @dataEntrada, @horaEntrada, @dataSaida, @horaSaidade, @CNS, @clinicaMedica, @localizacao, @leito, @centroDeCusto," +
                        $"@hipoteseDiagnostica, @medico, @CRM, @diagnostico, @situacao)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
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
        public void Alterar(PacienteModel paciente, InternacaoModel internacao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtHospRegInt SET codPaciente = @codPaciente, dataEntrada = @dataEntrada, horaEntrada = @horaEntrada, dataSaida = @dataSaida," +
                        $" horaSaidade = @horaSaidade, CNS = @CNS, clinicaMedica = @clinicaMedica, localizacao = @localizacao, leito = @leito, centroDeCusto = @centroDeCusto," +
                        $"hipoteseDiagnostica = @hipoteseDiagnostica, medico = @medico, CRM = @CRM, diagnostico = @diagnostico, situacao = @situacao WHERE codProntuario = @codProntuario");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codProntuario", internacao.prontuario);
                    command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
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
        public void AlterarCadastroPaciente(PacienteModel paciente, InternacaoModel internacao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtHospCadPac SET situacao = @situacao WHERE codPaciente = @codPaciente");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
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
        public bool Validacoes(PacienteModel paciente, InternacaoModel internacao)
        {
            if (string.IsNullOrEmpty(paciente.codPaciente) || string.IsNullOrWhiteSpace(paciente.codPaciente))
            {
                MessageBox.Show("Informe o campo [Código paciente]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.prontuario) || string.IsNullOrWhiteSpace(internacao.prontuario))
            {
                MessageBox.Show("Informe o campo [Prontuário]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.dataEntrada) || string.IsNullOrWhiteSpace(internacao.dataEntrada))
            {
                MessageBox.Show("Informe o campo [Data entrada]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.horaEntrada) || string.IsNullOrWhiteSpace(internacao.horaEntrada))
            {
                MessageBox.Show("Informe o campo [Hora entrada]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.medico) || string.IsNullOrWhiteSpace(internacao.medico))
            {
                MessageBox.Show("Informe o campo [Médico]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.crm) || string.IsNullOrWhiteSpace(internacao.crm))
            {
                MessageBox.Show("Informe o campo [CRM]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.centroDeCusto) || string.IsNullOrWhiteSpace(internacao.centroDeCusto))
            {
                MessageBox.Show("Informe o campo [Prontuário]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.leito) || string.IsNullOrWhiteSpace(internacao.leito))
            {
                MessageBox.Show("Informe o campo [Leito]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(internacao.situacao) || string.IsNullOrWhiteSpace(internacao.situacao))
            {
                MessageBox.Show("Informe o campo [Situação]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public int VerificaRegistros(InternacaoModel internacao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codProntuario) FROM mvtHospRegInt WHERE codProntuario = @codProntuario");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codProntuario", internacao.prontuario);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public void Excluir(InternacaoModel internacao, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtMovPac WHERE codProntuario = @codProntuario");
                sql.AppendLine($"DELETE FROM mvtHospRegInt WHERE codProntuario = @codProntuario");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codProntuario", internacao.prontuario));
                command.ExecuteNonQuery();
            }
        }

        public List<InternacaoModel> GetInternacoes()
        {
            List<InternacaoModel> internados = new List<InternacaoModel>();
            SqlCommand command = Connection.CreateCommand();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT m.codProntuario, m.codPaciente, m.dataEntrada, m.horaEntrada, m.dataSaida, m.horaSaidade, m.CNS, m.clinicaMedica,"+
            " m.localizacao, m.leito, m.centroDeCusto, m.hipoteseDiagnostica, m.medico, m.CRM, m.diagnostico, m.situacao," +
            " p.nomePaciente, p.nomeMaePaciente, p.dataNascPaciente"+
            " FROM mvtHospRegInt m "+
            "INNER JOIN mvtHospCadPac p ON m.codPaciente = p.codPaciente"+
            " ORDER BY m.codProntuario DESC;");
            command.CommandText = sql.ToString();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    internados.Add(PopulateDr(dr));
                }
            }
            return internados;
        }
        private InternacaoModel PopulateDr(SqlDataReader dr)
        {
            string prontuario = "";
            string dataEntrada = "";
            string horaEntrada = "";
            string dataSaida = "";
            string horaSaidade = "";
            string cns = "";
            string clinicaMedica = "";
            string localizacao = "";
            string leito = "";
            string centroDeCusto = "";
            string hipoteseDiagnostica = "";
            string medico = "";
            string crm = "";
            string diagnostico = "";
            string situacao = "";

            PacienteModel codPaciente = null;
            PacienteModel nomePaciente = null;
            PacienteModel mae = null;
            PacienteModel dataNasc = null;

            if (DBNull.Value != dr["codProntuario"])
            {
                prontuario = dr["codProntuario"] + "";
            }
            if (DBNull.Value != dr["dataEntrada"])
            {
                dataEntrada = dr["dataEntrada"] + "";
            }
            if (DBNull.Value != dr["horaEntrada"])
            {
                horaEntrada = dr["horaEntrada"] + "";
            }
            if (DBNull.Value != dr["dataSaida"])
            {
                dataSaida = dr["dataSaida"] + "";
            }
            if (DBNull.Value != dr["horaSaidade"])
            {
                horaSaidade = dr["horaSaidade"] + "";
            }
            if (DBNull.Value != dr["CNS"])
            {
                cns = dr["CNS"] + "";
            }
            if (DBNull.Value != dr["clinicaMedica"])
            {
                clinicaMedica = dr["clinicaMedica"] + "";
            }
            if (DBNull.Value != dr["localizacao"])
            {
                localizacao = dr["localizacao"] + "";
            }
            if (DBNull.Value != dr["leito"])
            {
                leito = dr["leito"] + "";
            }
            if (DBNull.Value != dr["centroDeCusto"])
            {
                centroDeCusto = dr["centroDeCusto"] + "";
            }
            if (DBNull.Value != dr["hipoteseDiagnostica"])
            {
                hipoteseDiagnostica = dr["hipoteseDiagnostica"] + "";
            }
            if (DBNull.Value != dr["medico"])
            {
                medico = dr["medico"] + "";
            }
            if (DBNull.Value != dr["CRM"])
            {
                crm = dr["CRM"] + "";
            }
            if (DBNull.Value != dr["diagnostico"])
            {
                diagnostico = dr["diagnostico"] + "";
            }
            if (DBNull.Value != dr["situacao"])
            {
                situacao = dr["situacao"] + "";
            }
            if (DBNull.Value != dr["codPaciente"])
            {
                string paciente = dr["codPaciente"] + "";
                codPaciente = new PacienteModel()
                {
                    codPaciente = paciente
                };
            }
            if (DBNull.Value != dr["nomePaciente"])
            {
                string paciente = dr["nomePaciente"] + "";
                nomePaciente = new PacienteModel()
                {
                    nomePaciente = paciente
                };
            }
            if (DBNull.Value != dr["nomeMaePaciente"])
            {
                string paciente = dr["nomeMaePaciente"] + "";
                mae = new PacienteModel()
                {
                    mae = paciente
                };
            }
            if (DBNull.Value != dr["dataNascPaciente"])
            {
                string paciente = dr["dataNascPaciente"] + "";
                dataNasc = new PacienteModel()
                {
                    dataNasc = paciente
                };
            }
            return new InternacaoModel()
            {
                prontuario = prontuario,
                dataEntrada = dataEntrada,
                horaEntrada = horaEntrada,
                dataSaida = dataSaida,
                horaSaida = horaSaidade,
                localizacao = localizacao,
                cns = cns,
                clinicaMedica = clinicaMedica,
                leito = leito,
                centroDeCusto = centroDeCusto,
                hipoteseDiagnostica = hipoteseDiagnostica,
                medico = medico,
                diagnostico = diagnostico,
                crm = crm,
                situacao = situacao,
                PacienteModel = codPaciente, 
                NomeModel = nomePaciente,
                MaeModel = mae,
                DataNascModel = dataNasc
            };
        }
    }
}

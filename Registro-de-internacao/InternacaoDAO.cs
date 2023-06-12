using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
        public void Alterar(PacienteModel paciente, InternacaoModel internacao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE SET mvtHospRegInt codPaciente = @codPaciente, prontuario = @prontuario, dataEntrada = @dataEntrada, horaEntrada = @horaEntrada, dataSaida = @dataSaida," +
                        $" horaSaidade = @horaSaidade, CNS = @CNS, clinicaMedica = @clinicaMedica, localizacao = @localizacao, leito = @leito, centroDeCusto = @centroDeCusto," +
                        $"hipoteseDiagnostica = @hipoteseDiagnostica, medico = @medico, CRM = @CRM, diagnostico = @diagnostico, situacao = @situacao WHERE codPaciente = @codPaciente");

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
        public int VerificaRegistros(PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codPaciente) FROM mvtHospRegInt WHERE codPaciente = @codPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codPaciente", paciente.codPaciente);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public void Excluir(PacienteModel paciente, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtHospRegInt WHERE codPaciente = @codPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
                command.ExecuteNonQuery();
            }
        }
        public List<InternacaoModel> GetInternacoes()
        {
            List<InternacaoModel> internados = new List<InternacaoModel>();
            SqlCommand command = Connection.CreateCommand();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT codInternacao, codPaciente, prontuario, dataEntrada, horaEntrada, dataSaida, horaSaidade, CNS, clinicaMedica, " +
                "localizacao, leito, centroDeCusto, hipoteseDiagnostica, medico,CRM, diagnostico, situacao FROM mvtHospRegInt ORDER BY codInternacao ASC");
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

        public List<PacienteModel> GetNomePacientes(PacienteModel paciente)
        {
            List<PacienteModel> pacientes = new List<PacienteModel>();
            SqlCommand command = Connection.CreateCommand();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT nomePaciente FROM mvtHospCadPac WHERE codPaciente = @codPaciente ORDER BY codPaciente ASC");
            command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
            command.CommandText = sql.ToString();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    pacientes.Add(PopulateDr1(dr));
                }
            }
            return pacientes;
        }
        private PacienteModel PopulateDr1(SqlDataReader dr)
        {
            string nomePaciente = "";

            if (DBNull.Value != dr["nomePaciente"])
            {
                nomePaciente = dr["nomePAciente"] + "";
            }
            return new PacienteModel()
            {
                nomePaciente = nomePaciente
            };
        }
        private InternacaoModel PopulateDr(SqlDataReader dr)
        {
            string codInternacao = "";
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

            if (DBNull.Value != dr["codInternacao"])
            {
                codInternacao = dr["codInternacao"] + "";
            }
            if (DBNull.Value != dr["prontuario"])
            {
                prontuario = dr["prontuario"] + "";
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
            return new InternacaoModel()
            {
                codInternacao = codInternacao,
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
                PacienteModel = codPaciente
            };
        }
    }
}

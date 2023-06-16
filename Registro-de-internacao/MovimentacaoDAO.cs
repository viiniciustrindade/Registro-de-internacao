using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_internacao
{
    public class MovimentacaoDAO
    {
        private SqlConnection Connection { get; }
        public MovimentacaoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<MovModel> GetMovimentacao(InternacaoModel internacao)
        {
            List<MovModel> movimentacoes = new List<MovModel>();
            SqlCommand command = Connection.CreateCommand();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT m.codSequencia, m.codPaciente, m.dataMov, m.horaMov, m.motivo, m.localizacao, m.leito, m.centroDeCusto, m.clinicaMedica, m.medico, m.CRM, p.nomePaciente " +
                "FROM mvtMovPac m " +
                "INNER JOIN mvtHospCadPac p ON m.codPaciente = p.codPaciente " +
                "WHERE m.codProntuario = @codProntuario " +
                "ORDER BY m.codSequencia DESC;");
            command.CommandText = sql.ToString();
            command.Parameters.Add(new SqlParameter("@codProntuario", internacao.prontuario));
            command.ExecuteNonQuery();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    movimentacoes.Add(PopulateDr(dr));
                }
            }
            return movimentacoes;
        }
        private MovModel PopulateDr(SqlDataReader dr)
        {
            string codSequencia = "";
            string codPaciente = "";
            string dataMov = "";
            string horaMov = "";
            string motivo = "";
            string localizacao = "";
            string leito = "";
            string centroDeCusto = "";
            string clinicaMedica = "";
            string medico = "";
            string crm = "";
            PacienteModel nomePaciente = null;
            if (DBNull.Value != dr["codSequencia"])
            {
                codSequencia = dr["codSequencia"] + "";
            }
            if (DBNull.Value != dr["codPaciente"])
            {
                codPaciente = dr["codPaciente"] + "";
            }
            if (DBNull.Value != dr["dataMov"])
            {
                dataMov = dr["dataMov"] + "";
            }
            if (DBNull.Value != dr["horaMov"])
            {
                horaMov = dr["horaMov"] + "";
            }
            if (DBNull.Value != dr["motivo"])
            {
                motivo = dr["motivo"] + "";
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
            if (DBNull.Value != dr["clinicaMedica"])
            {
                clinicaMedica = dr["clinicaMedica"] + "";
            }
            if (DBNull.Value != dr["medico"])
            {
                medico = dr["medico"] + "";
            }            
            if (DBNull.Value != dr["CRM"])
            {
                crm = dr["CRM"] + "";
            }
            if (DBNull.Value != dr["nomePaciente"])
            {
                string paciente = dr["nomePaciente"] + "";
                nomePaciente = new PacienteModel()
                {
                    nomePaciente = paciente
                };
            }
            return new MovModel()
            { 
                codSequencia = codSequencia,
                codPaciente = codPaciente,
                dataMov = dataMov,
                horaMov = horaMov,
                motivo = motivo,
                localizacao = localizacao,
                leito = leito,
                centroDeCusto = centroDeCusto,
                clinicaMedica = clinicaMedica,
                medico = medico,
                crm = crm,
                PacienteModel = nomePaciente
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_internacao
{
    public partial class FrmRegistroDeInternacao : Form
    {
        public FrmRegistroDeInternacao()
        {
            InitializeComponent();
            
        }
        public void AbrirSelecaoPaciente()
        { 
            SelecionarPaciente paciente = new SelecionarPaciente();
            paciente.ShowDialog();
            if (string.IsNullOrEmpty(paciente.nome) || string.IsNullOrWhiteSpace(paciente.nome))
            {
                lblNomePaciente.Visible = false;
            }
            else
            {
                txtCodPaciente.Text = paciente.codigo;
                lblNomePaciente.Text = $"Nome: {paciente.nome}, Mãe: {paciente.nomeDaMae}, Idade: {paciente.idadeOf} anos";
                lblNomePaciente.Visible = true;
            }
        }
        public void AbrirSelecaoCentroCusto()
        {
            BuscarCentroCusto centro = new BuscarCentroCusto();
            centro.ShowDialog();
            txtCentroCusto.Text = centro.nomeCentroCusto;
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                InternacaoDAO dao = new InternacaoDAO(connection);
                List<InternacaoModel> internados = dao.GetInternacoes();
                foreach (InternacaoModel internado in internados)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodPaciente.Index].Value = internado.PacienteModel.codPaciente;
                    row.Cells[colNomePaciente.Index].Value = internado.NomeModel.nomePaciente;
                    row.Cells[colProntuario.Index].Value = internado.prontuario;
                    row.Cells[colDataEntrada.Index].Value = internado.dataEntrada.ToString().Substring(0, 10);
                    row.Cells[colHoraEntrada.Index].Value = internado.horaEntrada;
                    row.Cells[colDataSaida.Index].Value = internado.dataSaida;
                    row.Cells[colHoraSaida.Index].Value = internado.horaSaida;
                    row.Cells[colMedico.Index].Value = internado.medico;
                    row.Cells[colLocalizacao.Index].Value = internado.localizacao;
                    row.Cells[colCRM.Index].Value = internado.crm;
                    row.Cells[colClinicaMedica.Index].Value = internado.clinicaMedica;
                    row.Cells[colCentroDeCusto.Index].Value = internado.centroDeCusto;
                    row.Cells[colLeito.Index].Value = internado.leito;
                    row.Cells[colCns.Index].Value = internado.cns;
                    row.Cells[colHipoteseDiagnostica.Index].Value = internado.hipoteseDiagnostica;
                    row.Cells[colDiagnostico.Index].Value = internado.diagnostico;
                    row.Cells[colSituacao.Index].Value = internado.situacao;
                    row.Cells[colMae.Index].Value = internado.MaeModel.mae;
                    row.Cells[colDataNasc.Index].Value = internado.DataNascModel.mae;
                }
            }
        }

        private void FrmRegistroDeInternacao_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadId();
            btnExcluir.Enabled = false;
        }
        private void btnCarregarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecaoPaciente();
        }
        private void ApagarCampos()
        {
            txtCodPaciente.Text = "";
            txtCns.Text = "";
            txtMedico.Text = "";
            txtCrm.Text = "";
            txtClinicaMedica.Text = "";
            txtCentroCusto.Text = "";
            txtLocalizacao.Text = "";
            txtLeito.Text = "";
            txtHipoteseDiagnostica.Text = "";
            txtDiagnostico.Text = "";
            cbxSituacao.SelectedIndex = -1;
        }
        private void LoadId()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtHospRegInt') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());
                txtProntuario.Text = proximoID.ToString();

            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    InternacaoDAO dao = new InternacaoDAO(connection);
                    bool verificaRegistros = dao.Validacoes(new PacienteModel()
                    {
                        codPaciente = txtCodPaciente.Text
                    }, new InternacaoModel()
                    {
                        prontuario = txtProntuario.Text,
                        dataEntrada = dtpDataEntrada.Text,
                        horaEntrada = dtpHoraEntrada.Text,
                        medico = txtMedico.Text,
                        crm = txtCrm.Text,
                        centroDeCusto = txtCentroCusto.Text,
                        leito = txtLeito.Text,
                        situacao = cbxSituacao.Text
                   
                    });
                    if (verificaRegistros)
                    {
                        int count = dao.VerificaRegistros(new InternacaoModel()
                        {
                            prontuario = txtProntuario.Text
                        });

                        if (count > 0)
                        {
                            dao.Alterar(new PacienteModel()
                            {
                                codPaciente = txtCodPaciente.Text
                            }, new InternacaoModel()
                            {
                                prontuario = txtProntuario.Text,
                                dataEntrada = dtpDataEntrada.Value.Date.ToString(),
                                horaEntrada = dtpHoraEntrada.Value.ToString(),
                                dataSaida = dtpDataSaida.Value.Date.ToString(),
                                horaSaida = dtpHoraSaida.Value.ToString(),
                                cns = txtCns.Text,
                                clinicaMedica = txtClinicaMedica.Text,
                                localizacao = txtLocalizacao.Text,
                                leito = txtLeito.Text,
                                centroDeCusto = txtCentroCusto.Text,
                                hipoteseDiagnostica = txtHipoteseDiagnostica.Text,
                                medico = txtMedico.Text,
                                crm = txtCrm.Text,
                                diagnostico = txtDiagnostico.Text,
                                situacao = cbxSituacao.Text

                            });
                            MessageBox.Show("Registro atualizado com sucesso!");
                            ApagarCampos();
                            CarregarUsuariosGrid();
                        }
                        else
                        {
                            dao.Salvar(new PacienteModel()
                            {
                                codPaciente = txtCodPaciente.Text
                            }, new InternacaoModel()
                            {
                                dataEntrada = dtpDataEntrada.Value.Date.ToString(),
                                horaEntrada = dtpHoraEntrada.Value.ToString(),
                                dataSaida = dtpDataSaida.Value.Date.ToString(),
                                horaSaida = dtpHoraSaida.Value.ToString(),
                                cns = txtCns.Text,
                                clinicaMedica = txtClinicaMedica.Text,
                                localizacao = txtLocalizacao.Text,
                                leito = txtLeito.Text,
                                centroDeCusto = txtCentroCusto.Text,
                                hipoteseDiagnostica = txtHipoteseDiagnostica.Text,
                                medico = txtMedico.Text,
                                crm = txtCrm.Text,
                                diagnostico = txtDiagnostico.Text,
                                situacao = cbxSituacao.Text

                            });
                            MessageBox.Show("Registro salvo com sucesso!");
                            ApagarCampos();
                            CarregarUsuariosGrid();
                        }
                    }
                    CarregarUsuariosGrid();
                    LoadId();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o registro!\n{ex.Message}");
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (confirmacao == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        InternacaoDAO dao = new InternacaoDAO(connection);
                        bool verificaRegistros = dao.Validacoes(new PacienteModel()
                        {
                            codPaciente = txtCodPaciente.Text
                        }, new InternacaoModel()
                        {
                            prontuario = txtProntuario.Text,
                            dataEntrada = dtpDataEntrada.Text,
                            horaEntrada = dtpHoraEntrada.Text,
                            medico = txtMedico.Text,
                            crm = txtCrm.Text,
                            centroDeCusto = txtCentroCusto.Text,
                            leito = txtLeito.Text,
                            situacao = cbxSituacao.Text

                        });
                        if (verificaRegistros)
                        {
                            dao.Excluir(new InternacaoModel()
                            {
                                prontuario = txtProntuario.Text
                            });
                        }
                    }
                    MessageBox.Show("Registro excluído com sucesso!");
                    CarregarUsuariosGrid();
                    LoadId();
                    btnExcluir.Enabled = true;
                    ApagarCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o registro!\n{ex.Message}");
            }
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodPaciente.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodPaciente.Index].Value + "";
                txtProntuario.Text = dadosGrid.Rows[e.RowIndex].Cells[colProntuario.Index].Value + "";
                dtpDataEntrada.Text = dadosGrid.Rows[e.RowIndex].Cells[colDataEntrada.Index].Value + "";
                dtpHoraEntrada.Text = dadosGrid.Rows[e.RowIndex].Cells[colHoraEntrada.Index].Value + "";
                dtpDataSaida.Text = dadosGrid.Rows[e.RowIndex].Cells[colDataSaida.Index].Value + "";
                dtpHoraSaida.Text = dadosGrid.Rows[e.RowIndex].Cells[colHoraSaida.Index].Value + "";
                txtCns.Text = dadosGrid.Rows[e.RowIndex].Cells[colCns.Index].Value + "";
                txtMedico.Text = dadosGrid.Rows[e.RowIndex].Cells[colMedico.Index].Value + "";
                txtCrm.Text = dadosGrid.Rows[e.RowIndex].Cells[colCRM.Index].Value + "";
                txtClinicaMedica.Text = dadosGrid.Rows[e.RowIndex].Cells[colClinicaMedica.Index].Value + "";
                txtCentroCusto.Text = dadosGrid.Rows[e.RowIndex].Cells[colCentroDeCusto.Index].Value + "";
                txtLocalizacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value + "";
                txtLeito.Text = dadosGrid.Rows[e.RowIndex].Cells[colLeito.Index].Value + "";
                txtHipoteseDiagnostica.Text = dadosGrid.Rows[e.RowIndex].Cells[colHipoteseDiagnostica.Index].Value + "";
                txtDiagnostico.Text = dadosGrid.Rows[e.RowIndex].Cells[colDiagnostico.Index].Value + "";
                cbxSituacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSituacao.Index].Value + "";
                //lblNomePaciente.Text = $"Nome: {dadosGrid.Rows[e.RowIndex].Cells[colNomePaciente.Index].Value + ""}, Mãe: {dadosGrid.Rows[e.RowIndex].Cells[colMae.Index].Value + ""}, " +
                //    $"Idade: {} anos";
                if (string.IsNullOrEmpty(this.txtCodPaciente.Text))
                {
                    btnExcluir.Enabled = false;

                }
                else
                {
                    btnExcluir.Enabled = true;
                }
            }
        }
        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
        private void btnCarregarCentroCusto_Click(object sender, EventArgs e)
        {
            AbrirSelecaoCentroCusto();
        }
    }
}

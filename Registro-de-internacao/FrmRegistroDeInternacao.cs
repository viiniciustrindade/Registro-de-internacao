using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void FrmRegistroDeInternacao_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCarregarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecaoPaciente();
        }
    }
}

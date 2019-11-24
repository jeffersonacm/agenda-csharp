using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_agenda.Paciente
{
    public partial class PacienteCadastroControl : UserControl
    {
        public PacienteCadastroControl()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Paciente Pac = new Paciente();
            Endereco End = new Endereco();
            Pac.Nome = textNome.Text;
            Pac.Email = textEmail.Text;
            Pac.CPF = mskdCPF.Text;
            Pac.Telefone = textTelefone.Text;
            Pac.DataNasc = dtDataNasc.Value;
            End.Rua = txtRua.Text;
            End.Bairro = txtBairro.Text;
            End.Cidade = txtCidade.Text;
            End.Complemento = txtComp.Text;
            End.Estado = txtEstado.Text;
            End.CEP = mskdCep.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var WS = new WebServiceCEP.AtendeClienteClient())
                {
                    var resultado = WS.consultaCEP(mskdCep.Text);
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtRua.Text = resultado.end;
                    txtEstado.Text = resultado.uf;
                    txtComp.Text = resultado.complemento2;
                }
            }
            catch
            {
                MessageBox.Show("CEP digitado inválido");
            }
        }
    }
}

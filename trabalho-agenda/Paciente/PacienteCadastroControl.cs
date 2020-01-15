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
        List<Paciente> pacientes;
        public PacienteCadastroControl()
        {
            InitializeComponent();
            pesquisarPacientes();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            #region Cadastro de Paciente
            Paciente Pac = new Paciente();
            Endereco End = new Endereco();
            Pac.CPF = mskdCPF.Text;
            if (Pac.cpfExiste())
                MessageBox.Show("CPF ja cadastrado.");
            else
            {
                Pac.Nome = textNome.Text;
                Pac.Email = textEmail.Text;
                Pac.Telefone = textTelefone.Text;
                Pac.DataNasc = dtDataNasc.Value;
                End.Rua = txtRua.Text;
                End.Bairro = txtBairro.Text;
                End.Cidade = txtCidade.Text;
                End.Complemento = txtComp.Text;
                End.Estado = txtEstado.Text;
                End.CEP = mskdCep.Text;
                new EditorXML<Paciente>().Serializar(Pac, "pacientes.xml");
                MessageBox.Show("Paciente Cadastrado!");
            }
            #endregion

            pesquisarPacientes();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string pesquisa = maskedTextBox1.Text;
            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == pesquisa)
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
            }
        }

        private void pesquisarPacientes()
        {
            pacientes = new EditorXML<Paciente>().Deserializar("pacientes.xml");
            dataGridView1.DataSource = pacientes;
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pacientes.RemoveAt(dataGridView1.CurrentRow.Index);
            new EditorXML<Paciente>().Serializar(pacientes, "pacientes.xml", false);
            pesquisarPacientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

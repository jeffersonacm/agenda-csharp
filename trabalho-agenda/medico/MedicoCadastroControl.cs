using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_agenda.Medico
{
    public partial class MedicoCadastroControl : UserControl
    {
        List<Medico> medicos;
        public MedicoCadastroControl()
        {
            InitializeComponent();
            pesquisarMedicos();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.CPF = mskdCPF.Text;
            if (medico.cpfExiste())
                MessageBox.Show("CPF ja cadastrado.");
            else
            {
                medico.Nome = textNome.Text;

                medico.DataNasc = dtDataNasc.Value;
                medico.Email = textEmail.Text;
                medico.Especialidade = selectEspecialidade.Text;
                medico.Telefone = textTelefone.Text;
                Endereco endereco = new Endereco();
                endereco.Bairro = txtBairro.Text;
                endereco.CEP = mskdCep.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.Complemento = txtComp.Text;
                endereco.Estado = txtEstado.Text;
                endereco.Rua = txtRua.Text;
                medico.Endereço = endereco;
                new EditorXML<Medico>().Serializar(medico, "medicos.xml");
                MessageBox.Show("Medico Cadastrado!");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            medicos.RemoveAt(dataGridView1.CurrentRow.Index);
            new EditorXML<Medico>().Serializar(medicos, "medicos.xml", false);
            pesquisarMedicos();
        }

        private void pesquisarMedicos()
        {
            medicos = new EditorXML<Medico>().Deserializar("medicos.xml");
            dataGridView1.DataSource = medicos;
            dataGridView1.ClearSelection();
        }
    }
}

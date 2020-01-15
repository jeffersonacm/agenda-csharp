using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_agenda.Consulta
{
    public partial class ConsultaCadastroControl : UserControl
    {
        List<Consulta> consultas;
        public ConsultaCadastroControl()
        {
            InitializeComponent();
            pesquisarConsultas();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Paciente.Paciente> pacientes = new EditorXML<Paciente.Paciente>().Deserializar("pacientes.xml");
            var pesquisa = from x in pacientes
                           where (x.CPF == maskedTextBox2.Text)                     
                           select x;
            foreach (Paciente.Paciente x in pesquisa)
            {
                textBox1.Text = x.Nome;
                textBox2.Text = x.Telefone;
                textBox3.Text = x.Email;
                dateTimePicker1.Value = x.DataNasc;
            }
        }
        private void carregarGrid()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new EditorXML<Consulta>().Deserializar("consultas.xml");
            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Medico.Medico> pacientes = new EditorXML<Medico.Medico>().Deserializar("medicos.xml");
            var pesquisa = from x in pacientes 
                           where (x.CPF == maskedTextBox1.Text)                         
                           select x;
            foreach (Medico.Medico x in pesquisa)
            {
                textBox6.Text = x.Nome;
                textBox5.Text = x.Telefone;
                textBox4.Text = x.Email;
                comboBox3.SelectedItem = x.Especialidade;
            }
            pesquisarConsultas();
        }

        private void pesquisarConsultas()
        {
            consultas = new EditorXML<Consulta>().Deserializar("consultas.xml");
            dataGridView1.DataSource = consultas;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.nomeMedico = textBox6.Text;
            consulta.nomePaciente = textBox1.Text;
            consulta.data = dateTimePicker2.Value;
            new EditorXML<Consulta>().Serializar(consulta, "consultas.xml");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.nomeMedico = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            consulta.nomePaciente = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            consulta.data = (DateTime) dataGridView1.CurrentRow.Cells[2].Value;
            consultas[dataGridView1.CurrentRow.Index] = consulta;
            new EditorXML<Consulta>().Serializar(consultas, "consultas.xml", false);
        }

        private void ConsultaCadastroControl_Load(object sender, EventArgs e)
        {

        }
    }
}

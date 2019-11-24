using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_agenda.auth;
using trabalho_agenda.Consulta;
using trabalho_agenda.medico;
using trabalho_agenda.Paciente;

namespace trabalho_agenda
{
    public partial class Base : Form
    {
        private MedicoCadastroControl medicoCadControl = new MedicoCadastroControl();
        private PacienteCadastroControl pacienteCadControl = new PacienteCadastroControl();
        private ConsultaCadastroControl consultaCadControl = new ConsultaCadastroControl();

        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        public void ShowLogin()
        {
            authControl1.Location = new Point(2, 2);
            this.menuPanel.Visible = true;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AllNotVisible();
            Controls.Add(this.pacienteCadControl);
            this.pacienteCadControl.Location = new Point(171, 2);
            this.pacienteCadControl.Visible = true;
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            AllNotVisible();
            Controls.Add(this.medicoCadControl);
            this.medicoCadControl.Location = new Point(171, 2);
            this.medicoCadControl.Visible = true;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AllNotVisible();
            Controls.Add(this.consultaCadControl);
            this.consultaCadControl.Location = new Point(171, 2);
            this.consultaCadControl.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AllNotVisible();
            ShowLogin();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AllNotVisible();
        }

        private void AllNotVisible()
        {
            this.medicoCadControl.Visible = false;
            this.pacienteCadControl.Visible = false;
            this.consultaCadControl.Visible = false;
        }
    }
}

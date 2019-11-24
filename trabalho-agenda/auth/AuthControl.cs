using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace trabalho_agenda.Auth
{
    public partial class AuthControl : UserControl
    {
        public AuthControl()
        {
            InitializeComponent();
        }

        private void AuthControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();
            User.CPF = mskdCadCPF.Text;
            User.Nome = txtNome.Text;
            User.Email = txtMail.Text;
            User.Telefone = txtTelefone.Text;
            User.Senha = txtCadSenha.Text;

            bool AchouUser = false;

            EditorXML<Usuario> Ed = new EditorXML<Usuario>();
            List<Usuario> ListaUser = Ed.Deserializar("usuarios.xml", typeof(Usuario));

            foreach (Usuario x in ListaUser)
            {
                if (x.CPF == User.CPF)
                {
                    AchouUser = true;
                }
            }
            if (AchouUser == true)
            {
                MessageBox.Show("CPF Já cadastrado!");
            }
            else
            {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios.Add(User);
                Ed.Serializar(usuarios, "usuarios.xml");
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Usuario User = new Usuario();
            User.CPF = mskdLoginCPF.Text;
            User.Senha = txtLoginSenha.Text;

            EditorXML<Usuario> Ed = new EditorXML<Usuario>();
            List<Usuario> ListUsuarios = (List<Usuario>)Ed.Deserializar("usuarios.xml", typeof(Usuario));

            bool AchouCPF = false;
            bool AchouSenha = false;

            foreach (Usuario x in ListUsuarios)
            {
                if (User.CPF == x.CPF)
                {
                    if (User.Senha == x.Senha)
                    {
                        this.Visible = false;
                    }
                }
            }

            //TOOD não deve estar aqui, usado apenas para criação das telas
            this.Visible = false;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

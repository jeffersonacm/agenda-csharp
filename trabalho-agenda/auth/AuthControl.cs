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
            #region Cadastro Usuario
            Usuario User = new Usuario();
            User.CPF = mskdCadCPF.Text;
            User.Nome = txtNome.Text;
            User.Email = txtMail.Text;
            User.Telefone = txtTelefone.Text;
            User.Senha = txtCadSenha.Text;
            #endregion

            EditorXML<Usuario> Ed = new EditorXML<Usuario>();

            if (User.cpfExiste())
            {
                MessageBox.Show("CPF ja cadastrado.");
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
            List<Usuario> ListUsuarios = (List<Usuario>)Ed.Deserializar("usuarios.xml");

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

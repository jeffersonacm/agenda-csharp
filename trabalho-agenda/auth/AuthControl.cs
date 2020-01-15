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

            if (!validarCadastro(User))
            {
                return;
            }

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

            MessageBox.Show("Cadastro realizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpaCamposCadastro();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Boolean logado = false;
            Usuario User = new Usuario();

            User.CPF = mskdLoginCPF.Text;
            User.Senha = txtLoginSenha.Text;

            if(! validarLogin(User))
            {
                return;
            }

            EditorXML<Usuario> Ed = new EditorXML<Usuario>();
            List<Usuario> ListUsuarios = (List<Usuario>)Ed.Deserializar("usuarios.xml");

            foreach (Usuario x in ListUsuarios)
            {
                if (User.CPF == x.CPF)
                {
                    if (User.Senha == x.Senha)
                    {

                        this.Visible = false;
                        logado = true;
                    }
                }
            }

            if(!logado)
                MessageBox.Show("Login ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean validarLogin(Usuario usuario)
        {
            if (usuario.CPF == "" || usuario.CPF == "   .   .   -")
            {
                MessageBox.Show("Informe o CPF!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskdLoginCPF.Focus();
                return false;

            } else if (usuario.Senha == "")
            {
                MessageBox.Show("Informe a senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCadSenha.Focus();
                return false;
            }

            return true;
        }

        private Boolean validarCadastro(Usuario User)
        {
            if(User.Nome == "")
            {
                MessageBox.Show("Informe o nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            else if (User.Telefone == "")
            {
                MessageBox.Show("Informe o telefone de contato!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return false;
            }
            else if (!validarLogin(User))
            {
                return false;

            } 

            return true;
        }

        public void limpaCamposCadastro()
        {
            txtCadSenha.Text = "";
            txtMail.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            mskdCadCPF.Text = "";
        }
    }
}

namespace trabalho_agenda.Medico
{
    partial class MedicoCadastroControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.maskedTextCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textEspecialidade = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoSang = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.mskdCep = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(23, 173);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(126, 20);
            this.dateTimeNascimento.TabIndex = 27;
            // 
            // maskedTextCPF
            // 
            this.maskedTextCPF.Location = new System.Drawing.Point(277, 173);
            this.maskedTextCPF.Mask = "000,000,000-00";
            this.maskedTextCPF.Name = "maskedTextCPF";
            this.maskedTextCPF.Size = new System.Drawing.Size(110, 20);
            this.maskedTextCPF.TabIndex = 24;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(274, 153);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:";
            // 
            // textEspecialidade
            // 
            this.textEspecialidade.Location = new System.Drawing.Point(166, 172);
            this.textEspecialidade.Name = "textEspecialidade";
            this.textEspecialidade.Size = new System.Drawing.Size(93, 20);
            this.textEspecialidade.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(23, 128);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(364, 20);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(23, 84);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(364, 20);
            this.textTelefone.TabIndex = 19;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(23, 40);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(364, 20);
            this.textNome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de nascimento:";
            // 
            // lblTipoSang
            // 
            this.lblTipoSang.AutoSize = true;
            this.lblTipoSang.Location = new System.Drawing.Point(163, 153);
            this.lblTipoSang.Name = "lblTipoSang";
            this.lblTipoSang.Size = new System.Drawing.Size(76, 13);
            this.lblTipoSang.TabIndex = 16;
            this.lblTipoSang.Text = "Especialidade:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(20, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(20, 65);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Location = new System.Drawing.Point(686, 66);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 23);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrar.Location = new System.Drawing.Point(581, 66);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(89, 23);
            this.buttonCadastrar.TabIndex = 55;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(22, 183);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(171, 20);
            this.txtComp.TabIndex = 54;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(22, 164);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(74, 13);
            this.lblComp.TabIndex = 53;
            this.lblComp.Text = "Complemento:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(209, 183);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(180, 20);
            this.txtEstado.TabIndex = 52;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(209, 139);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(180, 20);
            this.txtCidade.TabIndex = 51;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(22, 139);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(171, 20);
            this.txtBairro.TabIndex = 50;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(22, 94);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(367, 20);
            this.txtRua.TabIndex = 49;
            // 
            // mskdCep
            // 
            this.mskdCep.Location = new System.Drawing.Point(22, 50);
            this.mskdCep.Mask = "00000-000";
            this.mskdCep.Name = "mskdCep";
            this.mskdCep.Size = new System.Drawing.Size(129, 20);
            this.mskdCep.TabIndex = 48;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(168, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(221, 23);
            this.btnConsultar.TabIndex = 47;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(207, 164);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(43, 13);
            this.lblUF.TabIndex = 46;
            this.lblUF.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(206, 119);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 45;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(19, 119);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 44;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(22, 75);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 43;
            this.lblRua.Text = "Rua:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(19, 30);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 42;
            this.lblCEP.Text = "CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdCep);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Controls.Add(this.lblRua);
            this.groupBox1.Controls.Add(this.txtComp);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.lblComp);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Location = new System.Drawing.Point(155, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 233);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.textTelefone);
            this.groupBox2.Controls.Add(this.textNome);
            this.groupBox2.Controls.Add(this.dateTimeNascimento);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textEspecialidade);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.lblTipoSang);
            this.groupBox2.Controls.Add(this.maskedTextCPF);
            this.groupBox2.Controls.Add(this.lblCPF);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Location = new System.Drawing.Point(155, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 218);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // MedicoCadastroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "MedicoCadastroControl";
            this.Size = new System.Drawing.Size(805, 590);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textEspecialidade;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoSang;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox mskdCep;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

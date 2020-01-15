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
            System.Windows.Forms.Label label2;
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mskdCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.selectEspecialidade = new System.Windows.Forms.ComboBox();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoSang = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 262);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 13);
            label2.TabIndex = 56;
            label2.Text = "CPF:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(46, 259);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBox1.TabIndex = 57;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(208, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 24);
            this.button3.TabIndex = 55;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(139, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 54;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 288);
            this.dataGridView1.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCEP);
            this.groupBox2.Controls.Add(this.lblRua);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtComp);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.lblComp);
            this.groupBox2.Controls.Add(this.lblUF);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.mskdCep);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtRua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(407, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 217);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(10, 16);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(38, 16);
            this.lblCEP.TabIndex = 29;
            this.lblCEP.Text = "CEP:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(9, 63);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 16);
            this.lblRua.TabIndex = 30;
            this.lblRua.Text = "Rua:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 107);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 16);
            this.lblBairro.TabIndex = 31;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(9, 171);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(171, 22);
            this.txtComp.TabIndex = 41;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(193, 107);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 16);
            this.lblCidade.TabIndex = 32;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(9, 152);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(95, 16);
            this.lblComp.TabIndex = 40;
            this.lblComp.Text = "Complemento:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(194, 152);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(54, 16);
            this.lblUF.TabIndex = 33;
            this.lblUF.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(196, 171);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(180, 22);
            this.txtEstado.TabIndex = 39;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(155, 37);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(221, 23);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(196, 127);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(180, 22);
            this.txtCidade.TabIndex = 38;
            // 
            // mskdCep
            // 
            this.mskdCep.Location = new System.Drawing.Point(9, 38);
            this.mskdCep.Mask = "00000-000";
            this.mskdCep.Name = "mskdCep";
            this.mskdCep.Size = new System.Drawing.Size(129, 22);
            this.mskdCep.TabIndex = 35;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(9, 127);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(171, 22);
            this.txtBairro.TabIndex = 37;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(9, 82);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(367, 22);
            this.txtRua.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDataNasc);
            this.groupBox1.Controls.Add(this.selectEspecialidade);
            this.groupBox1.Controls.Add(this.mskdCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textTelefone);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTipoSang);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 217);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(13, 172);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(126, 22);
            this.dtDataNasc.TabIndex = 26;
            // 
            // selectEspecialidade
            // 
            this.selectEspecialidade.FormattingEnabled = true;
            this.selectEspecialidade.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.selectEspecialidade.Location = new System.Drawing.Point(156, 170);
            this.selectEspecialidade.Name = "selectEspecialidade";
            this.selectEspecialidade.Size = new System.Drawing.Size(93, 24);
            this.selectEspecialidade.TabIndex = 25;
            // 
            // mskdCPF
            // 
            this.mskdCPF.Location = new System.Drawing.Point(267, 171);
            this.mskdCPF.Mask = "###,###,###-##";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(110, 22);
            this.mskdCPF.TabIndex = 24;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(264, 151);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 16);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(13, 126);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(364, 22);
            this.textEmail.TabIndex = 20;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(13, 82);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(364, 22);
            this.textTelefone.TabIndex = 19;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(13, 38);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(364, 22);
            this.textNome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de nascimento:";
            // 
            // lblTipoSang
            // 
            this.lblTipoSang.AutoSize = true;
            this.lblTipoSang.Location = new System.Drawing.Point(153, 151);
            this.lblTipoSang.Name = "lblTipoSang";
            this.lblTipoSang.Size = new System.Drawing.Size(99, 16);
            this.lblTipoSang.TabIndex = 16;
            this.lblTipoSang.Text = "Especialidade:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(10, 107);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 16);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(10, 63);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 16);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCadastrar.Location = new System.Drawing.Point(618, 225);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(180, 23);
            this.buttonCadastrar.TabIndex = 52;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // MedicoCadastroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "MedicoCadastroControl";
            this.Size = new System.Drawing.Size(811, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mskdCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.ComboBox selectEspecialidade;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoSang;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}

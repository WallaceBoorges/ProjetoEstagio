namespace GUI
{
    partial class frmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCentro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtBancoConta = new System.Windows.Forms.TextBox();
            this.txtBancoAgencia = new System.Windows.Forms.TextBox();
            this.txtBancoNome = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultaFuncionario = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoexercida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariobase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banconome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoagencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoconta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoEndereco = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRsocial = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnDemissao = new System.Windows.Forms.Button();
            this.dtpDataAdimissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataNacimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbxFunção = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 319);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 358;
            this.label15.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(345, 343);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 20);
            this.txtNumero.TabIndex = 357;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(341, 383);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(136, 20);
            this.txtCep.TabIndex = 356;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(339, 367);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 355;
            this.lblCep.Text = "CEP";
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Location = new System.Drawing.Point(411, 319);
            this.lblCentro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(34, 13);
            this.lblCentro.TabIndex = 354;
            this.lblCentro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(413, 343);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(136, 20);
            this.txtBairro.TabIndex = 353;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(187, 383);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(136, 20);
            this.txtEstado.TabIndex = 352;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(185, 367);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 351;
            this.lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(19, 383);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(136, 20);
            this.txtCidade.TabIndex = 350;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(17, 367);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 349;
            this.lblCidade.Text = "Cidade";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(20, 343);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(307, 20);
            this.txtEndereco.TabIndex = 348;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(21, 327);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 347;
            this.lblEndereco.Text = "Endereço";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(105, 492);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 340;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 492);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 339;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 492);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 338;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtBancoConta
            // 
            this.txtBancoConta.Location = new System.Drawing.Point(349, 285);
            this.txtBancoConta.Margin = new System.Windows.Forms.Padding(2);
            this.txtBancoConta.Name = "txtBancoConta";
            this.txtBancoConta.Size = new System.Drawing.Size(136, 20);
            this.txtBancoConta.TabIndex = 337;
            // 
            // txtBancoAgencia
            // 
            this.txtBancoAgencia.Location = new System.Drawing.Point(194, 285);
            this.txtBancoAgencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtBancoAgencia.Name = "txtBancoAgencia";
            this.txtBancoAgencia.Size = new System.Drawing.Size(136, 20);
            this.txtBancoAgencia.TabIndex = 336;
            // 
            // txtBancoNome
            // 
            this.txtBancoNome.Location = new System.Drawing.Point(28, 285);
            this.txtBancoNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtBancoNome.Name = "txtBancoNome";
            this.txtBancoNome.Size = new System.Drawing.Size(136, 20);
            this.txtBancoNome.TabIndex = 335;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(189, 213);
            this.txtSalarioBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(136, 20);
            this.txtSalarioBase.TabIndex = 334;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 327;
            this.label14.Text = "Conta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(191, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 326;
            this.label13.Text = " Agência";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 325;
            this.label12.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 324;
            this.label11.Text = "Salário Base";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 322;
            this.label9.Text = "Admissão";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 321;
            this.label8.Text = "Função Exercida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 319;
            this.label6.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 317;
            this.label5.Text = "Sexo";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(336, 36);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(156, 20);
            this.txtSenha.TabIndex = 316;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(184, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 20);
            this.txtUsuario.TabIndex = 315;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 314;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 313;
            this.label3.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 527);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 312;
            this.label1.Text = "Funcionário";
            // 
            // txtConsultaFuncionario
            // 
            this.txtConsultaFuncionario.Location = new System.Drawing.Point(24, 543);
            this.txtConsultaFuncionario.Name = "txtConsultaFuncionario";
            this.txtConsultaFuncionario.Size = new System.Drawing.Size(416, 20);
            this.txtConsultaFuncionario.TabIndex = 311;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(525, 589);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 310;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(525, 543);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 309;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(444, 543);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 308;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nome,
            this.usuario,
            this.senha,
            this.cpf,
            this.rg,
            this.datanascimento,
            this.sexo,
            this.estadocivil,
            this.celular,
            this.funcaoexercida,
            this.admissao,
            this.demissao,
            this.salariobase,
            this.banconome,
            this.bancoagencia,
            this.bancoconta});
            this.dgvFuncionario.Location = new System.Drawing.Point(24, 569);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(495, 153);
            this.dgvFuncionario.TabIndex = 307;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "fun_cod";
            this.cod.HeaderText = "Código";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "fun_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "fun_usuario";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "fun_senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "fun_cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "fun_rg";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // datanascimento
            // 
            this.datanascimento.DataPropertyName = "fun_datanascimento";
            this.datanascimento.HeaderText = "Data de Nascimento";
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "fun_sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // estadocivil
            // 
            this.estadocivil.DataPropertyName = "fun_estadocivil";
            this.estadocivil.HeaderText = "Estado Civil";
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "fun_celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // funcaoexercida
            // 
            this.funcaoexercida.DataPropertyName = "fun_funcaoexercida";
            this.funcaoexercida.HeaderText = "Função";
            this.funcaoexercida.Name = "funcaoexercida";
            this.funcaoexercida.ReadOnly = true;
            // 
            // admissao
            // 
            this.admissao.DataPropertyName = "fun_admissao";
            this.admissao.HeaderText = "Admissão";
            this.admissao.Name = "admissao";
            this.admissao.ReadOnly = true;
            // 
            // demissao
            // 
            this.demissao.DataPropertyName = "fun_demissao";
            this.demissao.HeaderText = "Demissão";
            this.demissao.Name = "demissao";
            this.demissao.ReadOnly = true;
            // 
            // salariobase
            // 
            this.salariobase.DataPropertyName = "fun_salariobase";
            this.salariobase.HeaderText = "Salário Base";
            this.salariobase.Name = "salariobase";
            this.salariobase.ReadOnly = true;
            this.salariobase.Visible = false;
            // 
            // banconome
            // 
            this.banconome.DataPropertyName = "fun_banconome";
            this.banconome.HeaderText = "Nome do Banco";
            this.banconome.Name = "banconome";
            this.banconome.ReadOnly = true;
            // 
            // bancoagencia
            // 
            this.bancoagencia.DataPropertyName = "fun_bancoagencia";
            this.bancoagencia.HeaderText = "Agência do Banco";
            this.bancoagencia.Name = "bancoagencia";
            this.bancoagencia.ReadOnly = true;
            // 
            // bancoconta
            // 
            this.bancoconta.DataPropertyName = "fun_bancoconta";
            this.bancoconta.HeaderText = "Conta do Banco";
            this.bancoconta.Name = "bancoconta";
            this.bancoconta.ReadOnly = true;
            // 
            // txtCodigoEndereco
            // 
            this.txtCodigoEndereco.Enabled = false;
            this.txtCodigoEndereco.Location = new System.Drawing.Point(102, 33);
            this.txtCodigoEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoEndereco.Name = "txtCodigoEndereco";
            this.txtCodigoEndereco.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoEndereco.TabIndex = 306;
            this.txtCodigoEndereco.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(28, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigo.TabIndex = 305;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 17);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 304;
            this.lblCodigo.Text = "Código";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(190, 106);
            this.lblRG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 303;
            this.lblRG.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(190, 122);
            this.txtRg.Margin = new System.Windows.Forms.Padding(2);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(136, 20);
            this.txtRg.TabIndex = 302;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(24, 122);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(136, 20);
            this.txtCpf.TabIndex = 301;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(25, 106);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 300;
            this.lblCpf.Text = "CPF";
            // 
            // lblRsocial
            // 
            this.lblRsocial.AutoSize = true;
            this.lblRsocial.Location = new System.Drawing.Point(345, 105);
            this.lblRsocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRsocial.Name = "lblRsocial";
            this.lblRsocial.Size = new System.Drawing.Size(104, 13);
            this.lblRsocial.TabIndex = 298;
            this.lblRsocial.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 57);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 297;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 74);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 20);
            this.txtNome.TabIndex = 296;
            // 
            // btnDemissao
            // 
            this.btnDemissao.Location = new System.Drawing.Point(525, 641);
            this.btnDemissao.Name = "btnDemissao";
            this.btnDemissao.Size = new System.Drawing.Size(75, 23);
            this.btnDemissao.TabIndex = 359;
            this.btnDemissao.Text = "Demissão";
            this.btnDemissao.UseVisualStyleBackColor = true;
            this.btnDemissao.Click += new System.EventHandler(this.btnDemissao_Click);
            // 
            // dtpDataAdimissao
            // 
            this.dtpDataAdimissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdimissao.Location = new System.Drawing.Point(24, 210);
            this.dtpDataAdimissao.Name = "dtpDataAdimissao";
            this.dtpDataAdimissao.Size = new System.Drawing.Size(113, 20);
            this.dtpDataAdimissao.TabIndex = 361;
            // 
            // dtpDataNacimento
            // 
            this.dtpDataNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNacimento.Location = new System.Drawing.Point(348, 121);
            this.dtpDataNacimento.Name = "dtpDataNacimento";
            this.dtpDataNacimento.Size = new System.Drawing.Size(113, 20);
            this.dtpDataNacimento.TabIndex = 362;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 328;
            this.label2.Text = "Dados do Banco:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cbxSexo.Location = new System.Drawing.Point(349, 209);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(121, 21);
            this.cbxSexo.TabIndex = 363;
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro ",
            "Divorciado",
            "Viúvo"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(24, 164);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoCivil.TabIndex = 364;
            // 
            // cbxFunção
            // 
            this.cbxFunção.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFunção.FormattingEnabled = true;
            this.cbxFunção.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Vendedor",
            "Estoque",
            "Entregador"});
            this.cbxFunção.Location = new System.Drawing.Point(348, 164);
            this.cbxFunção.Name = "cbxFunção";
            this.cbxFunção.Size = new System.Drawing.Size(121, 21);
            this.cbxFunção.TabIndex = 365;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 366;
            this.label7.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(193, 164);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 367;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 733);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxFunção);
            this.Controls.Add(this.cbxEstadoCivil);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.dtpDataNacimento);
            this.Controls.Add(this.dtpDataAdimissao);
            this.Controls.Add(this.btnDemissao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblCentro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBancoConta);
            this.Controls.Add(this.txtBancoAgencia);
            this.Controls.Add(this.txtBancoNome);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultaFuncionario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.txtCodigoEndereco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblRsocial);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtBancoConta;
        private System.Windows.Forms.TextBox txtBancoAgencia;
        private System.Windows.Forms.TextBox txtBancoNome;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaFuncionario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TextBox txtCodigoEndereco;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRsocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnDemissao;
        private System.Windows.Forms.DateTimePicker dtpDataAdimissao;
        private System.Windows.Forms.DateTimePicker dtpDataNacimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.ComboBox cbxFunção;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoexercida;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn demissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariobase;
        private System.Windows.Forms.DataGridViewTextBoxColumn banconome;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoagencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoconta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
    }
}
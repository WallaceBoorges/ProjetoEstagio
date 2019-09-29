namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.txtCodigoEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultaFornecedor = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.fornecedor_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_cod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.lblIe = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.lblRsocial = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoEndereco
            // 
            this.txtCodigoEndereco.Enabled = false;
            this.txtCodigoEndereco.Location = new System.Drawing.Point(82, 17);
            this.txtCodigoEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoEndereco.Name = "txtCodigoEndereco";
            this.txtCodigoEndereco.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoEndereco.TabIndex = 169;
            this.txtCodigoEndereco.Visible = false;
            this.txtCodigoEndereco.TextChanged += new System.EventHandler(this.txtCodigoEndereco_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 168;
            this.label2.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(326, 144);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 20);
            this.txtNumero.TabIndex = 167;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 166;
            this.label1.Text = "Fornecedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConsultaFornecedor
            // 
            this.txtConsultaFornecedor.Location = new System.Drawing.Point(2, 355);
            this.txtConsultaFornecedor.Name = "txtConsultaFornecedor";
            this.txtConsultaFornecedor.Size = new System.Drawing.Size(416, 20);
            this.txtConsultaFornecedor.TabIndex = 165;
            this.txtConsultaFornecedor.TextChanged += new System.EventHandler(this.txtConsultaFornecedor_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(503, 425);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 164;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(503, 379);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 163;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(422, 350);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 162;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(86, 290);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 161;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(166, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 160;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornecedor_cod,
            this.nome,
            this.rsocial,
            this.ie,
            this.cnpj,
            this.fone,
            this.celular,
            this.email,
            this.endereco_cod,
            this.endereco_cod1,
            this.cep,
            this.logradouro,
            this.bairro,
            this.numero,
            this.cidade,
            this.estado});
            this.dgvFornecedor.Location = new System.Drawing.Point(2, 379);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.Size = new System.Drawing.Size(495, 153);
            this.dgvFornecedor.TabIndex = 159;
            this.dgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellContentClick);
            // 
            // fornecedor_cod
            // 
            this.fornecedor_cod.DataPropertyName = "fornecedor_cod";
            this.fornecedor_cod.HeaderText = "Código";
            this.fornecedor_cod.Name = "fornecedor_cod";
            this.fornecedor_cod.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "fornecedor_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // rsocial
            // 
            this.rsocial.DataPropertyName = "fornecedor_rsocial";
            this.rsocial.HeaderText = "Razão Social";
            this.rsocial.Name = "rsocial";
            this.rsocial.ReadOnly = true;
            // 
            // ie
            // 
            this.ie.DataPropertyName = "fornecedor_ie";
            this.ie.HeaderText = "IE";
            this.ie.Name = "ie";
            this.ie.ReadOnly = true;
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "fornecedor_cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            // 
            // fone
            // 
            this.fone.DataPropertyName = "fornecedor_fone";
            this.fone.HeaderText = "Telefone";
            this.fone.Name = "fone";
            this.fone.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "fornecedor_cel";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "fornecedor_email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // endereco_cod
            // 
            this.endereco_cod.DataPropertyName = "endereco_cod";
            this.endereco_cod.HeaderText = "endereco_cod";
            this.endereco_cod.Name = "endereco_cod";
            this.endereco_cod.ReadOnly = true;
            this.endereco_cod.Visible = false;
            // 
            // endereco_cod1
            // 
            this.endereco_cod1.DataPropertyName = "endereco_cod1";
            this.endereco_cod1.HeaderText = "endereco_cod";
            this.endereco_cod1.Name = "endereco_cod1";
            this.endereco_cod1.ReadOnly = true;
            this.endereco_cod1.Visible = false;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "endereco_cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "endereco_logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "endereco_bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "endereco_numero";
            this.numero.HeaderText = "N°";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "endereco_cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "endereco_estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(8, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigo.TabIndex = 158;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(5, 1);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 157;
            this.lblCodigo.Text = "Código";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(5, 290);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 156;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(324, 191);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(136, 20);
            this.txtCep.TabIndex = 155;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(322, 175);
            this.lblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 154;
            this.lblCep.Text = "CEP";
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Location = new System.Drawing.Point(392, 120);
            this.lblCentro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(34, 13);
            this.lblCentro.TabIndex = 153;
            this.lblCentro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(394, 144);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(136, 20);
            this.txtBairro.TabIndex = 152;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(170, 191);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(136, 20);
            this.txtEstado.TabIndex = 151;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(168, 175);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 150;
            this.lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(2, 191);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(136, 20);
            this.txtCidade.TabIndex = 149;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(0, 175);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 148;
            this.lblCidade.Text = "Cidade";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(1, 144);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(307, 20);
            this.txtEndereco.TabIndex = 147;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(2, 128);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 146;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(322, 223);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 145;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(326, 239);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 144;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(168, 223);
            this.lblCel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(84, 13);
            this.lblCel.TabIndex = 143;
            this.lblCel.Text = "Telefone Celular";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(170, 239);
            this.txtCel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(136, 20);
            this.txtCel.TabIndex = 142;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(0, 223);
            this.lblFone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(71, 13);
            this.lblFone.TabIndex = 141;
            this.lblFone.Text = "Telefone Fixo";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(1, 239);
            this.txtFone.Margin = new System.Windows.Forms.Padding(2);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(136, 20);
            this.txtFone.TabIndex = 140;
            this.txtFone.TextChanged += new System.EventHandler(this.txtFone_TextChanged);
            this.txtFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFone_KeyPress);
            // 
            // lblIe
            // 
            this.lblIe.AutoSize = true;
            this.lblIe.Location = new System.Drawing.Point(170, 91);
            this.lblIe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIe.Name = "lblIe";
            this.lblIe.Size = new System.Drawing.Size(94, 13);
            this.lblIe.TabIndex = 139;
            this.lblIe.Text = "Inscrição Estadual";
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(170, 107);
            this.txtIe.Margin = new System.Windows.Forms.Padding(2);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(136, 20);
            this.txtIe.TabIndex = 138;
            this.txtIe.TextChanged += new System.EventHandler(this.txtIe_TextChanged);
            this.txtIe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIe_KeyPress);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(4, 107);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(2);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(136, 20);
            this.txtCnpj.TabIndex = 137;
            this.txtCnpj.TextChanged += new System.EventHandler(this.txtCnpj_TextChanged);
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(5, 91);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 136;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(324, 58);
            this.txtRsocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(277, 20);
            this.txtRsocial.TabIndex = 135;
            this.txtRsocial.TextChanged += new System.EventHandler(this.txtRsocial_TextChanged);
            // 
            // lblRsocial
            // 
            this.lblRsocial.AutoSize = true;
            this.lblRsocial.Location = new System.Drawing.Point(323, 41);
            this.lblRsocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRsocial.Name = "lblRsocial";
            this.lblRsocial.Size = new System.Drawing.Size(70, 13);
            this.lblRsocial.TabIndex = 134;
            this.lblRsocial.Text = "Razão Social";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 41);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 133;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(4, 58);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 20);
            this.txtNome.TabIndex = 132;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 558);
            this.Controls.Add(this.txtCodigoEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultaFornecedor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
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
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.lblIe);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtRsocial);
            this.Controls.Add(this.lblRsocial);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastroFornecedor";
            this.Text = "frmFornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaFornecedor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label lblIe;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.Label lblRsocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_cod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}
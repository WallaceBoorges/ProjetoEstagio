namespace GUI
{
    partial class frmCadastrarCompra
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
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cbxQuantParcela = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.cbxTipoPagamento = new System.Windows.Forms.ComboBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.CompraCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraNumeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorRSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.itensCompra_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensCompra_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensCompra_qtdeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensCompra_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensCompra_codigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensCompra_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniMedida_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoria_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(22, 112);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(200, 20);
            this.txtNotaFiscal.TabIndex = 30;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(19, 57);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 13);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Data Compra";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(22, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 20);
            this.txtCodigo.TabIndex = 28;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(19, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(98, 243);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 86;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(17, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 84;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Location = new System.Drawing.Point(22, 73);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(232, 20);
            this.dtpDataCompra.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nota Fiscal";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(263, 96);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 90;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(266, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 89;
            this.txtValor.Text = "0,00";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(22, 138);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(48, 13);
            this.lblParcela.TabIndex = 92;
            this.lblParcela.Text = "Parcelas";
            // 
            // cbxQuantParcela
            // 
            this.cbxQuantParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantParcela.FormattingEnabled = true;
            this.cbxQuantParcela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxQuantParcela.Location = new System.Drawing.Point(22, 154);
            this.cbxQuantParcela.Name = "cbxQuantParcela";
            this.cbxQuantParcela.Size = new System.Drawing.Size(121, 21);
            this.cbxQuantParcela.TabIndex = 91;
            this.cbxQuantParcela.SelectedIndexChanged += new System.EventHandler(this.cbxQuantParcela_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(266, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 94;
            this.lblStatus.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "AGUARDANDO",
            "FINALIZADA",
            "CANCELADA"});
            this.cbxStatus.Location = new System.Drawing.Point(266, 154);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 93;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(22, 186);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 96;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(22, 202);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbxFornecedor.TabIndex = 95;
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Location = new System.Drawing.Point(158, 186);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(85, 13);
            this.lblTipoPagamento.TabIndex = 98;
            this.lblTipoPagamento.Text = "Tipo Pagamento";
            // 
            // cbxTipoPagamento
            // 
            this.cbxTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPagamento.FormattingEnabled = true;
            this.cbxTipoPagamento.Location = new System.Drawing.Point(158, 202);
            this.cbxTipoPagamento.Name = "cbxTipoPagamento";
            this.cbxTipoPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoPagamento.TabIndex = 97;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(766, 243);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProduto.TabIndex = 101;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(676, 243);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduto.TabIndex = 103;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Valor";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Enabled = false;
            this.txtValorParcela.Location = new System.Drawing.Point(158, 155);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(92, 20);
            this.txtValorParcela.TabIndex = 104;
            this.txtValorParcela.Text = "0,00";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(766, 341);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 110;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(766, 295);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 109;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompraCod,
            this.CompraData,
            this.CompraNotaFiscal,
            this.CompraTotal,
            this.CompraNumeroParcela,
            this.CompraStatus,
            this.TipoPagCod,
            this.TipoPagNome,
            this.FornecedorCod,
            this.FornecedorNome,
            this.FornecedorRSocial,
            this.FornecedorIE,
            this.FornecedorCnpj,
            this.FornecedorFone,
            this.FornecedorCel,
            this.FornecedorEmail,
            this.EnderecoCod});
            this.dgvCompra.Location = new System.Drawing.Point(17, 295);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(734, 189);
            this.dgvCompra.TabIndex = 108;
            // 
            // CompraCod
            // 
            this.CompraCod.DataPropertyName = "compra_cod";
            this.CompraCod.HeaderText = "Código";
            this.CompraCod.Name = "CompraCod";
            this.CompraCod.ReadOnly = true;
            this.CompraCod.Visible = false;
            // 
            // CompraData
            // 
            this.CompraData.DataPropertyName = "compra_data";
            this.CompraData.HeaderText = "Data";
            this.CompraData.Name = "CompraData";
            this.CompraData.ReadOnly = true;
            // 
            // CompraNotaFiscal
            // 
            this.CompraNotaFiscal.DataPropertyName = "compra_nfiscal";
            this.CompraNotaFiscal.HeaderText = "Nota Fiscal";
            this.CompraNotaFiscal.Name = "CompraNotaFiscal";
            this.CompraNotaFiscal.ReadOnly = true;
            this.CompraNotaFiscal.Width = 125;
            // 
            // CompraTotal
            // 
            this.CompraTotal.DataPropertyName = "compra_total";
            this.CompraTotal.HeaderText = "Total";
            this.CompraTotal.Name = "CompraTotal";
            this.CompraTotal.ReadOnly = true;
            // 
            // CompraNumeroParcela
            // 
            this.CompraNumeroParcela.DataPropertyName = "compra_nparcelas";
            this.CompraNumeroParcela.HeaderText = "Numero Parcela";
            this.CompraNumeroParcela.Name = "CompraNumeroParcela";
            this.CompraNumeroParcela.ReadOnly = true;
            this.CompraNumeroParcela.Width = 150;
            // 
            // CompraStatus
            // 
            this.CompraStatus.DataPropertyName = "compra_status";
            this.CompraStatus.HeaderText = "Status";
            this.CompraStatus.Name = "CompraStatus";
            this.CompraStatus.ReadOnly = true;
            // 
            // TipoPagCod
            // 
            this.TipoPagCod.DataPropertyName = "tipoPag_cod";
            this.TipoPagCod.HeaderText = "Código Pagamento";
            this.TipoPagCod.Name = "TipoPagCod";
            this.TipoPagCod.ReadOnly = true;
            this.TipoPagCod.Visible = false;
            // 
            // TipoPagNome
            // 
            this.TipoPagNome.DataPropertyName = "tipoPag_nome";
            this.TipoPagNome.HeaderText = "Pagamento";
            this.TipoPagNome.Name = "TipoPagNome";
            this.TipoPagNome.ReadOnly = true;
            // 
            // FornecedorCod
            // 
            this.FornecedorCod.DataPropertyName = "fornecedor_cod";
            this.FornecedorCod.HeaderText = "Código Fornecedor";
            this.FornecedorCod.Name = "FornecedorCod";
            this.FornecedorCod.ReadOnly = true;
            this.FornecedorCod.Visible = false;
            // 
            // FornecedorNome
            // 
            this.FornecedorNome.DataPropertyName = "fornecedor_nome";
            this.FornecedorNome.HeaderText = "Nome";
            this.FornecedorNome.Name = "FornecedorNome";
            this.FornecedorNome.ReadOnly = true;
            this.FornecedorNome.Visible = false;
            // 
            // FornecedorRSocial
            // 
            this.FornecedorRSocial.DataPropertyName = "fornecedor_rsocial";
            this.FornecedorRSocial.HeaderText = "Razão Social";
            this.FornecedorRSocial.Name = "FornecedorRSocial";
            this.FornecedorRSocial.ReadOnly = true;
            this.FornecedorRSocial.Visible = false;
            // 
            // FornecedorIE
            // 
            this.FornecedorIE.DataPropertyName = "fornecedor_ie";
            this.FornecedorIE.HeaderText = "IE";
            this.FornecedorIE.Name = "FornecedorIE";
            this.FornecedorIE.ReadOnly = true;
            this.FornecedorIE.Visible = false;
            // 
            // FornecedorCnpj
            // 
            this.FornecedorCnpj.DataPropertyName = "fornecedor_cnpj";
            this.FornecedorCnpj.HeaderText = "CNPJ";
            this.FornecedorCnpj.Name = "FornecedorCnpj";
            this.FornecedorCnpj.ReadOnly = true;
            this.FornecedorCnpj.Visible = false;
            // 
            // FornecedorFone
            // 
            this.FornecedorFone.DataPropertyName = "fornecedor_fone";
            this.FornecedorFone.HeaderText = "Telefone";
            this.FornecedorFone.Name = "FornecedorFone";
            this.FornecedorFone.ReadOnly = true;
            this.FornecedorFone.Visible = false;
            // 
            // FornecedorCel
            // 
            this.FornecedorCel.DataPropertyName = "fornecedor_cel";
            this.FornecedorCel.HeaderText = "Celular";
            this.FornecedorCel.Name = "FornecedorCel";
            this.FornecedorCel.ReadOnly = true;
            this.FornecedorCel.Visible = false;
            // 
            // FornecedorEmail
            // 
            this.FornecedorEmail.DataPropertyName = "fornecedor_email";
            this.FornecedorEmail.HeaderText = "Email";
            this.FornecedorEmail.Name = "FornecedorEmail";
            this.FornecedorEmail.ReadOnly = true;
            this.FornecedorEmail.Visible = false;
            // 
            // EnderecoCod
            // 
            this.EnderecoCod.DataPropertyName = "endereco_cod";
            this.EnderecoCod.HeaderText = "Código Endereço";
            this.EnderecoCod.Name = "EnderecoCod";
            this.EnderecoCod.ReadOnly = true;
            this.EnderecoCod.Visible = false;
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Location = new System.Drawing.Point(584, 243);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarProduto.TabIndex = 111;
            this.btnAlterarProduto.Text = "Alterar";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itensCompra_cod,
            this.itensCompra_qtde,
            this.itensCompra_qtdeVenda,
            this.itensCompra_valor,
            this.itensCompra_codigoBarra,
            this.itensCompra_vencimento,
            this.produto_cod,
            this.produto_nome,
            this.produto_descricao,
            this.produto_valorvenda,
            this.produto_qtde,
            this.produto_status,
            this.uniMedida_cod,
            this.categoria_cod,
            this.subcategoria_cod});
            this.dgvProduto.Location = new System.Drawing.Point(399, 17);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(453, 206);
            this.dgvProduto.TabIndex = 112;
            // 
            // itensCompra_cod
            // 
            this.itensCompra_cod.HeaderText = "Código Item";
            this.itensCompra_cod.Name = "itensCompra_cod";
            this.itensCompra_cod.ReadOnly = true;
            this.itensCompra_cod.Visible = false;
            // 
            // itensCompra_qtde
            // 
            this.itensCompra_qtde.HeaderText = "Quantidade Item";
            this.itensCompra_qtde.Name = "itensCompra_qtde";
            this.itensCompra_qtde.ReadOnly = true;
            this.itensCompra_qtde.Visible = false;
            // 
            // itensCompra_qtdeVenda
            // 
            this.itensCompra_qtdeVenda.HeaderText = "Quantidade Venda";
            this.itensCompra_qtdeVenda.Name = "itensCompra_qtdeVenda";
            this.itensCompra_qtdeVenda.ReadOnly = true;
            this.itensCompra_qtdeVenda.Visible = false;
            // 
            // itensCompra_valor
            // 
            this.itensCompra_valor.HeaderText = "Valor Pago";
            this.itensCompra_valor.Name = "itensCompra_valor";
            this.itensCompra_valor.ReadOnly = true;
            // 
            // itensCompra_codigoBarra
            // 
            this.itensCompra_codigoBarra.HeaderText = "Código de Barra";
            this.itensCompra_codigoBarra.Name = "itensCompra_codigoBarra";
            this.itensCompra_codigoBarra.ReadOnly = true;
            this.itensCompra_codigoBarra.Visible = false;
            // 
            // itensCompra_vencimento
            // 
            this.itensCompra_vencimento.HeaderText = "Vencimento";
            this.itensCompra_vencimento.Name = "itensCompra_vencimento";
            this.itensCompra_vencimento.ReadOnly = true;
            this.itensCompra_vencimento.Visible = false;
            // 
            // produto_cod
            // 
            this.produto_cod.HeaderText = "Código  Produto";
            this.produto_cod.Name = "produto_cod";
            this.produto_cod.ReadOnly = true;
            this.produto_cod.Visible = false;
            // 
            // produto_nome
            // 
            this.produto_nome.HeaderText = "Nome";
            this.produto_nome.Name = "produto_nome";
            this.produto_nome.ReadOnly = true;
            // 
            // produto_descricao
            // 
            this.produto_descricao.HeaderText = "Descrição";
            this.produto_descricao.Name = "produto_descricao";
            this.produto_descricao.ReadOnly = true;
            // 
            // produto_valorvenda
            // 
            this.produto_valorvenda.HeaderText = "Valor Venda";
            this.produto_valorvenda.Name = "produto_valorvenda";
            this.produto_valorvenda.ReadOnly = true;
            // 
            // produto_qtde
            // 
            this.produto_qtde.HeaderText = "Quantidade";
            this.produto_qtde.Name = "produto_qtde";
            this.produto_qtde.ReadOnly = true;
            // 
            // produto_status
            // 
            this.produto_status.HeaderText = "Status";
            this.produto_status.Name = "produto_status";
            this.produto_status.ReadOnly = true;
            // 
            // uniMedida_cod
            // 
            this.uniMedida_cod.HeaderText = "uniMedida_cod";
            this.uniMedida_cod.Name = "uniMedida_cod";
            this.uniMedida_cod.ReadOnly = true;
            this.uniMedida_cod.Visible = false;
            // 
            // categoria_cod
            // 
            this.categoria_cod.HeaderText = "categoria_cod";
            this.categoria_cod.Name = "categoria_cod";
            this.categoria_cod.ReadOnly = true;
            this.categoria_cod.Visible = false;
            // 
            // subcategoria_cod
            // 
            this.subcategoria_cod.HeaderText = "subcategoria_cod";
            this.subcategoria_cod.Name = "subcategoria_cod";
            this.subcategoria_cod.ReadOnly = true;
            this.subcategoria_cod.Visible = false;
            // 
            // frmCadastrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 499);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.cbxTipoPagamento);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.cbxQuantParcela);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNotaFiscal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmCadastrarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.ComboBox cbxQuantParcela;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.ComboBox cbxTipoPagamento;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraNumeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorRSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCod;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensCompra_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensCompra_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensCompra_qtdeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensCompra_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensCompra_codigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensCompra_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniMedida_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoria_cod;
    }
}
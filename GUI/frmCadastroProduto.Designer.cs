namespace GUI
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.cbxCodCat = new System.Windows.Forms.ComboBox();
            this.lblCodCat = new System.Windows.Forms.Label();
            this.cbxCodUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.cbxCodSubcat = new System.Windows.Forms.ComboBox();
            this.lblSubCat = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtConsultaProduto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.lblCodBarra = new System.Windows.Forms.Label();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(568, 430);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 75;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(19, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 57;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(22, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 20);
            this.txtCodigo.TabIndex = 58;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 59;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(618, 20);
            this.txtNome.TabIndex = 60;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(19, 95);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 61;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(22, 111);
            this.txtDescricao.MaxLength = 500;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(618, 73);
            this.txtDescricao.TabIndex = 62;
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(19, 195);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(59, 13);
            this.lblValorPago.TabIndex = 63;
            this.lblValorPago.Text = "Valor Pago";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Enabled = false;
            this.txtValorPago.Location = new System.Drawing.Point(22, 212);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(109, 20);
            this.txtValorPago.TabIndex = 64;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(370, 195);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 65;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(373, 212);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(109, 20);
            this.txtQuantidade.TabIndex = 66;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(190, 195);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(65, 13);
            this.lblValorVenda.TabIndex = 67;
            this.lblValorVenda.Text = "Valor Venda";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(193, 212);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(109, 20);
            this.txtValorVenda.TabIndex = 68;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            // 
            // cbxCodCat
            // 
            this.cbxCodCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodCat.FormattingEnabled = true;
            this.cbxCodCat.Location = new System.Drawing.Point(193, 260);
            this.cbxCodCat.Name = "cbxCodCat";
            this.cbxCodCat.Size = new System.Drawing.Size(121, 21);
            this.cbxCodCat.TabIndex = 69;
            this.cbxCodCat.SelectionChangeCommitted += new System.EventHandler(this.cbxCodCat_SelectionChangeCommitted);
            // 
            // lblCodCat
            // 
            this.lblCodCat.AutoSize = true;
            this.lblCodCat.Location = new System.Drawing.Point(193, 244);
            this.lblCodCat.Name = "lblCodCat";
            this.lblCodCat.Size = new System.Drawing.Size(52, 13);
            this.lblCodCat.TabIndex = 70;
            this.lblCodCat.Text = "Categoria";
            // 
            // cbxCodUnidadeMedida
            // 
            this.cbxCodUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodUnidadeMedida.FormattingEnabled = true;
            this.cbxCodUnidadeMedida.Location = new System.Drawing.Point(22, 260);
            this.cbxCodUnidadeMedida.Name = "cbxCodUnidadeMedida";
            this.cbxCodUnidadeMedida.Size = new System.Drawing.Size(121, 21);
            this.cbxCodUnidadeMedida.TabIndex = 71;
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Location = new System.Drawing.Point(22, 244);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(85, 13);
            this.lblUnidadeMedida.TabIndex = 72;
            this.lblUnidadeMedida.Text = "Unidade Medida";
            // 
            // cbxCodSubcat
            // 
            this.cbxCodSubcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodSubcat.FormattingEnabled = true;
            this.cbxCodSubcat.Location = new System.Drawing.Point(373, 260);
            this.cbxCodSubcat.Name = "cbxCodSubcat";
            this.cbxCodSubcat.Size = new System.Drawing.Size(121, 21);
            this.cbxCodSubcat.TabIndex = 73;
            // 
            // lblSubCat
            // 
            this.lblSubCat.AutoSize = true;
            this.lblSubCat.Location = new System.Drawing.Point(373, 244);
            this.lblSubCat.Name = "lblSubCat";
            this.lblSubCat.Size = new System.Drawing.Size(70, 13);
            this.lblSubCat.TabIndex = 74;
            this.lblSubCat.Text = "Subcategoria";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 398);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 76;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(25, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 78;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(25, 382);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(75, 13);
            this.lblProduto.TabIndex = 80;
            this.lblProduto.Text = "Nome Produto";
            // 
            // txtConsultaProduto
            // 
            this.txtConsultaProduto.Location = new System.Drawing.Point(25, 398);
            this.txtConsultaProduto.Name = "txtConsultaProduto";
            this.txtConsultaProduto.Size = new System.Drawing.Size(445, 20);
            this.txtConsultaProduto.TabIndex = 81;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(106, 312);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 83;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(25, 311);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(280, 20);
            this.txtCodBarra.TabIndex = 95;
            this.txtCodBarra.Visible = false;
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.AutoSize = true;
            this.lblCodBarra.Location = new System.Drawing.Point(22, 295);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(86, 13);
            this.lblCodBarra.TabIndex = 94;
            this.lblCodBarra.Text = "Código de Barra:";
            this.lblCodBarra.Visible = false;
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Location = new System.Drawing.Point(376, 311);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(232, 20);
            this.dtpDataValidade.TabIndex = 93;
            this.dtpDataValidade.Visible = false;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Location = new System.Drawing.Point(373, 295);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(48, 13);
            this.lblDataValidade.TabIndex = 92;
            this.lblDataValidade.Text = "Validade";
            this.lblDataValidade.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(506, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 97;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "EM ESTOQUE",
            "FORA DE ESTOQUE"});
            this.cbxStatus.Location = new System.Drawing.Point(509, 212);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(131, 21);
            this.cbxStatus.TabIndex = 96;
            this.cbxStatus.Visible = false;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.descricao,
            this.ValorVenda,
            this.quant,
            this.status,
            this.uniCod,
            this.CatCod,
            this.SubCod,
            this.UniNome,
            this.CatNome,
            this.SubNome});
            this.dgvProduto.Location = new System.Drawing.Point(25, 430);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(537, 153);
            this.dgvProduto.TabIndex = 98;
            this.dgvProduto.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "produto_cod";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "produto_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "produto_descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Visible = false;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "produto_valorvenda";
            this.ValorVenda.HeaderText = "Valor Venda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "produto_qtde";
            this.quant.HeaderText = "Quantidade";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "produto_status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // uniCod
            // 
            this.uniCod.DataPropertyName = "uniMedida_cod";
            this.uniCod.HeaderText = "uniCod";
            this.uniCod.Name = "uniCod";
            this.uniCod.ReadOnly = true;
            this.uniCod.Visible = false;
            // 
            // CatCod
            // 
            this.CatCod.DataPropertyName = "categoria_cod";
            this.CatCod.HeaderText = "CatCod";
            this.CatCod.Name = "CatCod";
            this.CatCod.ReadOnly = true;
            this.CatCod.Visible = false;
            // 
            // SubCod
            // 
            this.SubCod.DataPropertyName = "subCategoria_cod";
            this.SubCod.HeaderText = "SubCod";
            this.SubCod.Name = "SubCod";
            this.SubCod.ReadOnly = true;
            this.SubCod.Visible = false;
            // 
            // UniNome
            // 
            this.UniNome.DataPropertyName = "uniMedida_Nome";
            this.UniNome.HeaderText = "Unidade Medida";
            this.UniNome.Name = "UniNome";
            this.UniNome.ReadOnly = true;
            // 
            // CatNome
            // 
            this.CatNome.DataPropertyName = "categoria_nome";
            this.CatNome.HeaderText = "Categoria";
            this.CatNome.Name = "CatNome";
            this.CatNome.ReadOnly = true;
            // 
            // SubNome
            // 
            this.SubNome.DataPropertyName = "subCategoria_nome";
            this.SubNome.HeaderText = "Subcategoria";
            this.SubNome.Name = "SubNome";
            this.SubNome.ReadOnly = true;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 602);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.lblCodBarra);
            this.Controls.Add(this.dtpDataValidade);
            this.Controls.Add(this.lblDataValidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtConsultaProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblSubCat);
            this.Controls.Add(this.cbxCodSubcat);
            this.Controls.Add(this.lblUnidadeMedida);
            this.Controls.Add(this.cbxCodUnidadeMedida);
            this.Controls.Add(this.lblCodCat);
            this.Controls.Add(this.cbxCodCat);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.ComboBox cbxCodCat;
        private System.Windows.Forms.Label lblCodCat;
        private System.Windows.Forms.ComboBox cbxCodUnidadeMedida;
        private System.Windows.Forms.Label lblUnidadeMedida;
        private System.Windows.Forms.ComboBox cbxCodSubcat;
        private System.Windows.Forms.Label lblSubCat;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtConsultaProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label lblCodBarra;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNome;
    }
}
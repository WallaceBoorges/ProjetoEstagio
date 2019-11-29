namespace GUI
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtConsultaProduto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvProdutoVenda = new System.Windows.Forms.DataGridView();
            this.produto_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVenda,
            this.MenuCliente,
            this.MenuEstoque,
            this.MenuFuncionario,
            this.MenuFornecedor,
            this.configuraçãoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1255, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // MenuVenda
            // 
            this.MenuVenda.Name = "MenuVenda";
            this.MenuVenda.Size = new System.Drawing.Size(51, 20);
            this.MenuVenda.Text = "Venda";
            // 
            // MenuCliente
            // 
            this.MenuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(56, 20);
            this.MenuCliente.Text = "Cliente";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem2,
            this.categoriaToolStripMenuItem2,
            this.subCategoriaToolStripMenuItem2});
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(61, 20);
            this.MenuEstoque.Text = "Estoque";
            // 
            // produtoToolStripMenuItem2
            // 
            this.produtoToolStripMenuItem2.Name = "produtoToolStripMenuItem2";
            this.produtoToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.produtoToolStripMenuItem2.Text = "Produto";
            this.produtoToolStripMenuItem2.Click += new System.EventHandler(this.produtoToolStripMenuItem2_Click);
            // 
            // categoriaToolStripMenuItem2
            // 
            this.categoriaToolStripMenuItem2.Name = "categoriaToolStripMenuItem2";
            this.categoriaToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.categoriaToolStripMenuItem2.Text = "Categoria";
            this.categoriaToolStripMenuItem2.Click += new System.EventHandler(this.categoriaToolStripMenuItem2_Click);
            // 
            // subCategoriaToolStripMenuItem2
            // 
            this.subCategoriaToolStripMenuItem2.Name = "subCategoriaToolStripMenuItem2";
            this.subCategoriaToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.subCategoriaToolStripMenuItem2.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem2.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem2_Click);
            // 
            // MenuFuncionario
            // 
            this.MenuFuncionario.Name = "MenuFuncionario";
            this.MenuFuncionario.Size = new System.Drawing.Size(82, 20);
            this.MenuFuncionario.Text = "Funcionario";
            this.MenuFuncionario.Click += new System.EventHandler(this.MenuFuncionario_Click);
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.cadastrarComprasToolStripMenuItem});
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(79, 20);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // cadastrarComprasToolStripMenuItem
            // 
            this.cadastrarComprasToolStripMenuItem.Name = "cadastrarComprasToolStripMenuItem";
            this.cadastrarComprasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastrarComprasToolStripMenuItem.Text = "Cadastrar Compras";
            this.cadastrarComprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexãoBancoToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // conexãoBancoToolStripMenuItem
            // 
            this.conexãoBancoToolStripMenuItem.Name = "conexãoBancoToolStripMenuItem";
            this.conexãoBancoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.conexãoBancoToolStripMenuItem.Text = "Conexão Banco";
            this.conexãoBancoToolStripMenuItem.Click += new System.EventHandler(this.conexãoBancoToolStripMenuItem_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(1176, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(70, 20);
            this.txtCod.TabIndex = 86;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCod.Location = new System.Drawing.Point(1127, 9);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 87;
            this.lblCod.Text = "Código:";
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(492, 371);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(182, 72);
            this.btnFinalizarVenda.TabIndex = 138;
            this.btnFinalizarVenda.Text = "FINALIZAR \r\nCOMPRA";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(15, 371);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(165, 31);
            this.lblValorTotal.TabIndex = 137;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(15, 405);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(165, 38);
            this.txtValorTotal.TabIndex = 136;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(705, 259);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 56);
            this.btnLimpar.TabIndex = 135;
            this.btnLimpar.Text = "Limpar Compra";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(705, 197);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(151, 56);
            this.btnRemover.TabIndex = 134;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(705, 125);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 66);
            this.btnEditar.TabIndex = 133;
            this.btnEditar.Text = "Editar Quantidada Produto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtConsultaProduto
            // 
            this.txtConsultaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultaProduto.Location = new System.Drawing.Point(882, 66);
            this.txtConsultaProduto.Name = "txtConsultaProduto";
            this.txtConsultaProduto.Size = new System.Drawing.Size(272, 20);
            this.txtConsultaProduto.TabIndex = 132;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(1171, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 131;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvProduto.Location = new System.Drawing.Point(882, 92);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(364, 263);
            this.dgvProduto.TabIndex = 130;
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
            this.status.Visible = false;
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
            this.UniNome.Visible = false;
            // 
            // CatNome
            // 
            this.CatNome.DataPropertyName = "categoria_nome";
            this.CatNome.HeaderText = "Categoria";
            this.CatNome.Name = "CatNome";
            this.CatNome.ReadOnly = true;
            this.CatNome.Visible = false;
            // 
            // SubNome
            // 
            this.SubNome.DataPropertyName = "subCategoria_nome";
            this.SubNome.HeaderText = "Subcategoria";
            this.SubNome.Name = "SubNome";
            this.SubNome.ReadOnly = true;
            this.SubNome.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1103, 371);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 56);
            this.btnSalvar.TabIndex = 129;
            this.btnSalvar.Text = "Adicionar Produto";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(259, 31);
            this.lblCodigo.TabIndex = 128;
            this.lblCodigo.Text = "Lista de Produtos: ";
            // 
            // dgvProdutoVenda
            // 
            this.dgvProdutoVenda.AllowUserToAddRows = false;
            this.dgvProdutoVenda.AllowUserToDeleteRows = false;
            this.dgvProdutoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutoVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutoVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto_cod,
            this.produto_nome,
            this.produto_valorvenda,
            this.produto_qtde,
            this.total});
            this.dgvProdutoVenda.Location = new System.Drawing.Point(15, 63);
            this.dgvProdutoVenda.Name = "dgvProdutoVenda";
            this.dgvProdutoVenda.ReadOnly = true;
            this.dgvProdutoVenda.Size = new System.Drawing.Size(659, 292);
            this.dgvProdutoVenda.TabIndex = 127;
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
            // produto_valorvenda
            // 
            this.produto_valorvenda.HeaderText = "Valor";
            this.produto_valorvenda.Name = "produto_valorvenda";
            this.produto_valorvenda.ReadOnly = true;
            // 
            // produto_qtde
            // 
            this.produto_qtde.HeaderText = "Quantidade";
            this.produto_qtde.Name = "produto_qtde";
            this.produto_qtde.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 473);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtConsultaProduto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvProdutoVenda);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.menu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem MenuVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        public System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoBancoToolStripMenuItem;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtConsultaProduto;
        private System.Windows.Forms.Button btnBuscar;
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
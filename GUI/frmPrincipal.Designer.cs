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
            this.menu.SuspendLayout();
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
            this.menu.Size = new System.Drawing.Size(800, 24);
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
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // cadastrarComprasToolStripMenuItem
            // 
            this.cadastrarComprasToolStripMenuItem.Name = "cadastrarComprasToolStripMenuItem";
            this.cadastrarComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.txtCod.Location = new System.Drawing.Point(718, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(70, 20);
            this.txtCod.TabIndex = 86;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCod.Location = new System.Drawing.Point(669, 9);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 87;
            this.lblCod.Text = "Código:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.menu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
    }
}
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
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFerramenta = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MenuFinanceiro,
            this.MenuFerramenta});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1067, 28);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // MenuVenda
            // 
            this.MenuVenda.Name = "MenuVenda";
            this.MenuVenda.Size = new System.Drawing.Size(62, 24);
            this.MenuVenda.Text = "Venda";
            // 
            // MenuCliente
            // 
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(67, 24);
            this.MenuCliente.Text = "Cliente";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem2,
            this.categoriaToolStripMenuItem2,
            this.subCategoriaToolStripMenuItem2,
            this.unidadeDeMedidaToolStripMenuItem});
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(74, 24);
            this.MenuEstoque.Text = "Estoque";
            // 
            // produtoToolStripMenuItem2
            // 
            this.produtoToolStripMenuItem2.Name = "produtoToolStripMenuItem2";
            this.produtoToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.produtoToolStripMenuItem2.Text = "Produto";
            // 
            // categoriaToolStripMenuItem2
            // 
            this.categoriaToolStripMenuItem2.Name = "categoriaToolStripMenuItem2";
            this.categoriaToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.categoriaToolStripMenuItem2.Text = "Categoria";
            this.categoriaToolStripMenuItem2.Click += new System.EventHandler(this.categoriaToolStripMenuItem2_Click);
            // 
            // subCategoriaToolStripMenuItem2
            // 
            this.subCategoriaToolStripMenuItem2.Name = "subCategoriaToolStripMenuItem2";
            this.subCategoriaToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.subCategoriaToolStripMenuItem2.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem2.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem2_Click);
            // 
            // MenuFuncionario
            // 
            this.MenuFuncionario.Name = "MenuFuncionario";
            this.MenuFuncionario.Size = new System.Drawing.Size(98, 24);
            this.MenuFuncionario.Text = "Funcionario";
            // 
            // MenuFinanceiro
            // 
            this.MenuFinanceiro.Name = "MenuFinanceiro";
            this.MenuFinanceiro.Size = new System.Drawing.Size(89, 24);
            this.MenuFinanceiro.Text = "Financeiro";
            // 
            // MenuFerramenta
            // 
            this.MenuFerramenta.Name = "MenuFerramenta";
            this.MenuFerramenta.Size = new System.Drawing.Size(96, 24);
            this.MenuFerramenta.Text = "Fornecedor";
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
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
        private System.Windows.Forms.ToolStripMenuItem MenuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem MenuFerramenta;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
    }
}
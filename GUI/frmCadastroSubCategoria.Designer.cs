﻿namespace GUI
{
    partial class frmCadastroSubCategoria
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
            this.dgvSubCategoria = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoria_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConsultaSubCategoria = new System.Windows.Forms.TextBox();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.lblCodCat = new System.Windows.Forms.Label();
            this.lblSubCatNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtSubCatNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbxCodCat = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubCategoria
            // 
            this.dgvSubCategoria.AllowUserToAddRows = false;
            this.dgvSubCategoria.AllowUserToDeleteRows = false;
            this.dgvSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.subcategoria_nome,
            this.categoria_cod,
            this.categoria_nome});
            this.dgvSubCategoria.Location = new System.Drawing.Point(35, 319);
            this.dgvSubCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSubCategoria.Name = "dgvSubCategoria";
            this.dgvSubCategoria.ReadOnly = true;
            this.dgvSubCategoria.Size = new System.Drawing.Size(755, 188);
            this.dgvSubCategoria.TabIndex = 44;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "subCategoria_cod";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // subcategoria_nome
            // 
            this.subcategoria_nome.DataPropertyName = "subCategoria_nome";
            this.subcategoria_nome.HeaderText = "Nome";
            this.subcategoria_nome.Name = "subcategoria_nome";
            this.subcategoria_nome.ReadOnly = true;
            this.subcategoria_nome.Width = 225;
            // 
            // categoria_cod
            // 
            this.categoria_cod.DataPropertyName = "categoria_cod";
            this.categoria_cod.HeaderText = "Categoria_cod";
            this.categoria_cod.Name = "categoria_cod";
            this.categoria_cod.ReadOnly = true;
            this.categoria_cod.Visible = false;
            // 
            // categoria_nome
            // 
            this.categoria_nome.DataPropertyName = "categoria_nome";
            this.categoria_nome.HeaderText = "Categoria";
            this.categoria_nome.Name = "categoria_nome";
            this.categoria_nome.ReadOnly = true;
            this.categoria_nome.Width = 225;
            // 
            // txtConsultaSubCategoria
            // 
            this.txtConsultaSubCategoria.Location = new System.Drawing.Point(35, 279);
            this.txtConsultaSubCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsultaSubCategoria.Name = "txtConsultaSubCategoria";
            this.txtConsultaSubCategoria.Size = new System.Drawing.Size(592, 22);
            this.txtConsultaSubCategoria.TabIndex = 43;
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Location = new System.Drawing.Point(35, 260);
            this.lblSubCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(94, 17);
            this.lblSubCategoria.TabIndex = 42;
            this.lblSubCategoria.Text = "SubCategoria";
            // 
            // lblCodCat
            // 
            this.lblCodCat.AutoSize = true;
            this.lblCodCat.Location = new System.Drawing.Point(35, 140);
            this.lblCodCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodCat.Name = "lblCodCat";
            this.lblCodCat.Size = new System.Drawing.Size(128, 17);
            this.lblCodCat.TabIndex = 41;
            this.lblCodCat.Text = "Nome da categoria";
            // 
            // lblSubCatNome
            // 
            this.lblSubCatNome.AutoSize = true;
            this.lblSubCatNome.Location = new System.Drawing.Point(31, 80);
            this.lblSubCatNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCatNome.Name = "lblSubCatNome";
            this.lblSubCatNome.Size = new System.Drawing.Size(151, 17);
            this.lblSubCatNome.TabIndex = 40;
            this.lblSubCatNome.Text = "Nome da subcategoria";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(35, 16);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 39;
            this.lblCodigo.Text = "Código";
            // 
            // txtSubCatNome
            // 
            this.txtSubCatNome.Location = new System.Drawing.Point(35, 100);
            this.txtSubCatNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubCatNome.Name = "txtSubCatNome";
            this.txtSubCatNome.Size = new System.Drawing.Size(132, 22);
            this.txtSubCatNome.TabIndex = 38;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(35, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 37;
            // 
            // cbxCodCat
            // 
            this.cbxCodCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCodCat.FormattingEnabled = true;
            this.cbxCodCat.Location = new System.Drawing.Point(35, 160);
            this.cbxCodCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCodCat.Name = "cbxCodCat";
            this.cbxCodCat.Size = new System.Drawing.Size(160, 24);
            this.cbxCodCat.TabIndex = 36;
            this.cbxCodCat.SelectedIndexChanged += new System.EventHandler(this.cbxCodCat_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(147, 213);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(39, 213);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(800, 389);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(651, 279);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(800, 332);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.dgvSubCategoria);
            this.Controls.Add(this.txtConsultaSubCategoria);
            this.Controls.Add(this.lblSubCategoria);
            this.Controls.Add(this.lblCodCat);
            this.Controls.Add(this.lblSubCatNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtSubCatNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbxCodCat);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "frmCadastroSubCategoria";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoria_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_nome;
        private System.Windows.Forms.TextBox txtConsultaSubCategoria;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.Label lblCodCat;
        private System.Windows.Forms.Label lblSubCatNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtSubCatNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbxCodCat;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
    }
}
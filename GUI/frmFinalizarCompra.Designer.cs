namespace GUI
{
    partial class frmFinalizarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarCompra));
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.cbxTipoPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxaParcela = new System.Windows.Forms.TextBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cbxQuantParcela = new System.Windows.Forms.ComboBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.cbxTaxa = new System.Windows.Forms.CheckBox();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoPagamento.Location = new System.Drawing.Point(337, 143);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(84, 34);
            this.lblTipoPagamento.TabIndex = 244;
            this.lblTipoPagamento.Text = "Tipo \r\nPagamento:";
            // 
            // cbxTipoPagamento
            // 
            this.cbxTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxTipoPagamento.FormattingEnabled = true;
            this.cbxTipoPagamento.Location = new System.Drawing.Point(427, 156);
            this.cbxTipoPagamento.Name = "cbxTipoPagamento";
            this.cbxTipoPagamento.Size = new System.Drawing.Size(137, 24);
            this.cbxTipoPagamento.TabIndex = 243;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 242;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(486, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 241;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(337, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 34);
            this.label1.TabIndex = 240;
            this.label1.Text = "Valor \r\nTaxa:";
            // 
            // txtTaxaParcela
            // 
            this.txtTaxaParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtTaxaParcela.Location = new System.Drawing.Point(408, 97);
            this.txtTaxaParcela.Name = "txtTaxaParcela";
            this.txtTaxaParcela.ReadOnly = true;
            this.txtTaxaParcela.Size = new System.Drawing.Size(108, 23);
            this.txtTaxaParcela.TabIndex = 239;
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.Location = new System.Drawing.Point(69, 253);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(198, 31);
            this.lblValorParcela.TabIndex = 238;
            this.lblValorParcela.Text = "Valor Parcela:";
            // 
            // txtParcela
            // 
            this.txtParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(75, 287);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.ReadOnly = true;
            this.txtParcela.Size = new System.Drawing.Size(192, 38);
            this.txtParcela.TabIndex = 237;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(309, 253);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(165, 31);
            this.lblValorTotal.TabIndex = 236;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(309, 287);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(165, 38);
            this.txtValorTotal.TabIndex = 235;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(337, 209);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 234;
            this.lblStatus.Text = "Status:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "AGUARDANDO",
            "FINALIZADA"});
            this.cbxStatus.Location = new System.Drawing.Point(408, 202);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(156, 24);
            this.cbxStatus.TabIndex = 233;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblParcela.Location = new System.Drawing.Point(337, 23);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(67, 17);
            this.lblParcela.TabIndex = 232;
            this.lblParcela.Text = "Parcelas:";
            // 
            // cbxQuantParcela
            // 
            this.cbxQuantParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantParcela.Enabled = false;
            this.cbxQuantParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.cbxQuantParcela.Location = new System.Drawing.Point(410, 15);
            this.cbxQuantParcela.Name = "cbxQuantParcela";
            this.cbxQuantParcela.Size = new System.Drawing.Size(122, 24);
            this.cbxQuantParcela.TabIndex = 231;
            this.cbxQuantParcela.SelectedIndexChanged += new System.EventHandler(this.cbxQuantParcela_SelectedIndexChanged);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTaxa.Location = new System.Drawing.Point(408, 52);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(72, 23);
            this.txtTaxa.TabIndex = 230;
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            this.txtTaxa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxa_KeyUp);
            // 
            // cbxTaxa
            // 
            this.cbxTaxa.AutoSize = true;
            this.cbxTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxTaxa.Location = new System.Drawing.Point(340, 54);
            this.cbxTaxa.Name = "cbxTaxa";
            this.cbxTaxa.Size = new System.Drawing.Size(62, 21);
            this.cbxTaxa.TabIndex = 229;
            this.cbxTaxa.Text = "Taxa:";
            this.cbxTaxa.UseVisualStyleBackColor = true;
            this.cbxTaxa.CheckedChanged += new System.EventHandler(this.cbxTaxa_CheckedChanged);
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConsultaCliente.Location = new System.Drawing.Point(75, 16);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(159, 23);
            this.txtConsultaCliente.TabIndex = 228;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(240, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 227;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(109, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 34);
            this.btnCancelar.TabIndex = 225;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarVenda.Image")));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(309, 356);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(156, 48);
            this.btnFinalizarVenda.TabIndex = 224;
            this.btnFinalizarVenda.Text = "FINALIZAR \r\nCOMPRA";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.idCliente,
            this.nome,
            this.tipo,
            this.CPF,
            this.rg,
            this.rsocial,
            this.Cel,
            this.email,
            this.fone,
            this.endereco_cod,
            this.cep,
            this.logradouro,
            this.bairro,
            this.numero,
            this.cidade,
            this.Estado});
            this.dgvCliente.Location = new System.Drawing.Point(17, 54);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(298, 172);
            this.dgvCliente.TabIndex = 246;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 30;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "cliente_cod";
            this.idCliente.HeaderText = "ID";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "cliente_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "cliente_tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cliente_cpfcnpj";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 125;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "cliente_rg";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Visible = false;
            // 
            // rsocial
            // 
            this.rsocial.DataPropertyName = "cliente_rsocial";
            this.rsocial.HeaderText = "Razão Social";
            this.rsocial.Name = "rsocial";
            this.rsocial.ReadOnly = true;
            this.rsocial.Visible = false;
            // 
            // Cel
            // 
            this.Cel.DataPropertyName = "cliente_cel";
            this.Cel.HeaderText = "Celular";
            this.Cel.Name = "Cel";
            this.Cel.ReadOnly = true;
            this.Cel.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "cliente_email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // fone
            // 
            this.fone.DataPropertyName = "cliente_fone";
            this.fone.HeaderText = "Telefone";
            this.fone.Name = "fone";
            this.fone.ReadOnly = true;
            this.fone.Visible = false;
            // 
            // endereco_cod
            // 
            this.endereco_cod.DataPropertyName = "endereco_cod";
            this.endereco_cod.HeaderText = "cod_endereco";
            this.endereco_cod.Name = "endereco_cod";
            this.endereco_cod.ReadOnly = true;
            this.endereco_cod.Visible = false;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "endereco_cep";
            this.cep.HeaderText = "cep";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Visible = false;
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "endereco_logradouro";
            this.logradouro.HeaderText = "logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            this.logradouro.Visible = false;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "endereco_bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Visible = false;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "endereco_numero";
            this.numero.HeaderText = "N°";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "endereco_cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "endereco_estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // frmFinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 417);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.cbxTipoPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaxaParcela);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.cbxQuantParcela);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.cbxTaxa);
            this.Controls.Add(this.txtConsultaCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinalizarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinalizarCompra";
            this.Load += new System.EventHandler(this.frmFinalizarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.ComboBox cbxTipoPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaxaParcela;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.ComboBox cbxQuantParcela;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.CheckBox cbxTaxa;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn rsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
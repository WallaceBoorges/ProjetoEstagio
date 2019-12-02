namespace GUI
{
    partial class frmVendas
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
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.venda_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_nfiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_nparcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_taxaParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPag_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tudo = new System.Windows.Forms.CheckBox();
            this.cb_funcionario = new System.Windows.Forms.CheckBox();
            this.cb_cliente = new System.Windows.Forms.CheckBox();
            this.dtp_Venda = new System.Windows.Forms.DateTimePicker();
            this.cb_data = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venda_cod,
            this.venda_data,
            this.venda_nfiscal,
            this.venda_total,
            this.venda_nparcelas,
            this.venda_taxaParcela,
            this.venda_status,
            this.cliente_cod,
            this.tipoPag_cod,
            this.fun_cod});
            this.dgvVendas.Location = new System.Drawing.Point(12, 157);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(661, 281);
            this.dgvVendas.TabIndex = 0;
            // 
            // venda_cod
            // 
            this.venda_cod.DataPropertyName = "venda_cod";
            this.venda_cod.HeaderText = "venda_cod";
            this.venda_cod.Name = "venda_cod";
            this.venda_cod.Visible = false;
            // 
            // venda_data
            // 
            this.venda_data.DataPropertyName = "venda_data";
            this.venda_data.HeaderText = "Data";
            this.venda_data.Name = "venda_data";
            // 
            // venda_nfiscal
            // 
            this.venda_nfiscal.DataPropertyName = "venda_nfiscal";
            this.venda_nfiscal.HeaderText = "Nota";
            this.venda_nfiscal.Name = "venda_nfiscal";
            // 
            // venda_total
            // 
            this.venda_total.DataPropertyName = "venda_total";
            this.venda_total.HeaderText = "Valor";
            this.venda_total.Name = "venda_total";
            // 
            // venda_nparcelas
            // 
            this.venda_nparcelas.DataPropertyName = "venda_nparcelas";
            this.venda_nparcelas.HeaderText = "Numero de Parcelas";
            this.venda_nparcelas.Name = "venda_nparcelas";
            // 
            // venda_taxaParcela
            // 
            this.venda_taxaParcela.DataPropertyName = "venda_taxaParcela";
            this.venda_taxaParcela.HeaderText = "Taxa";
            this.venda_taxaParcela.Name = "venda_taxaParcela";
            // 
            // venda_status
            // 
            this.venda_status.DataPropertyName = "venda_status";
            this.venda_status.HeaderText = "Status";
            this.venda_status.Name = "venda_status";
            // 
            // cliente_cod
            // 
            this.cliente_cod.DataPropertyName = "cliente_cod";
            this.cliente_cod.HeaderText = "cliente_cod";
            this.cliente_cod.Name = "cliente_cod";
            this.cliente_cod.Visible = false;
            // 
            // tipoPag_cod
            // 
            this.tipoPag_cod.DataPropertyName = "tipoPag_cod";
            this.tipoPag_cod.HeaderText = "tipoPag_cod";
            this.tipoPag_cod.Name = "tipoPag_cod";
            this.tipoPag_cod.Visible = false;
            // 
            // fun_cod
            // 
            this.fun_cod.DataPropertyName = "fun_cod";
            this.fun_cod.HeaderText = "fun_cod";
            this.fun_cod.Name = "fun_cod";
            this.fun_cod.Visible = false;
            // 
            // txt_busca
            // 
            this.txt_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busca.Location = new System.Drawing.Point(134, 51);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(171, 24);
            this.txt_busca.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(515, 61);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(108, 44);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Aplicar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cb_tudo);
            this.groupBox1.Controls.Add(this.cb_funcionario);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.dtp_Venda);
            this.groupBox1.Controls.Add(this.cb_data);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_busca);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // cb_tudo
            // 
            this.cb_tudo.AutoSize = true;
            this.cb_tudo.Location = new System.Drawing.Point(528, 25);
            this.cb_tudo.Name = "cb_tudo";
            this.cb_tudo.Size = new System.Drawing.Size(72, 17);
            this.cb_tudo.TabIndex = 7;
            this.cb_tudo.Text = "Sem Filtro";
            this.cb_tudo.UseVisualStyleBackColor = true;
            this.cb_tudo.CheckedChanged += new System.EventHandler(this.Cb_tudo_CheckedChanged);
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.AutoSize = true;
            this.cb_funcionario.Location = new System.Drawing.Point(336, 28);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(97, 17);
            this.cb_funcionario.TabIndex = 6;
            this.cb_funcionario.Text = "Por funcionário";
            this.cb_funcionario.UseVisualStyleBackColor = true;
            this.cb_funcionario.CheckedChanged += new System.EventHandler(this.Cb_funcionario_CheckedChanged);
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoSize = true;
            this.cb_cliente.Location = new System.Drawing.Point(134, 25);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(76, 17);
            this.cb_cliente.TabIndex = 5;
            this.cb_cliente.Text = "Por cliente";
            this.cb_cliente.UseVisualStyleBackColor = true;
            this.cb_cliente.CheckedChanged += new System.EventHandler(this.Cb_cliente_CheckedChanged);
            // 
            // dtp_Venda
            // 
            this.dtp_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Venda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Venda.Location = new System.Drawing.Point(6, 49);
            this.dtp_Venda.Name = "dtp_Venda";
            this.dtp_Venda.Size = new System.Drawing.Size(111, 26);
            this.dtp_Venda.TabIndex = 4;
            // 
            // cb_data
            // 
            this.cb_data.AutoSize = true;
            this.cb_data.Location = new System.Drawing.Point(6, 26);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(66, 17);
            this.cb_data.TabIndex = 3;
            this.cb_data.Text = "Por data";
            this.cb_data.UseVisualStyleBackColor = true;
            this.cb_data.CheckedChanged += new System.EventHandler(this.Cb_data_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(519, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Detalhes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVendas);
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_nfiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_nparcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_taxaParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPag_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_cod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_funcionario;
        private System.Windows.Forms.CheckBox cb_cliente;
        private System.Windows.Forms.DateTimePicker dtp_Venda;
        private System.Windows.Forms.CheckBox cb_data;
        private System.Windows.Forms.CheckBox cb_tudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
namespace GUI
{
    partial class frmVendaDetalhada
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
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_funcionario = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.parcelasVenda_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasVenda_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasVenda_tadavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasVenda_datapagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVenda_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVenda_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVenda_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_parcelas
            // 
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcelasVenda_cod,
            this.parcelasVenda_valor,
            this.parcelasVenda_tadavecto,
            this.parcelasVenda_datapagto,
            this.venda_cod});
            this.dgv_parcelas.Location = new System.Drawing.Point(12, 195);
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.Size = new System.Drawing.Size(354, 150);
            this.dgv_parcelas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcinário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data da venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parcelas:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(128, 27);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente.TabIndex = 6;
            // 
            // txt_funcionario
            // 
            this.txt_funcionario.Location = new System.Drawing.Point(128, 74);
            this.txt_funcionario.Name = "txt_funcionario";
            this.txt_funcionario.Size = new System.Drawing.Size(100, 20);
            this.txt_funcionario.TabIndex = 7;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(128, 120);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(100, 20);
            this.txt_data.TabIndex = 8;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(416, 27);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 9;
            // 
            // dgv_itens
            // 
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itensVenda_cod,
            this.itensVenda_qtde,
            this.itensVenda_valor,
            this.cod_venda,
            this.produto_cod});
            this.dgv_itens.Location = new System.Drawing.Point(416, 195);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.Size = new System.Drawing.Size(355, 150);
            this.dgv_itens.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Itens Vendidos:";
            // 
            // parcelasVenda_cod
            // 
            this.parcelasVenda_cod.DataPropertyName = "parcelasVenda_cod";
            this.parcelasVenda_cod.HeaderText = "Codigo";
            this.parcelasVenda_cod.Name = "parcelasVenda_cod";
            this.parcelasVenda_cod.Visible = false;
            // 
            // parcelasVenda_valor
            // 
            this.parcelasVenda_valor.DataPropertyName = "parcelasVenda_valor";
            this.parcelasVenda_valor.HeaderText = "Valor";
            this.parcelasVenda_valor.Name = "parcelasVenda_valor";
            // 
            // parcelasVenda_tadavecto
            // 
            this.parcelasVenda_tadavecto.DataPropertyName = "parcelasVenda_tadavecto";
            this.parcelasVenda_tadavecto.HeaderText = "Vencimento";
            this.parcelasVenda_tadavecto.Name = "parcelasVenda_tadavecto";
            // 
            // parcelasVenda_datapagto
            // 
            this.parcelasVenda_datapagto.DataPropertyName = "parcelasVenda_datapagto";
            this.parcelasVenda_datapagto.HeaderText = "Pagamento";
            this.parcelasVenda_datapagto.Name = "parcelasVenda_datapagto";
            // 
            // venda_cod
            // 
            this.venda_cod.DataPropertyName = "venda_cod";
            this.venda_cod.HeaderText = "venda_cod";
            this.venda_cod.Name = "venda_cod";
            this.venda_cod.Visible = false;
            // 
            // itensVenda_cod
            // 
            this.itensVenda_cod.DataPropertyName = "itensVenda_cod";
            this.itensVenda_cod.HeaderText = "codigo";
            this.itensVenda_cod.Name = "itensVenda_cod";
            this.itensVenda_cod.Visible = false;
            // 
            // itensVenda_qtde
            // 
            this.itensVenda_qtde.DataPropertyName = "itensVenda_qtde";
            this.itensVenda_qtde.HeaderText = "Quantidade";
            this.itensVenda_qtde.Name = "itensVenda_qtde";
            // 
            // itensVenda_valor
            // 
            this.itensVenda_valor.DataPropertyName = "itensVenda_valor";
            this.itensVenda_valor.HeaderText = "Valor";
            this.itensVenda_valor.Name = "itensVenda_valor";
            // 
            // cod_venda
            // 
            this.cod_venda.DataPropertyName = "venda_cod";
            this.cod_venda.HeaderText = "venda_cod";
            this.cod_venda.Name = "cod_venda";
            this.cod_venda.Visible = false;
            // 
            // produto_cod
            // 
            this.produto_cod.DataPropertyName = "produto_cod";
            this.produto_cod.HeaderText = "Produto";
            this.produto_cod.Name = "produto_cod";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nota:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Taxa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(416, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // frmVendaDetalhada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_funcionario);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_parcelas);
            this.Name = "frmVendaDetalhada";
            this.Text = "frmVendaDetalhada";
            this.Load += new System.EventHandler(this.FrmVendaDetalhada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_funcionario;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasVenda_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasVenda_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasVenda_tadavecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasVenda_datapagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensVenda_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensVenda_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn itensVenda_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto_cod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
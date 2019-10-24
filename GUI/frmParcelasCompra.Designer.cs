namespace GUI
{
    partial class frmParcelasCompra
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
            this.components = new System.ComponentModel.Container();
            this.dgvParcelasCompra = new System.Windows.Forms.DataGridView();
            this.parcelasCompra_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasCompra_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasCompra_vecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasCompra_datapagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelascompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoEstagioDataSet = new GUI.ProjetoEstagioDataSet();
            this.parcelascompraTableAdapter = new GUI.ProjetoEstagioDataSetTableAdapters.parcelascompraTableAdapter();
            this.lb_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelascompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEstagioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParcelasCompra
            // 
            this.dgvParcelasCompra.AllowUserToAddRows = false;
            this.dgvParcelasCompra.AllowUserToDeleteRows = false;
            this.dgvParcelasCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelasCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcelasCompra_cod,
            this.parcelasCompra_valor,
            this.parcelasCompra_vecto,
            this.parcelasCompra_datapagto});
            this.dgvParcelasCompra.Location = new System.Drawing.Point(42, 59);
            this.dgvParcelasCompra.Name = "dgvParcelasCompra";
            this.dgvParcelasCompra.Size = new System.Drawing.Size(546, 361);
            this.dgvParcelasCompra.TabIndex = 0;
            // 
            // parcelasCompra_cod
            // 
            this.parcelasCompra_cod.DataPropertyName = "parcelasCompra_cod";
            this.parcelasCompra_cod.HeaderText = "Codigo da parcela";
            this.parcelasCompra_cod.Name = "parcelasCompra_cod";
            // 
            // parcelasCompra_valor
            // 
            this.parcelasCompra_valor.DataPropertyName = "parcelasCompra_valor";
            this.parcelasCompra_valor.HeaderText = "Valor";
            this.parcelasCompra_valor.Name = "parcelasCompra_valor";
            // 
            // parcelasCompra_vecto
            // 
            this.parcelasCompra_vecto.DataPropertyName = "parcelasCompra_vecto";
            this.parcelasCompra_vecto.HeaderText = "Vencimento";
            this.parcelasCompra_vecto.Name = "parcelasCompra_vecto";
            // 
            // parcelasCompra_datapagto
            // 
            this.parcelasCompra_datapagto.DataPropertyName = "parcelasCompra_datapagto";
            this.parcelasCompra_datapagto.HeaderText = "Data do pagamento";
            this.parcelasCompra_datapagto.Name = "parcelasCompra_datapagto";
            // 
            // parcelascompraBindingSource
            // 
            this.parcelascompraBindingSource.DataMember = "parcelascompra";
            this.parcelascompraBindingSource.DataSource = this.projetoEstagioDataSet;
            // 
            // projetoEstagioDataSet
            // 
            this.projetoEstagioDataSet.DataSetName = "ProjetoEstagioDataSet";
            this.projetoEstagioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parcelascompraTableAdapter
            // 
            this.parcelascompraTableAdapter.ClearBeforeFill = true;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(170, 19);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(270, 24);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Visualização das parcelas";
            // 
            // frmParcelasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.dgvParcelasCompra);
            this.Name = "frmParcelasCompra";
            this.Text = "frmParcelas";
            this.Load += new System.EventHandler(this.FrmParcelasCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelascompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEstagioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcelasCompra;
        private ProjetoEstagioDataSet projetoEstagioDataSet;
        private System.Windows.Forms.BindingSource parcelascompraBindingSource;
        private ProjetoEstagioDataSetTableAdapters.parcelascompraTableAdapter parcelascompraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_vecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_datapagto;
        private System.Windows.Forms.Label lb_titulo;
    }
}
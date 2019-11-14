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
            this.parcelascompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoEstagioDataSet = new GUI.ProjetoEstagioDataSet();
            this.parcelascompraTableAdapter = new GUI.ProjetoEstagioDataSetTableAdapters.parcelascompraTableAdapter();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_confPag = new System.Windows.Forms.Button();
            this.dt_selector = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.parcelasCompra_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasCompra_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasCompra_vecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasCompra_datapagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.parcelasCompra_datapagto,
            this.compra_cod});
            this.dgvParcelasCompra.Location = new System.Drawing.Point(36, 56);
            this.dgvParcelasCompra.Name = "dgvParcelasCompra";
            this.dgvParcelasCompra.Size = new System.Drawing.Size(363, 282);
            this.dgvParcelasCompra.TabIndex = 0;
            this.dgvParcelasCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParcelasCompra_CellClick);
            this.dgvParcelasCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParcelasCompra_CellClick);
            this.dgvParcelasCompra.SelectionChanged += new System.EventHandler(this.DgvParcelasCompra_SelectionChanged);
            this.dgvParcelasCompra.Click += new System.EventHandler(this.DgvParcelasCompra_SelectionChanged);
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
            this.lb_titulo.Location = new System.Drawing.Point(79, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(270, 24);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "Visualização das parcelas";
            // 
            // btn_confPag
            // 
            this.btn_confPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confPag.Location = new System.Drawing.Point(221, 356);
            this.btn_confPag.Name = "btn_confPag";
            this.btn_confPag.Size = new System.Drawing.Size(128, 50);
            this.btn_confPag.TabIndex = 2;
            this.btn_confPag.UseVisualStyleBackColor = true;
            this.btn_confPag.Click += new System.EventHandler(this.Btn_confPag_Click);
            // 
            // dt_selector
            // 
            this.dt_selector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_selector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_selector.Location = new System.Drawing.Point(83, 373);
            this.dt_selector.Name = "dt_selector";
            this.dt_selector.Size = new System.Drawing.Size(123, 26);
            this.dt_selector.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data do pagamento";
            // 
            // parcelasCompra_cod
            // 
            this.parcelasCompra_cod.DataPropertyName = "parcelasCompra_cod";
            this.parcelasCompra_cod.HeaderText = "Codigo da parcela";
            this.parcelasCompra_cod.Name = "parcelasCompra_cod";
            this.parcelasCompra_cod.Visible = false;
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
            // compra_cod
            // 
            this.compra_cod.DataPropertyName = "compra_cod";
            this.compra_cod.HeaderText = "compra_cod";
            this.compra_cod.Name = "compra_cod";
            this.compra_cod.Visible = false;
            // 
            // frmParcelasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_selector);
            this.Controls.Add(this.btn_confPag);
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
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button btn_confPag;
        private System.Windows.Forms.DateTimePicker dt_selector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_vecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasCompra_datapagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra_cod;
    }
}
namespace GUI
{
    partial class frmConexaoBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexaoBD));
            this.lblTipoConexao = new System.Windows.Forms.Label();
            this.cbxTipoConexao = new System.Windows.Forms.ComboBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoConexao
            // 
            this.lblTipoConexao.AutoSize = true;
            this.lblTipoConexao.Location = new System.Drawing.Point(25, 41);
            this.lblTipoConexao.Name = "lblTipoConexao";
            this.lblTipoConexao.Size = new System.Drawing.Size(76, 13);
            this.lblTipoConexao.TabIndex = 96;
            this.lblTipoConexao.Text = "Tipo Conexão:";
            // 
            // cbxTipoConexao
            // 
            this.cbxTipoConexao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoConexao.FormattingEnabled = true;
            this.cbxTipoConexao.Items.AddRange(new object[] {
            "Remota",
            "Local"});
            this.cbxTipoConexao.Location = new System.Drawing.Point(28, 67);
            this.cbxTipoConexao.Name = "cbxTipoConexao";
            this.cbxTipoConexao.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoConexao.TabIndex = 95;
            this.cbxTipoConexao.SelectionChangeCommitted += new System.EventHandler(this.cbxTipoConexao_SelectionChangeCommitted);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(28, 130);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(365, 20);
            this.txtServidor.TabIndex = 97;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(25, 114);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 98;
            this.lblServidor.Text = "Servidor:";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(25, 165);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 100;
            this.lblBanco.Text = "Banco:";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(28, 181);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(365, 20);
            this.txtBanco.TabIndex = 99;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 221);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 102;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(28, 237);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(365, 20);
            this.txtUsuario.TabIndex = 101;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(25, 278);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 104;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(28, 294);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(365, 20);
            this.txtSenha.TabIndex = 103;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(318, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 25);
            this.btnVoltar.TabIndex = 105;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(184, 342);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(117, 25);
            this.btnTestarConexao.TabIndex = 106;
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(318, 342);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 107;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmConexaoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 397);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblTipoConexao);
            this.Controls.Add(this.cbxTipoConexao);
            this.Name = "frmConexaoBD";
            this.Text = "frmConexaoBD";
            this.Load += new System.EventHandler(this.frmConexaoBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoConexao;
        private System.Windows.Forms.ComboBox cbxTipoConexao;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.Button btnTestarConexao;
        public System.Windows.Forms.Button btnSalvar;
    }
}
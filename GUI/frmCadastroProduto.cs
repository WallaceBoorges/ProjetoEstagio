using BLL;
using DAL;
using Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        public MItensCompra Iten { get; set; }

        public void LimparTela()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtValorVenda.Clear();
            txtValorPago.Clear();
            cbxCodCat.SelectedIndex = -1;
            cbxCodSubcat.SelectedIndex = -1;
            txtQuantidade.Clear();
            cbxStatus.SelectedIndex = -1;
            cbxCodUnidadeMedida.SelectedIndex = -1;
        }

        //Metodo para verificar o que foi digitado
        public void VerificaDigito(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        //Metodo para salvar os dados do produto
        public static MItensCompra ListarProduto(string id)
        {
            //Criando o obj do tipo MeuMsgBox e configurando a sua exibição
            var prod = new frmCadastroProduto();
            //Pegando o id
            prod.txtCodigo.Text = id;
            //Exibindo os botões
            prod.Alterarbotoes(1);

            //Chamando o formulario
            prod.ShowDialog();
            return prod.Iten;
        }
        public static MItensCompra ListarProduto(MItensCompra itens)
        {
            //Criando o obj do tipo MeuMsgBox e configurando a sua exibição
            var prod = new frmCadastroProduto();
            prod.txtCodigo.Text = itens.ItemCompraCodigo.ToString();
            prod.txtNome.Text = itens.Produto.NomeProduto;
            prod.txtQuantidade.Text = itens.Produto.QuantProduto.ToString();
            prod.txtDescricao.Text = itens.Produto.DescricaoProduto.ToString();
            prod.txtValorVenda.Text = itens.Produto.ValorVendaProduto.ToString();
            prod.txtValorPago.Text = itens.ItemCompraValor.ToString();
            prod.txtQuantidade.Text = itens.Produto.QuantProduto.ToString();
            prod.cbxStatus.Text = itens.Produto.StatusProduto.ToString();
            prod.txtCodBarra.Text = itens.ItemCompraCodBarra.ToString();
            prod.dtpDataValidade.Value = itens.ItemCompraDataVencimento;

            //Exibindo os botões
            prod.Alterarbotoes(1);

            //Redefininado o tamanho do formulario
            prod.Size = new System.Drawing.Size(679, 420);

            //Alterando texto do botão
            prod.btnSalvar.Text = "Alterar";

            //Ocutando componentes
            prod.dgvProduto.Visible = false;
            prod.btnAlterar.Visible = false;
            prod.btnBuscar.Visible = false;
            prod.txtConsultaProduto.Visible = false;
            prod.lblProduto.Visible = false;

            //Passando os valores do combo box
            prod.cbxCodCat.SelectedValue = itens.Produto.CodigoCategoria;
            prod.cbxCodSubcat.SelectedValue = itens.Produto.CodigoSubcategoria;
            prod.cbxCodUnidadeMedida.SelectedValue = itens.Produto.CodigoUnidadeMedida;



            //Chamando o formulario
            prod.ShowDialog();
            prod.Iten.ItemCompraCodigo = int.Parse(prod.txtCodigo.Text);
            return prod.Iten;
        }


        public void CarregarComboBox()
        {
            //Iniciando os dados do combobox Unidade Medida
            cbxCodUnidadeMedida.DataSource = DALUnidadeMedida.CarregarGrid();
            cbxCodUnidadeMedida.ValueMember = "uniMedida_cod";
            cbxCodUnidadeMedida.DisplayMember = "uniMedida_nome";
            cbxCodUnidadeMedida.SelectedIndex = -1;


            //Iniciando os dados do combobox Categoria
            cbxCodCat.DataSource = DALCategoria.CarregarGrid();
            cbxCodCat.ValueMember = "categoria_cod";
            cbxCodCat.DisplayMember = "categoria_nome";
            cbxCodCat.SelectedIndex = -1;

            if (cbxCodCat.Text != "") //Analisnado se já foi selecionado alguma categoria
            {
                //Iniciando os dados do combobox Subcategoria com todas as subcategoriras pertecentes a aquela categoria selecionada
                cbxCodSubcat.DataSource = DALSubCategoria.CarregarGrid(int.Parse(cbxCodCat.SelectedValue.ToString()));
                cbxCodSubcat.ValueMember = "subCategoria_cod";
                cbxCodSubcat.DisplayMember = "subCategoria_nome";
                cbxCodSubcat.SelectedIndex = -1;
            }
            else
            {
                //Iniciando os dados do combobox Subcategoria com todas as subcategoriras pertecentes a aquela categoria selecionada
                cbxCodSubcat.DataSource = DALSubCategoria.CarregarGrid();
                cbxCodSubcat.ValueMember = "subCategoria_cod";
                cbxCodSubcat.DisplayMember = "subCategoria_nome";
                cbxCodSubcat.SelectedIndex = -1;
            }
        }

        //Metodo para alterar a exibição dos botões
        public void Alterarbotoes(int op)
        {
            lblCodigo.Visible = false;
            txtCodigo.Visible = false;
            lblNome.Visible = false;
            txtNome.Visible = false;
            lblDescricao.Visible = false;
            txtDescricao.Visible = false;
            lblValorPago.Visible = false;
            txtValorPago.Visible = false;
            lblValorVenda.Visible = false;
            txtValorVenda.Visible = false;
            lblQuantidade.Visible = false;
            txtQuantidade.Visible = false;
            lblStatus.Visible = false;
            cbxStatus.Visible = false;
            lblUnidadeMedida.Visible = false;
            cbxCodUnidadeMedida.Visible = false;
            lblCodCat.Visible = false;
            cbxCodCat.Visible = false;
            lblSubCat.Visible = false;
            cbxCodSubcat.Visible = false;
            lblProduto.Visible = false;
            txtConsultaProduto.Visible = false;

            dgvProduto.Visible = false;

            btnAlterar.Visible = false;
            btnBuscar.Visible = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnLimpar.Visible = false;


            if (op == 0) //Quando acessado pela tela principal
            {
                //Mudando o tamanho do formulario
                this.Size = new System.Drawing.Size(679, 300);

                lblProduto.Visible = true;
                txtConsultaProduto.Visible = true;
                btnBuscar.Visible = true;
                dgvProduto.Visible = true;
                btnAlterar.Visible = true;

                lblProduto.Location = new Point(lblProduto.Location.X, lblProduto.Location.Y - 355); //Mudando a locaçização da LBL 
                txtConsultaProduto.Location = new Point(txtConsultaProduto.Location.X, txtConsultaProduto.Location.Y - 348); //Mudando a locaçização do txt
                btnBuscar.Location = new Point(btnBuscar.Location.X, btnBuscar.Location.Y - 348); //Mudando a locaçização do botão 
                dgvProduto.Location = new Point(dgvProduto.Location.X, dgvProduto.Location.Y - 350); //Mudando a locaçização do datagrid 
                btnAlterar.Location = new Point(btnAlterar.Location.X, btnAlterar.Location.Y - 350); //Mudando a locaçização do botão 

                //Carregando os dados
                dgvProduto.DataSource = DALProduto.CarregarGrid();
                dgvProduto.Columns["ValorVenda"].DefaultCellStyle.Format = "C2";
            }

            if (op == 1) //Acessado pela tela compra
            {
                //Redefininado o tamanho do formulario
                this.Size = new System.Drawing.Size(679, 641);

                btnSalvar.Text = "Adicionar";
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnLimpar.Visible = true;

                CarregarComboBox();

                lblCodCat.Visible = true;
                txtCodigo.Visible = true;
                lblNome.Visible = true;
                txtNome.Visible = true;
                lblDescricao.Visible = true;
                txtDescricao.Visible = true;
                lblValorPago.Visible = true;
                txtValorPago.Visible = true;
                txtValorPago.Enabled = true;
                lblValorVenda.Visible = true;
                txtValorVenda.Visible = true;
                lblQuantidade.Visible = true;
                txtQuantidade.Visible = true;
                txtQuantidade.Enabled = true;
                lblStatus.Visible = true;
                cbxStatus.Visible = true;
                lblUnidadeMedida.Visible = true;
                cbxCodUnidadeMedida.Visible = true;
                lblCodCat.Visible = true;
                cbxCodCat.Visible = true;
                lblSubCat.Visible = true;
                cbxCodSubcat.Visible = true;

                lblCodBarra.Visible = true;
                txtCodBarra.Visible = true;
                lblDataValidade.Visible = true;
                dtpDataValidade.Visible = true;

                lblProduto.Visible = true;
                txtConsultaProduto.Visible = true;
                btnBuscar.Visible = true;
                dgvProduto.Visible = true;

                btnAlterar.Text = "ADD";
                btnAlterar.Visible = true;

                btnSalvar.Location = new Point(btnSalvar.Location.X, btnSalvar.Location.Y + 33); //Mudando a locaçização do botão 
                btnLimpar.Location = new Point(btnLimpar.Location.X, btnLimpar.Location.Y + 33); //Mudando a locaçização do botão 
                btnCancelar.Location = new Point(btnCancelar.Location.X, btnCancelar.Location.Y + 33); //Mudando a locaçização do botão 


                //Carregando os dados
                dgvProduto.DataSource = DALProduto.CarregarGrid();
                dgvProduto.Columns["ValorVenda"].DefaultCellStyle.Format = "C2";
            }

            if (op == 2) //Atualizar
            {
                //Redefininado o tamanho do formulario
                this.Size = new System.Drawing.Size(679, 382);

                btnSalvar.Text = "Atualizar";
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnLimpar.Visible = true;

                CarregarComboBox();

                lblCodigo.Visible = true;
                txtCodigo.Visible = true;
                lblNome.Visible = true;
                txtNome.Visible = true;
                lblDescricao.Visible = true;
                txtDescricao.Visible = true;
                lblValorPago.Visible = true;
                txtValorPago.Visible = true;
                lblValorVenda.Visible = true;
                txtValorVenda.Visible = true;
                lblQuantidade.Visible = true;
                txtQuantidade.Visible = true;
                lblStatus.Visible = true;
                cbxStatus.Visible = true;
                lblUnidadeMedida.Visible = true;
                cbxCodUnidadeMedida.Visible = true;
                lblCodCat.Visible = true;
                cbxCodCat.Visible = true;
                lblSubCat.Visible = true;
                cbxCodSubcat.Visible = true;

                //Resetando a localização 
                lblProduto.Location = new Point(lblProduto.Location.X, lblProduto.Location.Y + 355); //Mudando a locaçização da LBL 
                txtConsultaProduto.Location = new Point(txtConsultaProduto.Location.X, txtConsultaProduto.Location.Y + 348); //Mudando a locaçização do txt
                btnBuscar.Location = new Point(btnBuscar.Location.X, btnBuscar.Location.Y + 348); //Mudando a locaçização do botão 
                dgvProduto.Location = new Point(dgvProduto.Location.X, dgvProduto.Location.Y + 350); //Mudando a locaçização do datagrid 
                btnAlterar.Location = new Point(btnAlterar.Location.X, btnAlterar.Location.Y + 350); //Mudando a locaçização do botão  
            }
        }

        //Evento click Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Analisando se existe dados no dataGrid
            if (dgvProduto.RowCount != 0)
            {
                if (btnAlterar.Text == "Alterar")
                {
                    //Alterar Botões
                    Alterarbotoes(2);
                }

                //Pegando dados do DataGrid                
                txtCodigo.Text = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();
                txtNome.Text = dgvProduto.CurrentRow.Cells["nome"].Value.ToString();
                txtDescricao.Text = dgvProduto.CurrentRow.Cells["descricao"].Value.ToString();

                //Pegando o valor venda e formatando
                double valorVenda = double.Parse(dgvProduto.CurrentRow.Cells["valorVenda"].Value.ToString());
                txtValorVenda.Text = valorVenda.ToString("F2");

                cbxStatus.Text = dgvProduto.CurrentRow.Cells["status"].Value.ToString();

                cbxCodUnidadeMedida.Text = dgvProduto.CurrentRow.Cells["uniNome"].Value.ToString();
                cbxCodCat.Text = dgvProduto.CurrentRow.Cells["CatNome"].Value.ToString();
                cbxCodSubcat.Text = dgvProduto.CurrentRow.Cells["SubNome"].Value.ToString();
                txtQuantidade.Text = dgvProduto.CurrentRow.Cells["quant"].Value.ToString();

                //Pegando valores do item compra
                var table = DALItensCompra.PegarDados(int.Parse(txtCodigo.Text));

                //Pegando o valor compra e formatando
                double valorCompra = double.Parse(table.Rows[0]["itensCompra_valor"].ToString());
                txtValorPago.Text = valorCompra.ToString("F2");

            }
        }

        //Evento para quando uma categoria é selecionada
        private void cbxCodCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Iniciando os dados do combobox Subcategoria com todas as subcategoriras pertecentes a aquela categoria selecionada
            cbxCodSubcat.DataSource = DALSubCategoria.CarregarGrid(int.Parse(cbxCodCat.SelectedValue.ToString()));
            cbxCodSubcat.ValueMember = "subCategoria_cod";
            cbxCodSubcat.DisplayMember = "subCategoria_nome";
            cbxCodSubcat.SelectedIndex = -1;
        }

        //Evento click do botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificando se o usuário informou todos os campos obrigatorios
                if (txtNome.Text == "" || txtDescricao.Text == "" || cbxStatus.Text == "" || cbxCodUnidadeMedida.Text == "" || cbxCodCat.Text == "" || txtValorPago.Text == "")
                {
                    throw new Exception("Preencha todos os Campos!");
                }

                //Instenciando o objeto
                MProduto produto = new MProduto(txtNome.Text, txtDescricao.Text, double.Parse(txtValorVenda.Text), double.Parse(txtQuantidade.Text), cbxStatus.Text, int.Parse(cbxCodUnidadeMedida.SelectedValue.ToString()), int.Parse(cbxCodCat.SelectedValue.ToString()));

                //Verificando se tem uma subcategria
                if (cbxCodSubcat.Text != "")
                {
                    produto.CodigoSubcategoria = int.Parse(cbxCodSubcat.SelectedValue.ToString());
                }

                //Verificando se vai ser atualizado ou cadastrado
                if (btnSalvar.Text == "Atualizar")
                {
                    produto.CodigoProduto = int.Parse(txtCodigo.Text); //Passando o id
                    BLLProduto.Alterar(produto); //Chamando o metodo alterar
                    MessageBox.Show("Alteração realizada com sucesso!");
                }
                else if (txtQuantidade.Enabled == true) //Analisando se será adcinando um produto a uma compra
                {
                    produto.CodigoProduto = int.Parse(txtCodigo.Text); //Pegando o id

                    Iten = new MItensCompra(double.Parse(txtQuantidade.Text), double.Parse(txtValorPago.Text), txtCodBarra.Text, dtpDataValidade.Value.Date, produto);

                    Close(); //Fechando o formulario
                }
                //Padrão
                Alterarbotoes(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //Evento click buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduto.DataSource = BLLProduto.LocalizarDados(txtConsultaProduto.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        //Evento click limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
        //Evento click Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Enabled == true) //Analisando se será adcinando um produto a uma compra
            {
                Close(); //Fechando o formulario caso o mesmo tenha sido aberto pela tela compra
            }
            else
            {
                Alterarbotoes(0); //Reexibindo o dataGrid com os produtos
                txtCodigo.Clear();
            }
        }


        //Area para verificar se o usuário digitou apenas numeros e uma unica virgula
        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);
        }
        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);
        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);
        }
    }
}

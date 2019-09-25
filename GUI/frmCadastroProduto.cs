using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        public MProduto Produto { get; set; }

        public void LimparTela()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtValorVenda.Clear();
            txtValorPago.Clear();
            cbxCodCat.SelectedIndex = -1;
            cbxCodSubcat.SelectedIndex = -1;
            txtQuantidade.Clear();
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
        public static MProduto ListarProduto(string id)
        {
            //Criando o obj do tipo MeuMsgBox e configurando a sua exibição
            var prod = new frmCadastroProduto();
            //Redefininado o tamanho do formulario
            prod.Size = new System.Drawing.Size(679, 385);
            //Pegando o id
            prod.txtCodigo.Text = id;
            //Ativando a edição do campo Quantidade produto
            prod.txtQuantidade.Enabled = true;

             //Chamando o formulario
             prod.ShowDialog();
            return prod.Produto;
        }

        //Metodo para alterar a exibição dos botões
        public void Alterarbotoes(int op)
        {
            btnAlterar.Enabled = false;
            btnBuscar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;

            if (op == 1) //Padrão
            {
                btnSalvar.Text = "Cadastrar";
                btnBuscar.Enabled = true;
                btnSalvar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                LimparTela();
                //Carregando os dados
                dgvProduto.DataSource = DALProduto.CarregarGrid();
                dgvProduto.Columns["valorpago"].DefaultCellStyle.Format = "C2";
                dgvProduto.Columns["ValorVenda"].DefaultCellStyle.Format = "C2";
            }

            if (op == 2) //Atualizar
            {
                btnSalvar.Text = "Atualizar";
                btnSalvar.Enabled = true;
                btnCancelar.Visible = true;
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
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
                       
            //Padrão
            Alterarbotoes(1);
        }

        //Evento click Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Analisando se existe dados no dataGrid
            if (dgvProduto.RowCount != 0)
            {
                //Pegando dados do DataGrid                
                txtCodigo.Text = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();
                txtNome.Text = dgvProduto.CurrentRow.Cells["nome"].Value.ToString();
                txtDescricao.Text = dgvProduto.CurrentRow.Cells["descricao"].Value.ToString();

                //Pegando o valor pago e formatando 
                double valorPago = double.Parse(dgvProduto.CurrentRow.Cells["valorpago"].Value.ToString());
                txtValorPago.Text = valorPago.ToString("F2");
                //Pegando o valor venda e formatando
                double valorVenda = double.Parse(dgvProduto.CurrentRow.Cells["valorVenda"].Value.ToString());
                txtValorVenda.Text = valorVenda.ToString("F2");

                cbxCodUnidadeMedida.Text = dgvProduto.CurrentRow.Cells["uniNome"].Value.ToString();
                cbxCodCat.Text = dgvProduto.CurrentRow.Cells["CatNome"].Value.ToString();
                cbxCodSubcat.Text = dgvProduto.CurrentRow.Cells["SubNome"].Value.ToString();
                txtQuantidade.Text = dgvProduto.CurrentRow.Cells["quant"].Value.ToString();

                //Alterar Botões
                Alterarbotoes(2);
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
                if (txtNome.Text == "" || txtDescricao.Text == "" || cbxCodUnidadeMedida.Text == "" || cbxCodCat.Text == "" || txtValorPago.Text == "")
                {
                    throw new Exception("Preencha todos os Campos!");
                }

                //Instenciando o objeto
                MProduto prod = new MProduto(txtNome.Text, txtDescricao.Text, double.Parse(txtValorPago.Text), double.Parse(txtValorVenda.Text), double.Parse(txtQuantidade.Text), int.Parse(cbxCodUnidadeMedida.SelectedValue.ToString()), int.Parse(cbxCodCat.SelectedValue.ToString()));

                //Verificando se tem uma subcategria
                if (cbxCodSubcat.Text != "")
                {
                    prod.CodigoSubcategoria = int.Parse(cbxCodSubcat.SelectedValue.ToString());
                }

                //Verificando se vai ser atualizado ou cadastrado
                if (btnSalvar.Text == "Atualizar")
                {
                    prod.CodigoProduto = int.Parse(txtCodigo.Text); //Passando o id
                    BLLProduto.Alterar(prod); //Chamando o metodo alterar
                    MessageBox.Show("Alteração realizada com sucesso!");
                }
                else if(txtQuantidade.Enabled == true) //Analisando se será adcinando um produto a uma compra
                {
                    Produto = new MProduto(txtNome.Text, txtDescricao.Text, double.Parse(txtValorPago.Text), double.Parse(txtValorVenda.Text), double.Parse(txtQuantidade.Text), int.Parse(cbxCodUnidadeMedida.SelectedValue.ToString()), int.Parse(cbxCodCat.SelectedValue.ToString()));

                    //Verificando se tem uma subcategria
                    if (cbxCodSubcat.Text != "")
                    {
                        Produto.CodigoSubcategoria = int.Parse(cbxCodSubcat.SelectedValue.ToString());
                    }

                    Produto.CodigoProduto = int.Parse(txtCodigo.Text); //Pegando o id

                    Close(); //Fechando o formulario
                }
                else
                {
                    BLLProduto.Incluir(prod); //Chamando o metodo cadastrar
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                //Padrão
                Alterarbotoes(1);
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
        //Evento click excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Aqui ele executa um diálogo perguntando se o usuário deseja ou não excluir o registro.
                if (MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    /*Caso "sim", é aberto a conexão com o banco e executado o método de excluir. */
                    //Método de excluir sendo chamado.
                    BLLProduto.Excluir(int.Parse(dgvProduto.CurrentRow.Cells["codigo"].Value.ToString()));
                    LimparTela();
                    Alterarbotoes(1);
                }
            }
            catch
            {
                //Caso apresente algum erro. Será retornado esta mensagem.
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local");
                Alterarbotoes(1);
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
            Alterarbotoes(1);
            txtCodigo.Clear();
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

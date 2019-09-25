using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastrarCompra : Form
    {
        public frmCadastrarCompra()
        {
            InitializeComponent();
        }

        List<MProduto> produtos = new List<MProduto>(); //Lista para armazenar os produtos da compra

        //Evento Load
        private void frmCompra_Load(object sender, EventArgs e)
        {
            //Carregando as compras
            dgvCompra.DataSource = DALCompra.CarregarGrid();
            dgvCompra.Columns["CompraTotal"].DefaultCellStyle.Format = "C2";

            //Iniciando os dados do combobox Tipo Pagamento
            cbxTipoPagamento.DataSource = DALTipoPagamento.CarregarGrid();
            cbxTipoPagamento.ValueMember = "tipoPag_cod";
            cbxTipoPagamento.DisplayMember = "tipoPag_nome";
            cbxTipoPagamento.SelectedIndex = -1;

            //Iniciando os dados do combobox Fornecedor
            cbxFornecedor.DataSource = DALFornecedor.CarregarGrid();
            cbxFornecedor.ValueMember = "fornecedor_cod";
            cbxFornecedor.DisplayMember = "fornecedor_nome";
            cbxFornecedor.SelectedIndex = -1;
        }


        //Metodo para limpar os campos inclusive as lista
        public void Limpar()
        {
            //Limpando os campos 
            txtNotaFiscal.Clear();
            txtValor.Clear();
            txtValorParcela.Clear();
            cbxQuantParcela.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            cbxFornecedor.SelectedIndex = -1;
            cbxTipoPagamento.SelectedIndex = -1;
            dtpDataCompra.Value = DateTime.Today;

            //Analisando se o usuário deseja apagar os produtos
            if (DialogResult.Yes == MessageBox.Show("Deseja apagar os produtos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                produtos.Clear(); //Limapando os produtos
                CarregarGrid(); //Carregando o Grid
                MessageBox.Show("Produtos apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Informando ao usuário que os produtos foram apagados

            }
        }
        //Carregando as informações do DataGrid
        public void CarregarGrid()
        {
            dgvProduto.DataSource = ""; //Limpando o dataGrid

            dgvProduto.DataSource = produtos; //Passando a lista

            //Mudando os titulos
            dgvProduto.Columns[0].HeaderText = "Código";
            dgvProduto.Columns[0].Visible = false;
            dgvProduto.Columns[1].HeaderText = "Nome";
            dgvProduto.Columns[2].HeaderText = "Descrição";
            dgvProduto.Columns[3].HeaderText = "Valor Pago";
            dgvProduto.Columns[3].DefaultCellStyle.Format = "C2";
            dgvProduto.Columns[4].DefaultCellStyle.Format = "C2";
            dgvProduto.Columns[4].HeaderText = "Valor Venda";
            dgvProduto.Columns[5].HeaderText = "Quantidade";
            dgvProduto.Columns[6].HeaderText = "Código Unidade Medida";
            dgvProduto.Columns[6].Visible = false;
            dgvProduto.Columns[7].HeaderText = "Código Categoria";
            dgvProduto.Columns[7].Visible = false;
            dgvProduto.Columns[8].HeaderText = "Código SubCategoria";
            dgvProduto.Columns[8].Visible = false;

            //Recarregando
            dgvProduto.Refresh();

            //Chamando o metodo calculo
            Calcular();
        }
        //Metodo para calcular os valor total, valor de cada parcela
        public void Calcular()
        {
            double valorTotal = 0.0;

            //Calculando o valor total
            foreach (var item in produtos)
            {
                valorTotal += item.ValorPagoProduto * item.QuantProduto;
            }

            txtValor.Text = valorTotal.ToString("F2"); //Passando o valor total

            //Analisando se já foi selecionado a opção de parcelas
            if (cbxQuantParcela.Text != "")
            {
                MParcelasCompra parc = new MParcelasCompra(); //Instanciando 

                //Passando o valor da parcela                
                txtValorParcela.Text = parc.ValorParcela(double.Parse(txtValor.Text), int.Parse(cbxQuantParcela.Text)).ToString("F2");
            }
        }


        //Evento Click ADD produto
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0; //Armazenando o id

                //Analisando se já existe registro no data grid, caso exista será carregado o id 
                if (dgvProduto.Rows.Count != 0)
                {
                    id = int.Parse(dgvProduto.Rows[dgvProduto.RowCount - 1].Cells[0].Value.ToString()) + 1;
                }
                else //Caso não será passado o id 1
                {
                    id = 1;
                }

                //Pegando o produto
                produtos.Add(frmCadastroProduto.ListarProduto(id.ToString()));

                //Analisando se o usuário não fechou a tela e consequentemente retornou um produto vazio
                if (produtos[produtos.Count - 1] != null)
                {
                    CarregarGrid();
                }
                else //Caso tenha retornado vazio, o ultimo indice será removido 
                {
                    produtos.RemoveAt(produtos.Count - 1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "OK");
            }
        }
        //Evenoto click salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNotaFiscal.Text == "" || cbxQuantParcela.Text == "" || cbxStatus.Text == "" || cbxFornecedor.Text == "" || cbxTipoPagamento.Text == "") //Analisando se foi preenchido todos os dados
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else if (DateTime.Today > dtpDataCompra.Value.Date) //Analisando se a data informada é maior ou igual a hora atual
            {
                MessageBox.Show("A Data da compra não pode ser menor que a data atual!");
            }
            else if (dgvProduto.RowCount == 0) //Analisando se foi informado algum produto
            {
                MessageBox.Show("Adicione os produtos!", "OK");
            }
            else
            {
                try
                {
                    //Salvando a compra
                    MCompra compra = new MCompra(dtpDataCompra.Value.Date, txtNotaFiscal.Text, double.Parse(txtValor.Text), int.Parse(cbxQuantParcela.Text), cbxStatus.Text, (int)cbxFornecedor.SelectedValue, (int)cbxTipoPagamento.SelectedValue);
                    BLLCompra.Incluir(compra);

                    //Criando um variavel para salvar a data da nova prestação
                    DateTime ProximaPrestação = dtpDataCompra.Value.Date;

                    //Salvando as Parcelas
                    MParcelasCompra parcela = new MParcelasCompra(double.Parse(txtValorParcela.Text), ProximaPrestação, ProximaPrestação, int.Parse(DALCompra.PegarId()));
                    BLLParcelasCompras.Incluir(int.Parse(cbxQuantParcela.Text), parcela);

                    //Salvando os Produtos e consequentemente o item
                    foreach (var item in produtos)
                    {
                        //Chamando o metodo Incluir um produto
                        BLLProduto.Incluir(item);

                        //Salvando o produto na lista item
                        MItensCompra itensCompra = new MItensCompra(item.QuantProduto, item.ValorPagoProduto, int.Parse(DALCompra.PegarId()));
                        BLLItensCompra.Incluir(itensCompra);
                    }
                }
                catch (SqlException erro)
                {
                    MessageBox.Show(erro.Message, "OK");
                    //Apagando tudo caso haja um erro
                    DALCompra.Excluir(int.Parse(DALCompra.PegarId()));
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "OK");
                    //Apagando tudo caso haja um erro
                    DALCompra.Excluir(int.Parse(DALCompra.PegarId()));
                }
            }
        }
        //Evento click para excluir o produto da lista
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            //Analisando se tem item para ser excluido
            if (dgvProduto.RowCount != 0)
            {
                try
                {
                    produtos.RemoveAt(int.Parse(dgvProduto.CurrentRow.Cells[0].Value.ToString()) - 1); //Removendo da lista
                    CarregarGrid(); //Recarregando o DataGrid
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "OK");
                }

            }
            else
            {
                MessageBox.Show("Não tem produto para ser excluido", "OK");
            }
        }
        //Evendo click para quando o combo box for alterado
        private void cbxQuantParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calcular(); //Recalculando
        }
        //Evento click Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}

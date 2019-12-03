using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        MVenda Venda = new MVenda();
        public double ValorTotal { get; set; }

        //Chamando o formulario categoria
        private void categoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }
        //Chamando o formulario subcategoria
        private void subCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.Alterarbotoes(0);
            f.ShowDialog();
            f.Dispose();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCompra f = new frmCadastrarCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();

        }

        private void conexãoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConexaoBD f = new frmConexaoBD();
            f.ShowDialog();
            f.Dispose();
        }

        private void MenuFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario f = new frmFuncionario();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = DALProduto.CarregarProdutosDisponiveisParaCompra();
            dgvProduto.Columns["ValorVenda"].DefaultCellStyle.Format = "C2";
            txtValorTotal.Text = "R$0,00";
        }


        /**********************************************
         * ************** Funções Vender **************
         * ********************************************/

        //Metodo para verificar se o produto já existe na lista de venda
        public bool VerificarExistenciaNaLista(int codProduto)
        {
            bool resultado = true;

            if (dgvProdutoVenda.RowCount > 0) //Analisando se existe algum produto na lista
            {
                //Pecorrendo os itens da lista de venda
                foreach (var item in Venda.Itens)
                {
                    if (item.Produto.CodigoProduto == codProduto) //Analisando se existe
                    {
                        resultado = false;
                    }
                }
            }

            return resultado;
        }

        //Carregando as informações do DataGrid
        public void CarregarGrid()
        {
            //Limpando as linhas do dataGrid
            dgvProdutoVenda.Rows.Clear();


            //Pecorrendo a lista de itens
            foreach (var dados in Venda.Itens)
            {
                // cria uma linha
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvProdutoVenda);

                //Passando os valores para cada coluna
                item.Cells[0].Value = dados.Produto.CodigoProduto;
                item.Cells[1].Value = dados.Produto.NomeProduto;
                item.Cells[2].Value = dados.Produto.ValorVendaProduto;
                item.Cells[3].Value = dados.ItensVendaQuant;
                item.Cells[4].Value = dados.ItensVendaValor;

                //Pegando o valor Total
                ValorTotal += dados.ItensVendaValor;

                // adiciona na grid
                dgvProdutoVenda.Rows.Add(item);
                dgvProdutoVenda.Columns["produto_valorvenda"].DefaultCellStyle.Format = "C2";
                dgvProdutoVenda.Columns["total"].DefaultCellStyle.Format = "C2";
            }

            txtValorTotal.Text = ValorTotal.ToString("C2"); //Passando o valor total
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduto.DataSource = BLLProduto.LocalizarProdutoParaCompra(txtConsultaProduto.Text); //Buscando os produtos
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaNaLista(int.Parse(dgvProduto.CurrentRow.Cells["codigo"].Value.ToString())) == true) //Verificando a existencia do produto na lista
            {
                try
                {
                    //Pegando dados do DataGrid                
                    int cod = int.Parse(dgvProduto.CurrentRow.Cells["codigo"].Value.ToString());
                    string nome = dgvProduto.CurrentRow.Cells["nome"].Value.ToString();
                    double quantEstoque = double.Parse(dgvProduto.CurrentRow.Cells["quant"].Value.ToString());
                    double valorVenda = double.Parse(dgvProduto.CurrentRow.Cells["valorVenda"].Value.ToString());

                    //Pegando a quantidade de produto
                    Double quantProduto = frmQuantidadeProduto.AddQuantidade(dgvProduto.CurrentRow.Cells["nome"].Value.ToString(), double.Parse(dgvProduto.CurrentRow.Cells["quant"].Value.ToString()));

                    //Analisando se o usuário não fechou a tela e consequentemente retornou a quantidade 0
                    if (quantProduto != 0.0)
                    {
                        //Instanciando um produto apenas com o campos necessário
                        MProduto ProdTemp = new MProduto();
                        ProdTemp.CodigoProduto = cod;
                        ProdTemp.NomeProduto = nome;
                        ProdTemp.ValorVendaProduto = valorVenda;
                        ProdTemp.QuantProduto = quantEstoque;
                        //Instanciando um iten 
                        MItensVenda temp = new MItensVenda(quantProduto, ProdTemp);
                        temp.Valor();
                        //Add os dados ao objeto venda 
                        Venda.Itens.Add(temp);
                        //Carregando o Grid com as novas alterações
                        CarregarGrid();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "OK");
                }
            }
            else
            {
                MessageBox.Show("O produto já existe na lista!", "OK");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dgvProdutoVenda.RowCount > 0)
            {
                //Analisando se o usuário deseja apagar os produtos
                if (DialogResult.Yes == MessageBox.Show("Deseja apagar os produtos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    Venda.Itens.Clear(); //Limapando os produtos
                    CarregarGrid(); //Carregando o Grid
                    MessageBox.Show("Produtos apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Informando ao usuário que os produtos foram apagados
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutoVenda.RowCount > 0)
                {
                    //Analisando se o usuário deseja ou não excluir o produto.
                    if (MessageBox.Show("Deseja excluir o produto selecionado?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Removendo o produto
                        Venda.Itens.RemoveAt(dgvProdutoVenda.CurrentCell.RowIndex);
                        CarregarGrid();
                    }
                }
            }
            catch
            {
                //Caso apresente algum erro. Será retornado esta mensagem.
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutoVenda.RowCount > 0)
                {
                    //Pegando a quantidade de produto
                    Double quantProduto = frmQuantidadeProduto.AddQuantidade(dgvProdutoVenda.CurrentRow.Cells["produto_nome"].Value.ToString(), double.Parse(dgvProduto.CurrentRow.Cells["quant"].Value.ToString()));

                    //Analisando se o usuário não fechou a tela e consequentemente retornou a quantidade 0
                    if (quantProduto != 0.0)
                    {
                        Venda.Itens[dgvProdutoVenda.CurrentCell.RowIndex].ItensVendaQuant = quantProduto;
                        Venda.Itens[dgvProdutoVenda.CurrentCell.RowIndex].Valor();

                        CarregarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (dgvProdutoVenda.RowCount > 0)
            {
                string resultado = frmFinalizarCompra.Finalizar(int.Parse(txtCod.Text), ValorTotal, Venda.Itens);

                if (resultado == "OK")
                {
                    dgvProduto.DataSource = DALProduto.CarregarProdutosDisponiveisParaCompra();
                    dgvProduto.Columns["ValorVenda"].DefaultCellStyle.Format = "C2";
                    ValorTotal = 0.0;
                    txtValorTotal.Text = "R$0,00";
                    Venda.Itens.Clear(); //Limapando os produtos
                    CarregarGrid(); //Carregando o Grid
                }
            }
            else
            {
                MessageBox.Show("Não tem nenhum produto sendo comprado!");
            }
        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            vendas.Show();
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            dgvProduto.DataSource = DALProduto.CarregarProdutosDisponiveisParaCompra();
        }
    }
}

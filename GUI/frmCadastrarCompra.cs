using BLL;
using DAL;
using Modelo;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI
{
    //TODO criar um metodo para verificar se a compra foi finalizada, para realizar a incrementação do produtos dentro do estoque

    public partial class frmCadastrarCompra : Form
    {
        public frmCadastrarCompra()
        {
            InitializeComponent();
        }

        MCompra Compra = new MCompra();
        MCompra CompraAnterior = new MCompra();
        List<int> ListaProdutosExcluidos = new List<int>();
        List<int> ListaItensExcluidos = new List<int>();
        //List<int> ListaADD = new List<int>();

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
                Compra.Itens.Clear(); //Limapando os produtos
                CarregarGrid(); //Carregando o Grid
                MessageBox.Show("Produtos apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Informando ao usuário que os produtos foram apagados

            }
        }
        //Carregando as informações do DataGrid
        public void CarregarGrid()
        {
            //Limpando as linhas do dataGrid
            dgvProduto.Rows.Clear();

            //Pecorrendo a lista de itens
            foreach (var dados in Compra.Itens)
            {
                // cria uma linha
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvProduto);

                //Passando os valores para cada coluna
                item.Cells[0].Value = dados.ItemCompraCodigo;
                item.Cells[1].Value = dados.ItemCompraQuant;
                item.Cells[2].Value = dados.ItemCompraQuantVenda;
                item.Cells[3].Value = dados.ItemCompraValor;
                item.Cells[4].Value = dados.ItemCompraCodBarra;
                item.Cells[5].Value = dados.ItemCompraDataVencimento;
                item.Cells[6].Value = dados.Produto.CodigoProduto;
                item.Cells[7].Value = dados.Produto.NomeProduto;
                item.Cells[8].Value = dados.Produto.DescricaoProduto;
                item.Cells[9].Value = dados.Produto.ValorVendaProduto;
                item.Cells[10].Value = dados.Produto.QuantProduto;
                item.Cells[11].Value = dados.Produto.StatusProduto;
                item.Cells[12].Value = dados.Produto.CodigoUnidadeMedida;
                item.Cells[13].Value = dados.Produto.CodigoCategoria;
                item.Cells[14].Value = dados.Produto.CodigoSubcategoria;

                // adiciona na grid
                dgvProduto.Rows.Add(item);
            }


            //Chamando o metodo calculo
            Calcular();
        }
        //Metodo para calcular os valor total, valor de cada parcela
        public void Calcular()
        {
            //double valorTotal = double.Parse(txtValor.Text.ToString());
            double valorTotal = 00.00;

            //Calculando o valor total
            foreach (var item in Compra.Itens)
            {
                valorTotal += item.ItemCompraValor * item.ItemCompraQuant;
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
                //Pegando o produto
                Compra.Itens.Add(frmCadastroProduto.ListarProduto("0"));

                //Analisando se o usuário não fechou a tela e consequentemente retornou um produto vazio
                if (Compra.Itens[Compra.Itens.Count - 1] != null)
                {
                    CarregarGrid();
                }
                else //Caso tenha retornado vazio, o ultimo indice será removido 
                {
                    Compra.Itens.RemoveAt(Compra.Itens.Count - 1);
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
            if (btnSalvar.Text == "Salvar")
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
                        //Passando os dados da compra
                        Compra.CompraData = dtpDataCompra.Value.Date;
                        Compra.CompraNotaFiscal = txtNotaFiscal.Text;
                        Compra.CompraValor = double.Parse(txtValor.Text);
                        Compra.CompraParcelas = int.Parse(cbxQuantParcela.Text);
                        Compra.CompraStatus = cbxStatus.Text;
                        Compra.FornecedorCod = (int)cbxFornecedor.SelectedValue;
                        Compra.TipoPagCod = (int)cbxTipoPagamento.SelectedValue;
                        //Salnvando a compra
                        BLLCompra.Incluir(Compra);
                        //Pegando o id da compra salva
                        Compra.CompraCod = int.Parse(DALCompra.PegarId());
                        //Criando um variavel para salvar a data da nova prestação
                        DateTime ProximaPrestação = dtpDataCompra.Value.Date;
                        //Criando e salvando as parcelas
                        for (int i = 0; i < Compra.CompraParcelas; i++)
                        {
                            Compra.Parcelas.Add(new MParcelasCompra(double.Parse(txtValorParcela.Text), ProximaPrestação.AddMonths(i + 1), Compra.CompraCod)); //Instanciando a parcela

                            //Salvando as Parcelas
                            BLLParcelasCompras.Incluir(Compra.Parcelas[i]);
                        }

                        //Salvando os Produtos e consequentemente o item
                        foreach (var item in Compra.Itens)
                        {
                            //Verificar se o produto não já existe, caso sim só será associado ao item compra
                            if (item.Produto.CodigoProduto == 0)
                            {
                                //Analisando  se a compra foi finalizada, pois caso seja o valor do produto será incrementado
                                if (cbxStatus.Text != "FINALIZADA")
                                {
                                    item.Produto.QuantProduto = 0;

                                    //Colando ele fora de Estoque, pois a compra não foi finalizada
                                    item.Produto.StatusProduto = "FORA DE ESTOQUE";
                                }

                                //Chamando o metodo Incluir um produto
                                BLLProduto.Incluir(item.Produto);
                            }
                            else //Significa que o produto já existe
                            {
                                var tabela = DALProduto.PegarDados(item.Produto.CodigoProduto); //Pegando os dados do produto já existente
                                //Passando os dados para as variáveis
                                int cod = int.Parse(tabela.Rows[0]["produto_cod"].ToString());
                                string nome = tabela.Rows[0]["produto_nome"].ToString();
                                string desc = item.Produto.DescricaoProduto;
                                double valor = item.Produto.ValorVendaProduto;
                                double quant = double.Parse(tabela.Rows[0]["produto_qtde"].ToString());
                                string status = item.Produto.StatusProduto;
                                int codUni = item.Produto.CodigoUnidadeMedida;
                                int codCat = item.Produto.CodigoCategoria;
                                int codSub = 0;
                                //Analisado se tem subcategoria 
                                if (tabela.Rows[0]["subCategoria_cod"].ToString() != "")
                                {
                                    codSub = int.Parse(tabela.Rows[0]["subCategoria_cod"].ToString());
                                }

                                //Analisando  se a compra foi finalizada, pois caso seja o valor do produto será incrementado
                                if (cbxStatus.Text == "FINALIZADA")
                                {
                                    quant = quant + item.ItemCompraQuant;
                                }
                                else if (quant == 1) //Analizando se ainda tem produto em estoque, caso não ele terá seu status mudado
                                {
                                    //Colando ele fora de Estoque, pois a compra não foi finalizada
                                    item.Produto.StatusProduto = "FORA DE ESTOQUE";
                                }

                                //Instanciando o obj produto
                                MProduto prodExiste = new MProduto(nome, desc, valor, quant, status, codUni, codCat, codSub);
                                prodExiste.CodigoProduto = cod; //Pegando o id
                                //Passando o id do produto
                                item.Produto.CodigoProduto = cod;
                                //Atualizando as informações
                                BLLProduto.Alterar(prodExiste);
                            }

                            //Passando o id da compra
                            item.CompraCodigo = Compra.CompraCod;
                            //Salvando o produto na lista item
                            BLLItensCompra.Incluir(item);
                        }
                        MessageBox.Show("Compra Salva Com Sucesso!");
                        dgvCompra.DataSource = DALCompra.CarregarGrid();
                        //Limpando os campos 
                        txtNotaFiscal.Clear();
                        txtValor.Clear();
                        txtValorParcela.Clear();
                        txtValor.Clear();
                        cbxQuantParcela.SelectedIndex = -1;
                        cbxStatus.SelectedIndex = -1;
                        cbxFornecedor.SelectedIndex = -1;
                        cbxTipoPagamento.SelectedIndex = -1;
                        dtpDataCompra.Value = DateTime.Today;
                        Compra.Itens.Clear(); //Limpando os produtos
                        CarregarGrid();
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
            else
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
                        //if Compra.Itens.
                        //Passando os dados da compra
                        Compra.CompraCod = int.Parse(txtCodigo.Text);
                        Compra.CompraData = dtpDataCompra.Value.Date;
                        Compra.CompraNotaFiscal = txtNotaFiscal.Text;
                        Compra.CompraValor = double.Parse(txtValor.Text);
                        Compra.CompraParcelas = int.Parse(cbxQuantParcela.Text);
                        Compra.CompraStatus = cbxStatus.Text;
                        Compra.FornecedorCod = (int)cbxFornecedor.SelectedValue;
                        Compra.TipoPagCod = (int)cbxTipoPagamento.SelectedValue;
                        //Salnvando a compra
                        BLLCompra.Alterar(Compra);

                        MParcelasCompra parcelas = new MParcelasCompra();
                        parcelas.CompraCodigo = Compra.CompraCod;
                        //Excluindo parcelas salvas
                        BLLParcelasCompras.Excluir(parcelas);

                        //Criando um variavel para salvar a data da nova prestação
                        DateTime ProximaPrestação = dtpDataCompra.Value.Date;
                        //Criando e salvando as parcelas



                        for (int i = 0; i < int.Parse(cbxQuantParcela.Text); i++)
                        {
                            Compra.Parcelas.Add(new MParcelasCompra(double.Parse(txtValorParcela.Text), ProximaPrestação.AddMonths(i), Compra.CompraCod)); //Instanciando a parcela

                            //Salvando as Parcelas
                            BLLParcelasCompras.Incluir(Compra.Parcelas[i]);
                        }

                        //excluindo os itens da lista de excluidos
                        foreach (var lista in ListaItensExcluidos)
                        {
                            //int teste = int.Parse(dgvProduto.CurrentRow.Cells[6].Value.ToString());
                            //BLLProduto.Alterar(int.Parse(dgvProduto.CurrentRow.Cells[6].Value.ToString()));
                            BLLItensCompra.Excluir(lista);
                        }
                        foreach (var lista in ListaProdutosExcluidos)
                        {
                            BLLProduto.Alterar(lista);
                        }

                        //Salvando os Produtos e consequentemente o item
                        foreach (var item in Compra.Itens)
                        {

                            //Analisando  se a compra foi finalizada, pois caso seja o valor do produto será incrementado
                            if (cbxStatus.Text != "FINALIZADA")
                            {
                                item.Produto.QuantProduto = 0;

                            }
                            else
                            {
                                item.Produto.QuantProduto = item.ItemCompraQuant;
                            }
                            if (item.Produto.QuantProduto == 0)
                            {
                                item.Produto.StatusProduto = "FORA DE ESTOQUE";
                            }

                            //Chamando o metodo Alterar um produto
                            BLLProduto.Alterar(item.Produto);


                            //Passando o id da compra
                            item.CompraCodigo = int.Parse(txtCodigo.Text);


                            //Salvando o produto na lista item
                            BLLItensCompra.Alterar(item);
                            //Salva o produto caso durante a alteração tenha sido criado o novo produto
                            if (item.Produto.CodigoProduto == 0)
                            {
                                //Analisando  se a compra foi finalizada, pois caso seja o valor do produto será incrementado
                                if (cbxStatus.Text != "FINALIZADA")
                                {
                                    item.Produto.QuantProduto = 0;


                                    //Colando ele fora de Estoque, pois a compra não foi finalizada
                                    item.Produto.StatusProduto = "FORA DE ESTOQUE";
                                }

                                //Chamando o metodo Incluir um produto
                                BLLProduto.Incluir(item.Produto);
                                //Passando o id da compra
                                item.CompraCodigo = Compra.CompraCod;
                                //Salvando o produto na lista item
                                BLLItensCompra.Incluir(item);
                            }
                            else
                            {
                                bool verificaexistencia = true;
                                foreach (var itensanterior in CompraAnterior.Itens)
                                {
                                    if (itensanterior.ItemCompraCodigo == item.ItemCompraCodigo)
                                    {
                                        verificaexistencia = true;
                                        break;
                                    }
                                    else
                                    {
                                        verificaexistencia = false;
                                        
                                    }
                                }
                                if (verificaexistencia == false)
                                {
                                    if (cbxStatus.Text != "FINALIZADA")
                                    {
                                        item.Produto.QuantProduto = 0;


                                        //Colando ele fora de Estoque, pois a compra não foi finalizada
                                        item.Produto.StatusProduto = "FORA DE ESTOQUE";
                                    }

                                    //Chamando o metodo Incluir um produto
                                    BLLProduto.Incluir(item.Produto);
                                    //Passando o id da compra
                                    item.CompraCodigo = Compra.CompraCod;
                                    //Salvando o produto na lista item
                                    BLLItensCompra.Incluir(item);
                                }
                            }
                        }
                        MessageBox.Show("Compra Salva Com Sucesso!");
                        dgvCompra.DataSource = DALCompra.CarregarGrid();
                        //Limpando os campos 
                        txtNotaFiscal.Clear();
                        txtValor.Clear();
                        txtValorParcela.Clear();
                        txtValor.Clear();
                        cbxQuantParcela.SelectedIndex = -1;
                        cbxStatus.SelectedIndex = -1;
                        cbxFornecedor.SelectedIndex = -1;
                        cbxTipoPagamento.SelectedIndex = -1;
                        dtpDataCompra.Value = DateTime.Today;
                        Compra.Itens.Clear(); //Limpando os produtos
                        CarregarGrid();
                        //alterando botões
                        btnSalvar.Text = "Salvar";
                        btnExcluir.Enabled = true;
                        btnExcluirProduto.Enabled = true;
                        btnAdicionarProduto.Enabled = true;
                        //limpando lista
                        ListaProdutosExcluidos.Clear();
                        ListaItensExcluidos.Clear();
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

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {

            try
            {
                //produto
                int codigoProduto = int.Parse(dgvProduto.CurrentRow.Cells[6].Value.ToString());
                string nomeProduto = dgvProduto.CurrentRow.Cells[7].Value.ToString();
                string descricaoProduto = dgvProduto.CurrentRow.Cells[8].Value.ToString();
                double valorVendaProduto = double.Parse(dgvProduto.CurrentRow.Cells[9].Value.ToString());
                double quantProduto = double.Parse(dgvProduto.CurrentRow.Cells[10].Value.ToString());
                int codigoUnidadeMedida = int.Parse(dgvProduto.CurrentRow.Cells[12].Value.ToString());
                string status = dgvProduto.CurrentRow.Cells[11].Value.ToString();
                int codigoCategoria = int.Parse(dgvProduto.CurrentRow.Cells[13].Value.ToString()); ;
                int codigoSubCategoria = int.Parse(dgvProduto.CurrentRow.Cells[14].Value.ToString());

                //itens
                int itemCompraCod = int.Parse(dgvProduto.CurrentRow.Cells[0].Value.ToString());
                double itemCompraQuant = double.Parse(dgvProduto.CurrentRow.Cells[1].Value.ToString());
                double itemCompraValor = double.Parse(dgvProduto.CurrentRow.Cells[3].Value.ToString()); ;
                string itensCompra_codigoBarra = dgvProduto.CurrentRow.Cells[4].Value.ToString();
                DateTime itensCompra_vencimento = DateTime.Parse(dgvProduto.CurrentRow.Cells[5].Value.ToString());

                //pegando produto
                MProduto prod = new MProduto(codigoProduto, nomeProduto, descricaoProduto, valorVendaProduto, quantProduto, status, codigoUnidadeMedida, codigoCategoria, codigoSubCategoria);
                //pegando item compra
                MItensCompra iten = new MItensCompra(itemCompraCod, itemCompraQuant, itemCompraValor, itensCompra_codigoBarra, itensCompra_vencimento, prod);
                //Adicionando a lista

                Compra.Itens[dgvProduto.CurrentCell.RowIndex] = frmCadastroProduto.ListarProduto(iten);

                //Analisando se o usuário não fechou a tela e consequentemente retornou um produto vazio
                if (Compra.Itens[dgvProduto.CurrentCell.RowIndex] != null)
                {
                    CarregarGrid();
                }
                else //Caso tenha retornado vazio, será atribido o valor que já estava salvo
                {
                    Compra.Itens[dgvProduto.CurrentCell.RowIndex] = iten;
                    CarregarGrid();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "OK");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Analisando se existe compras
            if (dgvCompra.Rows.Count != 0)
            {
                btnSalvar.Text = "Alterar";
                btnExcluir.Enabled = false;
                btnExcluirProduto.Enabled = true;
                btnAdicionarProduto.Enabled = true;
                Compra.Itens.Clear();
                CompraAnterior.Itens.Clear();
                Compra.Itens = DALCompra.CarregaListaProdutos(int.Parse(dgvCompra.CurrentRow.Cells["compraCod"].Value.ToString()));
                CompraAnterior.Itens = DALCompra.CarregaListaProdutos(int.Parse(dgvCompra.CurrentRow.Cells["compraCod"].Value.ToString()));

                txtCodigo.Text = dgvCompra.CurrentRow.Cells["CompraCod"].Value.ToString();
                txtNotaFiscal.Text = dgvCompra.CurrentRow.Cells["CompraNotaFiscal"].Value.ToString();
                dtpDataCompra.Value = DateTime.Parse(dgvCompra.CurrentRow.Cells["CompraData"].Value.ToString());
                txtValor.Text = dgvCompra.CurrentRow.Cells["CompraTotal"].Value.ToString();
                cbxQuantParcela.Text = dgvCompra.CurrentRow.Cells["CompraNumeroParcela"].Value.ToString();
                cbxStatus.Text = dgvCompra.CurrentRow.Cells["CompraStatus"].Value.ToString();
                cbxFornecedor.SelectedValue = int.Parse(dgvCompra.CurrentRow.Cells["FornecedorCod"].Value.ToString());
                cbxTipoPagamento.Text = dgvCompra.CurrentRow.Cells["TipoPagNome"].Value.ToString();


                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Não tem nenhum compra cadastrada!");
            }
        }

        //botão excluir compra
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Aqui ele executa um diálogo perguntando se o usuário deseja ou não excluir o registro.
                if (MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    /*Caso "sim", é aberto a conexão com o banco e executado o método de excluir. */
                    //Método de excluir sendo chamado.
                    BLLCompra.Excluir(int.Parse(dgvCompra.CurrentRow.Cells[0].Value.ToString()));

                    dgvCompra.DataSource = DALCompra.CarregarGrid();
                }
            }
            catch
            {
                //Caso apresente algum erro. Será retornado esta mensagem.
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local");
            }
        }

        //botão excluir item na lista de compra
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                //Aqui ele executa um diálogo perguntando se o usuário deseja ou não excluir o registro.
                if (MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (btnSalvar.Text == "Salvar")
                    {
                        /*Caso "sim", é aberto a conexão com o banco e executado o método de excluir. */
                        //Método de excluir sendo chamado.
                        Compra.Itens.RemoveAt(dgvProduto.CurrentCell.RowIndex);
                        CarregarGrid();
                    }
                    else
                    {
                        
                        ListaProdutosExcluidos.Add(int.Parse(dgvProduto.CurrentRow.Cells[6].Value.ToString()));
                        ListaItensExcluidos.Add(int.Parse(dgvProduto.CurrentRow.Cells[0].Value.ToString()));
                        //int teste = int.Parse(dgvProduto.CurrentRow.Cells[6].Value.ToString());
                        //BLLProduto.Alterar(int.Parse(dgvProduto.CurrentRow.Cells[6].Value.ToString()));
                        //BLLItensCompra.Excluir(int.Parse(dgvProduto.CurrentRow.Cells[0].Value.ToString()));
                        
                        Compra.Itens.RemoveAt(dgvProduto.CurrentCell.RowIndex);
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

        private void BtnVisParcelas_Click(object sender, EventArgs e)
        {
            frmParcelasCompra parcelas = new frmParcelasCompra(int.Parse(dgvCompra.CurrentRow.Cells["CompraCod"].Value.ToString()));
            parcelas.Show();
        }
    }
}

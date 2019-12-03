using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmFinalizarCompra : Form
    {
        public frmFinalizarCompra()
        {
            InitializeComponent();
        }

        public double ValorParcela { get; set; }
        public MVenda venda = new MVenda();
        public string Resultado { get; set; }

        //metodo de exibição
        public static string Finalizar(int codFun, double valorTotal, List<MItensVenda> Itens)
        {
            var f = new frmFinalizarCompra(); //instanciando o formulario

            //passando os dados
            f.venda.FuncionarioCod = codFun;
            f.venda.VendaTotal = valorTotal;
            f.venda.ClienteCod = 0;
            //passando a lista de itens
            foreach (var item in Itens)
            {
                f.venda.Itens.Add(item);
            }
            //exibindo o formulario
            f.ShowDialog();
            return f.Resultado;
        }

        //Função para preencher o dg_disciplinas com as disciplinas selecionada
        public void PreencherCliente()
        {
            int TotalRows = dgvCliente.RowCount; //Pegando a quantidade de linhas
            for (int i = 0; i < TotalRows; i++) //Pecorrendo o DataGrid marcando o checklist
            {
                if ((int)dgvCliente.Rows[i].Cells[1].Value == venda.ClienteCod) //Analisando se o id do item é igual ao id presente do Datagrid
                {
                    dgvCliente.Rows[i].Cells[0].Value = true; //Marcando o checklist
                }
            }
        }

        //Metodo para calcular o valor da parcela e o valor da taxa por parcela
        public void CalcularParcela()
        {
            //Verificando se foi informado uma taxa
            if (txtTaxa.Text == "")
            {
                ValorParcela = venda.VendaTotal / int.Parse(cbxQuantParcela.Text); //Calculando sem a taxa
                txtTaxaParcela.Text = ""; //Limpando o valor da taxa
            }
            else
            {
                ValorParcela = (venda.VendaTotal / int.Parse(cbxQuantParcela.Text)); //Calculando sem a taxa
                venda.VendaTaxaParcela = ((double.Parse(txtTaxa.Text) / 100) * ValorParcela); //Calculando o valor da taxa
                txtTaxaParcela.Text = venda.VendaTaxaParcela.ToString("C2"); //Exibindo o valor da taxa
                ValorParcela += venda.VendaTaxaParcela; //Calculando a parcela com a taxa       
            }
            txtParcela.Text = ValorParcela.ToString("C2"); //Exibindo o valor da parcela
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Analisando se já foram selecionado as materias
                if ((venda.ClienteCod == 0) || (dgvCliente.CurrentRow.Cells[0].Value != null && (bool)dgvCliente.CurrentRow.Cells[0].Value))
                {
                    //Checando se o checklist foi desmarcado
                    if (dgvCliente.CurrentRow.Cells[0].Value != null && (bool)dgvCliente.CurrentRow.Cells[0].Value)
                    {
                        venda.ClienteCod = 0; //Removendo o id
                        //Definindo como falso o checklist
                        dgvCliente.CurrentRow.Cells[0].Value = false;
                        dgvCliente.CurrentRow.Cells[0].Value = null;
                        cbxQuantParcela.Enabled = false;
                    }
                    else if (dgvCliente.CurrentRow.Cells[0].Value == null) //Checando se o checklist foi selecionado
                    {
                        //Definindo como true o checklist
                        venda.ClienteCod = (int)dgvCliente.CurrentRow.Cells[1].Value;
                        dgvCliente.CurrentRow.Cells[0].Value = true;
                        cbxQuantParcela.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Já foi selecionado o cliente!", "OK");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "OK");
            }
        }

        private void frmFinalizarCompra_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = DALCliente.CarregarGrid(); //Carregando os clientes
            txtTaxa.Enabled = false; //Desativando a taxa
            txtValorTotal.Text = venda.VendaTotal.ToString("C2"); //Passando o valor total
            cbxQuantParcela.SelectedIndex = 0; //Selecionando a quantidade de parcelas

            //Iniciando os dados do combobox Tipo Pagamento
            cbxTipoPagamento.DataSource = DALTipoPagamento.CarregarGrid();
            cbxTipoPagamento.ValueMember = "tipoPag_cod";
            cbxTipoPagamento.DisplayMember = "tipoPag_nome";
            cbxTipoPagamento.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConsultaCliente.Text == "") //Analisando se foi digitado algo, caso não, será recarregado todos os dados da tabela
                {
                    dgvCliente.DataSource = DALCliente.CarregarGrid(); //Carregando todo o DataGrid

                    PreencherCliente(); //Preenchendo as disciplinas
                }
                else //Pesquisando o nome
                {
                    dgvCliente.DataSource = BLLCliente.LocalizarDados(txtConsultaCliente.Text); //Exibindo os clientes da pesquisa

                    PreencherCliente(); //Preenchendo as disciplinas
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cbxTaxa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTaxa.Checked == true) //Analisando de foi selecionado, informando que terá uma taxa
            {
                txtTaxa.Enabled = true; //Ativando a edição da taxa
            }
            else
            {
                txtTaxa.Text = ""; //Limpando 
                CalcularParcela(); //Calculando a Parcela
                txtTaxa.Enabled = false; //Desativando a edição da taxa
            }
        }

        private void cbxQuantParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularParcela(); //Calculando a Parcela
        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) //Verificando se foi um numero
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) //Verificando se foi uma virgula
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }

        private void txtTaxa_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularParcela(); //Calculando a Parcela
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Resultado = "Cancelar";
            Close(); //Fechando
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                //Analisando se todos os campos foram preenchidos
                if (cbxTipoPagamento.Text != "" & cbxStatus.Text != "")
                {

                    /* *****************************************
                     * ***************** Venda *****************
                     * *****************************************/

                    venda.VendaData = DateTime.Now.Date;

                    //Pegando as venda e vendo a quantidade
                    DataTable tabela = DALVenda.CarregarGrid();

                    venda.VendaNotaFiscal = DateTime.Now.Date.ToString("dd/mm/yyyy") + "ADAPT" + tabela.Rows.Count;
                    venda.VendaParcelas = int.Parse(cbxQuantParcela.Text);
                    venda.VendaStatus = cbxStatus.Text;
                    venda.TipoPagamentoCod = (int)cbxTipoPagamento.SelectedValue;
                    //Cadastrando
                    BLLVenda.Incluir(venda);

                    //Pegando o id da compra salva
                    venda.VendaCod = int.Parse(DALVenda.PegarId());


                    /* *****************************************
                     * *************** Prestação ***************
                     * *****************************************/

                    if (venda.VendaParcelas > 1) //Analisando se teve parcelamento
                    {
                        //Criando um variavel para salvar a data da nova prestação
                        DateTime ProximaPrestação = DateTime.Now.Date;
                        //Criando e salvando as parcelas
                        for (int i = 0; i < venda.VendaParcelas; i++)
                        {
                            venda.Parcelas.Add(new MParcelasVenda(ValorParcela, ProximaPrestação.AddMonths(i + 1), venda.VendaCod)); //Instanciando a parcela

                            //Salvando as Parcelas
                            BLLParcelasVenda.Incluir(venda.Parcelas[i]);
                        }
                    }
                    else
                    {
                        //Criando e salvando as parcelas
                        venda.Parcelas.Add(new MParcelasVenda(ValorParcela, DateTime.Now.Date, venda.VendaCod)); //Instanciando a parcela

                        //Salvando as Parcelas
                        BLLParcelasVenda.Incluir(venda.Parcelas[0]);
                    }


                    /* *****************************************
                     * ***************** Itens *****************
                     * *****************************************/

                    foreach (var item in venda.Itens)
                    {
                        item.VendaCod = venda.VendaCod;
                        BLLItensVenda.Incluir(item);
                    }

                    MessageBox.Show("Venda Cadastrada com Sucesso");
                    Resultado = "OK";
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

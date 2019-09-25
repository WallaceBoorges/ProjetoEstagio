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
    public partial class frmCadastroFornecedor : Form
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtRsocial.Clear();
            txtIe.Clear();
            txtCnpj.Clear();
            txtFone.Clear();
            txtCel.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }


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
                LimpaTela();
                //Carregando os dados
                dgvFornecedor.DataSource = DALFornecedor.CarregarGrid();
            }

            if (op == 2) //Atualizar
            {
                btnSalvar.Text = "Atualizar";
                btnSalvar.Enabled = true;
                btnCancelar.Visible = true;
            }
        }

        public void VerificaDigito(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificando se o usuário informou todos os campos obrigatorios
                if (txtNome.Text == "" || txtRsocial.Text == "" || txtIe.Text == "" || txtCnpj.Text == "" || txtFone.Text == ""
                   || txtCel.Text == "" || txtEmail.Text == "" || txtCep.Text == "" || txtEndereco.Text == "" ||
                   txtBairro.Text == "" || txtNumero.Text == "" || txtCidade.Text == "" || txtEstado.Text == "")
                {
                    throw new Exception("Preencha todos os Campos!");
                }

                //Verificando se vai ser atualizado ou cadastrado
                MFornecedor forn = new MFornecedor(txtNome.Text, int.Parse(txtRsocial.Text), int.Parse(txtIe.Text), int.Parse(txtCnpj.Text), int.Parse(txtFone.Text), int.Parse(txtCel.Text), txtEmail.Text);
                MEndereco end = new MEndereco(int.Parse(txtCep.Text), txtEndereco.Text, txtBairro.Text, int.Parse(txtNumero.Text), txtCidade.Text, txtEstado.Text);

                //Verificando se vai ser atualizado ou cadastrado
                if (btnSalvar.Text == "Atualizar")
                {
                    forn.CodigoFornecedor = int.Parse(txtCodigo.Text); //Passando o id para realizar a alteração.
                    end.CodigoEndereco = int.Parse(txtCodigoEndereco.Text);//Passando o id para realizar a alteração.
                    BLLFornecedor.Alterar(forn, end); //Chamando o metodo alterar

                    MessageBox.Show("Alteração realizada com sucesso!");
                }
                else
                {
                    BLLFornecedor.Incluir(forn, end); //Chamando o metodo cadastrar
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

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            Alterarbotoes(1);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFornecedor.DataSource = BLLFornecedor.LocalizarDados(txtConsultaFornecedor.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (dgvFornecedor.RowCount != 0)
            {
                //Pegando os dados diretamente do DataGrid
                txtCodigo.Text = dgvFornecedor.CurrentRow.Cells["fornecedor_cod"].Value.ToString();
                txtNome.Text = dgvFornecedor.CurrentRow.Cells["nome"].Value.ToString();
                txtRsocial.Text = dgvFornecedor.CurrentRow.Cells["rsocial"].Value.ToString();
                txtIe.Text = dgvFornecedor.CurrentRow.Cells["ie"].Value.ToString();
                txtCnpj.Text = dgvFornecedor.CurrentRow.Cells["cnpj"].Value.ToString();
                txtFone.Text = dgvFornecedor.CurrentRow.Cells["fone"].Value.ToString();
                txtCel.Text = dgvFornecedor.CurrentRow.Cells["celular"].Value.ToString();
                txtEmail.Text = dgvFornecedor.CurrentRow.Cells["email"].Value.ToString();
                txtCep.Text = dgvFornecedor.CurrentRow.Cells["cep"].Value.ToString();
                txtCodigoEndereco.Text = dgvFornecedor.CurrentRow.Cells["endereco_cod"].Value.ToString();
                txtEndereco.Text = dgvFornecedor.CurrentRow.Cells["logradouro"].Value.ToString();
                txtBairro.Text = dgvFornecedor.CurrentRow.Cells["bairro"].Value.ToString();
                txtNumero.Text = dgvFornecedor.CurrentRow.Cells["numero"].Value.ToString();
                txtCidade.Text = dgvFornecedor.CurrentRow.Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvFornecedor.CurrentRow.Cells["estado"].Value.ToString();

                //Alterando as informações 
                Alterarbotoes(2);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                //Aqui ele executa um diálogo perguntando se o usuário deseja ou não excluir o registro.
                if (MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    /*Caso "sim", é aberto a conexão com o banco e executado o método de excluir. */
                    //Método de excluir sendo chamado.
                    BLLFornecedor.Excluir(int.Parse(dgvFornecedor.CurrentRow.Cells[0].Value.ToString()));
                    LimpaTela();
                }
            }
            catch
            {
                //Caso apresente algum erro. Será retornado esta mensagem.
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local");
            }
            Alterarbotoes(1);


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Alterarbotoes(1);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();

        }

        private void txtRsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);

        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);

        }

        private void txtIe_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);

        }

        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);

        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificaDigito(sender, e);

        }
    }
}

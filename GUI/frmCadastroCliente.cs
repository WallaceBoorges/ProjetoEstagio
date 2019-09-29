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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtTipo.Clear();
            txtRg.Clear();
            txtRsocial.Clear();
            txtCpf.Clear();
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
                dgvCliente.DataSource = DALCliente.CarregarGrid();
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
                if (txtNome.Text == "" || txtTipo.Text == "" || txtRg.Text == "" || txtCpf.Text == "" || txtRsocial.Text == "" || txtFone.Text == ""
                   || txtCel.Text == "" || txtEmail.Text == "" || txtCep.Text == "" || txtEndereco.Text == "" ||
                   txtBairro.Text == "" || txtNumero.Text == "" || txtCidade.Text == "" || txtEstado.Text == "")
                {
                    throw new Exception("Preencha todos os Campos!");
                }

                //Verificando se vai ser atualizado ou cadastrado
                MCliente forn = new MCliente(txtNome.Text, txtTipo.Text, txtRg.Text, txtCpf.Text, txtRsocial.Text, int.Parse(txtFone.Text), int.Parse(txtCel.Text), txtEmail.Text);
                MEndereco end = new MEndereco(int.Parse(txtCep.Text), txtEndereco.Text, txtBairro.Text, int.Parse(txtNumero.Text), txtCidade.Text, txtEstado.Text);

                //Verificando se vai ser atualizado ou cadastrado
                if (btnSalvar.Text == "Atualizar")
                {
                    forn.CodigoCliente = int.Parse(txtCodigo.Text); //Passando o id para realizar a alteração.
                    end.CodigoEndereco = int.Parse(txtCodigoEndereco.Text);//Passando o id para realizar a alteração.
                    BLLCliente.Alterar(forn, end); //Chamando o metodo alterar

                    MessageBox.Show("Alteração realizada com sucesso!");
                }
                else
                {
                    BLLCliente.Incluir(forn, end); //Chamando o metodo cadastrar
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Alterarbotoes(1);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

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

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = DALCliente.CarregarGrid();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvCliente.DataSource = BLLCliente.LocalizarDados(txtConsultaCliente.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (dgvCliente.RowCount != 0)
            {
                //Pegando os dados diretamente do DataGrid
                txtCodigo.Text = dgvCliente.CurrentRow.Cells["cliente_cod"].Value.ToString();
                txtNome.Text = dgvCliente.CurrentRow.Cells["nome"].Value.ToString();
                txtTipo.Text = dgvCliente.CurrentRow.Cells["tipo"].Value.ToString();
                txtRg.Text = dgvCliente.CurrentRow.Cells["rg"].Value.ToString();
                txtCpf.Text = dgvCliente.CurrentRow.Cells["cpf"].Value.ToString();
                txtRsocial.Text = dgvCliente.CurrentRow.Cells["rsocial"].Value.ToString();
                txtFone.Text = dgvCliente.CurrentRow.Cells["fone"].Value.ToString();
                txtCel.Text = dgvCliente.CurrentRow.Cells["celular"].Value.ToString();
                txtEmail.Text = dgvCliente.CurrentRow.Cells["email"].Value.ToString();
                txtCep.Text = dgvCliente.CurrentRow.Cells["cep"].Value.ToString();
                txtCodigoEndereco.Text = dgvCliente.CurrentRow.Cells["endereco_cod"].Value.ToString();
                txtEndereco.Text = dgvCliente.CurrentRow.Cells["logradouro"].Value.ToString();
                txtBairro.Text = dgvCliente.CurrentRow.Cells["bairro"].Value.ToString();
                txtNumero.Text = dgvCliente.CurrentRow.Cells["numero"].Value.ToString();
                txtCidade.Text = dgvCliente.CurrentRow.Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvCliente.CurrentRow.Cells["estado"].Value.ToString();

                //Alterando as informações 
                Alterarbotoes(2);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

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
                    BLLCliente.Excluir(int.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString()));
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

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Alterarbotoes(1);
        }
    }
}
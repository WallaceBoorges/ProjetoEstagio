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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtNome.Clear();
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            cbxSexo.SelectedIndex = -1;
            cbxEstadoCivil.SelectedIndex = -1;
            txtCelular.Clear();
            cbxFunção.SelectedIndex = -1;
            txtSalarioBase.Clear();
            txtBancoNome.Clear();
            txtBancoAgencia.Clear();
            txtBancoConta.Clear();
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
                dgvFuncionario.DataSource = DALFuncionario.CarregarGrid();
            }

            if (op == 2) //Atualizar
            {
                btnSalvar.Text = "Atualizar";
                btnSalvar.Enabled = true;
                btnCancelar.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificando se o usuário informou todos os campos obrigatorios
                if (txtNome.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "" || txtCpf.Text == "" || txtRg.Text == ""
                   || cbxSexo.Text == "" || cbxEstadoCivil.Text == "" || txtCelular.Text == "" || cbxFunção.Text == "" ||
                   txtSalarioBase.Text == "" || txtBancoNome.Text == "" || txtBancoAgencia.Text == "" || txtBancoConta.Text == "" || txtCep.Text == "" || txtEndereco.Text == "" ||
                   txtBairro.Text == "" || txtNumero.Text == "" || txtCidade.Text == "" || txtEstado.Text == "")
                {
                    throw new Exception("Preencha todos os Campos!");
                }
                else
                {
                    //Verificando se vai ser atualizado ou cadastrado
                    MFuncionario forn = new MFuncionario(txtNome.Text, txtUsuario.Text, txtSenha.Text, txtCpf.Text, txtRg.Text, dtpDataNacimento.Value.Date, cbxSexo.Text, cbxEstadoCivil.Text, txtCelular.Text, cbxFunção.Text, dtpDataAdimissao.Value.Date, Double.Parse(txtSalarioBase.Text), txtBancoNome.Text, txtBancoAgencia.Text, txtBancoConta.Text);
                    MEndereco end = new MEndereco(int.Parse(txtCep.Text), txtEndereco.Text, txtBairro.Text, int.Parse(txtNumero.Text), txtCidade.Text, txtEstado.Text);

                    //Verificando se vai ser atualizado ou cadastrado
                    if (btnSalvar.Text == "Atualizar")
                    {
                        forn.CodigoFuncionario = int.Parse(txtCodigo.Text); //Passando o id para realizar a alteração.
                        end.CodigoEndereco = int.Parse(txtCodigoEndereco.Text);//Passando o id para realizar a alteração.
                        BLLFuncionario.Alterar(forn, end); //Chamando o metodo alterar

                        MessageBox.Show("Alteração realizada com sucesso!");
                    }
                    else
                    {
                        BLLFuncionario.Incluir(forn, end); //Chamando o metodo cadastrar
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    //Padrão
                    Alterarbotoes(1);
                }                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Alterarbotoes(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFuncionario.DataSource = BLLFuncionario.LocalizarDados(txtConsultaFuncionario.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.RowCount != 0)
            {
                //Pegando os dados diretamente do DataGrid
                txtCodigo.Text = dgvFuncionario.CurrentRow.Cells["cod"].Value.ToString();
                txtNome.Text = dgvFuncionario.CurrentRow.Cells["nome"].Value.ToString();
                txtUsuario.Text = dgvFuncionario.CurrentRow.Cells["usuario"].Value.ToString();
                txtSenha.Text = dgvFuncionario.CurrentRow.Cells["senha"].Value.ToString();
                txtCpf.Text = dgvFuncionario.CurrentRow.Cells["cpf"].Value.ToString();
                txtRg.Text = dgvFuncionario.CurrentRow.Cells["rg"].Value.ToString();
                dtpDataNacimento.Text = dgvFuncionario.CurrentRow.Cells["datanascimento"].Value.ToString();
                cbxSexo.Text = dgvFuncionario.CurrentRow.Cells["sexo"].Value.ToString();
                cbxEstadoCivil.Text = dgvFuncionario.CurrentRow.Cells["estadocivil"].Value.ToString();
                txtCelular.Text = dgvFuncionario.CurrentRow.Cells["celular"].Value.ToString();
                cbxFunção.Text = dgvFuncionario.CurrentRow.Cells["funcaoexercida"].Value.ToString();
                dtpDataAdimissao.Text = dgvFuncionario.CurrentRow.Cells["admissao"].Value.ToString();
                txtSalarioBase.Text = dgvFuncionario.CurrentRow.Cells["salariobase"].Value.ToString();
                txtBancoNome.Text = dgvFuncionario.CurrentRow.Cells["banconome"].Value.ToString();
                txtBancoAgencia.Text = dgvFuncionario.CurrentRow.Cells["bancoagencia"].Value.ToString();
                txtBancoConta.Text = dgvFuncionario.CurrentRow.Cells["bancoconta"].Value.ToString();
                txtCep.Text = dgvFuncionario.CurrentRow.Cells["endereco_cep"].Value.ToString();
                txtCodigoEndereco.Text = dgvFuncionario.CurrentRow.Cells["endereco_cod"].Value.ToString();
                txtEndereco.Text = dgvFuncionario.CurrentRow.Cells["endereco_logradouro"].Value.ToString();
                txtBairro.Text = dgvFuncionario.CurrentRow.Cells["endereco_bairro"].Value.ToString();
                txtNumero.Text = dgvFuncionario.CurrentRow.Cells["endereco_numero"].Value.ToString();
                txtCidade.Text = dgvFuncionario.CurrentRow.Cells["endereco_cidade"].Value.ToString();
                txtEstado.Text = dgvFuncionario.CurrentRow.Cells["endereco_estado"].Value.ToString();

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
                    BLLFuncionario.Excluir(int.Parse(dgvFuncionario.CurrentRow.Cells[0].Value.ToString()));
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

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            Alterarbotoes(1);
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDemissao_Click(object sender, EventArgs e)
        {

        }
    }
}

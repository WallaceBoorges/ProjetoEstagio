using BLL;
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
    public partial class frmUnidadeMedida : Form
    {
        public frmUnidadeMedida()
        {
            InitializeComponent();
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
                //Carregando os dados
                dgvUniMedida.DataSource = BLLUnidadeMedida.CarregarGrid();
            }

            if (op == 2) //Atualizar
            {
                btnSalvar.Text = "Atualizar";
                btnSalvar.Enabled = true;
                btnCancelar.Visible = true;
            }
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            Alterarbotoes(1);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvUniMedida.RowCount != 0)
            {
                //Pegando os dados diretamente do DataGrid
                txtCodigo.Text = dgvUniMedida.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvUniMedida.CurrentRow.Cells[1].Value.ToString();
                //Alterando as informações 
                Alterarbotoes(2);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                /*Aqui eu chamei a classe MCategoria que está na camada Modelo. Caso eu não chamasse ela aqui, eu não iria conseguir acessar
               os atributos da classe. A classe está sendo instanciada pela varíavel modelo, que está guardando todos os atributos da 
               classe.*/
                MUnidadeMedida modelo = new MUnidadeMedida(txtNome.Text);

                //Analisando se o usuário deseja atualizar ou salvar um novo registro
                if (btnSalvar.Text != "Atualizar")
                {
                    BLLUnidadeMedida.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    modelo.codigoUniMedida = Convert.ToInt32(txtCodigo.Text); //Pegando o ID
                    BLLUnidadeMedida.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                LimpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
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
                    BLLUnidadeMedida.Excluir(int.Parse(dgvUniMedida.CurrentRow.Cells[0].Value.ToString()));
                    LimpaTela();
                }
            }
            catch
            {
                //Caso apresente algum erro. Será retornado esta mensagem.
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local");
                Alterarbotoes(1);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUniMedida.DataSource = BLLUnidadeMedida.LocalizarDados(txtConsultaUniMedida.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void frmUnidadeMedida_Load(object sender, EventArgs e)
        {
            Alterarbotoes(1);
        }
    }
}
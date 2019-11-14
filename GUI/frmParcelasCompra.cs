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
    public partial class frmParcelasCompra : Form
    {
        private int compraCodigo;

        public frmParcelasCompra(int codigo)
        {
            InitializeComponent();
            compraCodigo = codigo;
        }

        private void AlterarBtn()
        {
            if (dgvParcelasCompra.CurrentRow.Cells[3].Value.ToString() == "" || dgvParcelasCompra.CurrentRow.Cells[3].Value.ToString() == null)
            {
                btn_confPag.Text = "Confirmar pagamento";
            }
            else
            {
                btn_confPag.Text = "Mudar data de pagamento";
            }
        }

        private void FrmParcelasCompra_Load(object sender, EventArgs e)
        {
            dgvParcelasCompra.DataSource = DALParcelasCompra.CarregarGrid(compraCodigo);
            AlterarBtn();
        }

        private void Btn_confPag_Click(object sender, EventArgs e)
        {
            if (dt_selector.Value.Date > System.DateTime.Today)
            {
                MessageBox.Show("Não é possivel selecionar uma data a frente da atual. A data foi alterada para hoje." + DateTime.Today.Date.ToShortDateString());
                dt_selector.Value = System.DateTime.Today;
            }
            try
            {
                //Aqui ele executa um diálogo perguntando se o usuário deseja ou não confirmar o pagamento.
                if (MessageBox.Show("Confirmar pagamento na ata selecionada?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    /*Caso "sim", é aberto a conexão com o banco e executado o método para confirmar o pagamento. */
                    //Método de confirmar pagamento sendo chamado.
                    BLLParcelasCompras.ConfPag(dt_selector.Value.Year.ToString()+"-"+ dt_selector.Value.Month.ToString()+"-"+ dt_selector.Value.Day.ToString(), int.Parse(dgvParcelasCompra.CurrentRow.Cells[0].Value.ToString()));

                    dgvParcelasCompra.DataSource = DALParcelasCompra.CarregarGrid(compraCodigo);
                }
            }
            catch
            {
                //Caso apresente algum erro. Será retornado esta mensagem.
                MessageBox.Show("Impossível executar esta ação no momento.");
            }
        }

        private void DgvParcelasCompra_SelectionChanged(object sender, EventArgs e)
        {
            AlterarBtn();
        }

        private void DgvParcelasCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarBtn();
        }
    }
}

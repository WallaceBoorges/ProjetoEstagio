using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmVendaDetalhada : Form
    {
        private int codigo_venda;

        public frmVendaDetalhada(int codg)
        {
            InitializeComponent();
            codigo_venda = codg;
        }

        private void FrmVendaDetalhada_Load(object sender, EventArgs e)
        {
            dgv_parcelas.DataSource = DALVendaDetalhada.CarregarParcelas(codigo_venda);
            dgv_itens.DataSource = DALVendaDetalhada.CarregarItens(codigo_venda);
            String[] dados = new String[8];
            dados = DALVendaDetalhada.CarregarCampos(codigo_venda);
            txt_cliente.Text = dados[5];
            txt_funcionario.Text = dados[7];
            txt_data.Text = dados[0];
            txt_nota.Text = dados[1];
            txt_status.Text = dados[4];
            txt_taxa.Text = dados[3];
            txt_valor.Text = dados[2];
            txt_tipoPag.Text = dados[6];
        }
    }
}

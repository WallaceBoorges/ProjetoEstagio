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
        }
    }
}

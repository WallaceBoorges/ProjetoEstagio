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



        private void FrmParcelasCompra_Load(object sender, EventArgs e)
        {
            dgvParcelasCompra.DataSource = DALParcelasCompra.CarregarGrid(compraCodigo);

        }
    }
}

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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Chamando o formulario categoria
        private void categoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }
        //Chamando o formulario subcategoria
        private void subCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.Alterarbotoes(0);
            f.ShowDialog();
            f.Dispose();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCompra f = new frmCadastrarCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();

        }

        private void conexãoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConexaoBD f = new frmConexaoBD();
            f.ShowDialog();
            f.Dispose();
        }
    }
}

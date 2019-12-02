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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //dgvVendas.DataSource = DALVenda.CustomLoad(1, dtp_Venda.Value.Year.ToString() + "-" + dtp_Venda.Value.Month.ToString() + "-" + dtp_Venda.Value.Day.ToString());
            dgvVendas.DataSource = DALVenda.CarregarGrid();
            cb_data.Checked = true;
            txt_busca.Enabled = false;
        }

        private void Cb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cliente.Checked)
            {
                cb_funcionario.Checked = false;
                cb_tudo.Checked = false;
                cb_data.Checked = false;
                if (!txt_busca.Enabled && !btn_buscar.Enabled)
                {
                    txt_busca.Enabled = true;
                }
            } else
            {
                if (!cb_funcionario.Checked)
                {
                    txt_busca.Enabled = false;
                }
            }
        }

        private void Cb_funcionario_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_funcionario.Checked)
            {
                cb_cliente.Checked = false;
                cb_tudo.Checked = false;
                cb_data.Checked = false;
                if (!txt_busca.Enabled && !btn_buscar.Enabled)
                {
                    txt_busca.Enabled = true;
                    btn_buscar.Enabled = true;
                }
            }
            else
            {
                if (!cb_cliente.Checked)
                {
                    txt_busca.Enabled = false;
                    btn_buscar.Enabled = false;
                }
            }
        }

        private void Cb_data_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_data.Checked)
            {
                cb_cliente.Checked = false;
                cb_funcionario.Checked = false;
                cb_tudo.Checked = false;
                if (!dtp_Venda.Enabled)
                {
                    dtp_Venda.Enabled = true;
                }
            }
            else
            {
                if (!cb_data.Checked)
                {
                    dtp_Venda.Enabled = false;
                }
            }
        }

        private void Cb_tudo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tudo.Checked)
            {
                cb_funcionario.Checked = false;
                cb_cliente.Checked = false;
                cb_data.Checked = false;
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

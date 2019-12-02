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
            cb_fun.Enabled = false;

            //iniciando o combobox de funcionário
            cb_fun.DataSource = DALFuncionario.CarregarGrid();
            cb_fun.ValueMember = "fun_cod";
            cb_fun.DisplayMember = "fun_nome";
            cb_fun.SelectedIndex = -1;
        }

        private void Cb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cliente.Checked)
            {
                cb_funcionario.Checked = false;
                cb_tudo.Checked = false;
                cb_data.Checked = false;
                if (!txt_busca.Enabled)
                {
                    txt_busca.Enabled = true;
                }
            } else
            {
                txt_busca.Enabled = false;
            }
        }

        private void Cb_funcionario_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_funcionario.Checked)
            {
                cb_cliente.Checked = false;
                cb_tudo.Checked = false;
                cb_data.Checked = false;
                if (!cb_fun.Enabled)
                {
                    cb_fun.Enabled = true;
                }
            }
            else
            {
                cb_fun.Enabled = false;
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
                dtp_Venda.Enabled = false;
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


        private void Button1_Click(object sender, EventArgs e)
        {
            frmVendaDetalhada vd = new frmVendaDetalhada(int.Parse(dgvVendas.CurrentRow.Cells["venda_cod"].Value.ToString()));
            vd.Show();
        }

        private void Btn_aplicar_Click(object sender, EventArgs e)
        {
            if (cb_data.Checked)
            {
                dgvVendas.DataSource = DALVenda.Filtrar(1, dtp_Venda.Value.Year.ToString() + "-" + dtp_Venda.Value.Month.ToString() + "-" + dtp_Venda.Value.Day.ToString());
            }
            else if (cb_cliente.Checked)
            {
                dgvVendas.DataSource = DALVenda.Filtrar(2, txt_busca.Text);
            }
            else if (cb_funcionario.Checked)
            {
                dgvVendas.DataSource = DALVenda.Filtrar(3, cb_fun.Text);
            }
            else
            {
                dgvVendas.DataSource = DALVenda.CarregarGrid();
            }
        }
    }
}

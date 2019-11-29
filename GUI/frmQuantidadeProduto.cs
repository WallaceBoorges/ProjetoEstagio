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
    public partial class frmQuantidadeProduto : Form
    {
        public frmQuantidadeProduto()
        {
            InitializeComponent();
        }

        public double Resultado { get; private set; } //Criando um atributo para armazenar o resultado
        public double QuantDisponivel { get; set; }

        //Metodo Mostrar SIM ou Não
        public static double AddQuantidade(string nomeProduto, double totalDisponivel)
        {
            //Criando o obj do tipo MeuMsgBox e configurando a sua exibição
            var quant = new frmQuantidadeProduto();

            quant.Resultado = 0.0;
            quant.QuantDisponivel = totalDisponivel;
            quant.lblProduto.Text = nomeProduto;

            //Chamando o formulario
            quant.ShowDialog();
            return quant.Resultado;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantidadeProduto.Text != "")
            {
                if (double.Parse(txtQuantidadeProduto.Text) <= QuantDisponivel) //Verificando se o valor digitado não excede a quantidade disponivel
                {
                    Resultado = double.Parse(txtQuantidadeProduto.Text); //Pegando a quantidade
                    Close();
                }
                else
                {
                    MessageBox.Show("Quantidade Excedeu o valor disponivel que é: " + QuantDisponivel, "OK");
                }
            }
            else
            {
                MessageBox.Show("Preencha a  Quantidade!", "OK");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Resultado = 0.0; //Passando a quantidade 0, e isso indica que não foi informado uma quantidade
            Close();
        }

        private void txtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }
    }
}

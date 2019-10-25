using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmConexaoBD : Form
    {
        public frmConexaoBD()
        {
            InitializeComponent();
        }

        public string Resultado { get; private set; } //Criando um atributo para armazenar o resultado

        //Metodo Mostrar SIM ou Não
        public static string PegarDadosBanco()
        {
            //Criando o obj do tipo MeuMsgBox e configurando a sua exibição
            var dadosBanco = new frmConexaoBD();

            dadosBanco.btnVoltar.Text = "Fechar";
            dadosBanco.btnTestarConexao.Visible = false;
            
            //Chamando o formulario
            dadosBanco.ShowDialog();
            return dadosBanco.Resultado;
        }

        //Evento Load
        private void frmConexaoBD_Load(object sender, EventArgs e)
        {
            //Abrindo o arquivo com as configurações da conexão ao banco
            try
            {
                if (System.IO.File.Exists("Configuração Banco.txt")) //Analisando se o arquivo existe
                {
                    using (StreamReader ConfBanco = new StreamReader("Configuração Banco.txt")) //Pegando os dados
                    {
                        cbxTipoConexao.Text = ConfBanco.ReadLine();
                        txtServidor.Text = ConfBanco.ReadLine();
                        txtBanco.Text = ConfBanco.ReadLine();

                        if (cbxTipoConexao.Text == "Remota") //Analisando o tipo de conexão
                        {
                            txtSenha.Text = ConfBanco.ReadLine();
                            txtUsuario.Text = ConfBanco.ReadLine();
                        }
                        else
                        {
                            txtSenha.Enabled = false;
                            txtUsuario.Enabled = false;
                        }
                    }
                }
            }
            catch (IOException ex) //Erro com a manipulção do arquivo
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTipoConexao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxTipoConexao.Text == "Remota") //Se for selecionado o tipo de conexão "REMOTA" será ativado as opcões de adicionar usuário e senha
            {
                txtSenha.Enabled = true;
                txtUsuario.Enabled = true;
            }
            else //Caso não será desativado e limpada a opção de adcionar usuário e senha
            {
                txtSenha.Enabled = false;
                txtSenha.Text = "";
                txtUsuario.Enabled = false;
                txtUsuario.Text = "";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Analisando se todos os campos foram preenchidos
            if (((cbxTipoConexao.Text == "Local") && (txtServidor.Text != "") && (txtBanco.Text != "")) || ((cbxTipoConexao.Text == "Remota") && (txtServidor.Text != "") && (txtBanco.Text != "") && (txtSenha.Text != "") && (txtUsuario.Text != "")))
            {
                //Criando arquivo para salvar as configurações da conexão ao banco
                try
                {
                    using (StreamWriter ConfBanco = new StreamWriter("Configuração Banco.txt", false)) //Abrindo arquivo
                    {   //Salvando os dados de conexao no arquivo
                        ConfBanco.WriteLine(cbxTipoConexao.Text);
                        ConfBanco.WriteLine(txtServidor.Text);
                        ConfBanco.WriteLine(txtBanco.Text);
                        ConfBanco.WriteLine(txtSenha.Text);
                        ConfBanco.WriteLine(txtUsuario.Text);
                    }
                    MessageBox.Show("Configurações Salvas com Sucesso!!", "OK");
                }
                catch (IOException ex) //Erro relacionado ao arquivo 
                {
                    MessageBox.Show("Erro: " + ex.Message, "Ok");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "OK");
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Configuração Banco.txt")) //Analisando se o arquivo existe
            {
                try
                {
                    ConexaoBD.TesteConexao(); //Testando a conexão
                    MessageBox.Show("Banco Conectado com Suesso!!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
            else
            {
                MessageBox.Show("Primeiramente salve os dados de conexão", "OK");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

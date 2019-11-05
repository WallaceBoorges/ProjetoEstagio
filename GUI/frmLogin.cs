using System;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string Resultado { get; private set; } //Criando um atributo para armazenar o resultado

        //Metodo Mostrar SIM ou Não
        public static string Login()
        {
            //Criando o obj do tipo MeuMsgBox e configurando a sua exibição
            var login = new frmLogin();

            login.Resultado = "0";

            //Chamando o formulario
            login.ShowDialog();
            return login.Resultado;
        }


        //Evento click do botão acessar
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //Analisando se foi informado todos os campos
            if(txtUsuario.Text != "" && txtSenha.Text != "")
            {
                var tabela = DALFuncionario.CarregarGrid(); //Pegando o dados dos funcionarios

                //Pecorrendo os dados da tabela
                for(int i = 0; i < tabela.Rows.Count; i++)
                {
                    //Analisando se o nick corresponde ao da linha atual 
                    if (tabela.Rows[i]["fun_usuario"].ToString() == txtUsuario.Text)
                    {
                        //Analisando se o usuário não já foi demitido, caso seja não pode acessar o sistema
                        if (tabela.Rows[i]["fun_demissao"].ToString() == "")
                        {
                            //Analisando se a senha informada é correta
                            if (tabela.Rows[i]["fun_senha"].ToString() == txtSenha.Text)
                            {
                                Resultado = tabela.Rows[i]["fun_cod"].ToString(); //Passando o resultado
                                Close(); //Fechando o formulario
                                break; //Parando o laço
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta", "OK"); //Informando que a senha informada está incorreta
                                break; //Parando o laço
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário informado já foi demitido no dia: " + DateTime.Parse(tabela.Rows[i]["fun_demissao"].ToString()).ToShortDateString(), "OK"); //Informando a data em que o usuário foi demitido
                            break; //Parando o laço
                        }
                    }   
                    else if(tabela.Rows.Count == i+1)
                    {
                        MessageBox.Show("Usuário não encontrado!", "OK"); //Informando que o usuário é incorreto
                        break; //Parando o laço
                    }
                }                
            }
            else
            {
                MessageBox.Show("Preencha todos os dados!", "OK"); //Informando que deve ser informado todos os dados
            }
                                   
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Resultado = "Fechar";
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int x = 1; //Variavdel para permanecer no while

            while (x == 1)
            {
                try
                {
                    ConexaoBD conexao = new ConexaoBD(); //Instanciando um objeto para pegar as configuração de conexão

                    conexao.RestaurarDBPadraoCasoNaoExista(); //Restaurando (caso não exista) e testando a conexão com banco

                    string cod = frmLogin.Login(); //Chamando a tela login

                    if ((cod != "0") & (cod != "Fechar")) //Analisando se o usuário existe e se não foi solicitado o fechamento do login
                    {
                        frmPrincipal f = new frmPrincipal(); //Instanciando um objeto do formulario principal

                        f.txtCod.Text = cod; //Passando o codigo do usuário para o formulario

                        Application.Run(f); //Executando o formulario

                        x = 2; //Mudando o valor de X para quando o usuário fechar o formulario principal
                    }
                    else if (cod == "Fechar")
                    {
                        x = 2;
                    }

                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    frmConexaoBD f = new frmConexaoBD();
                    f.ShowDialog();
                    f.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    frmConexaoBD f = new frmConexaoBD();
                    f.ShowDialog();
                    f.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    x = 2; //Mudando o valor de X para quando ocorrer um erro de restauração
                }
            }
            
        }
    }
}

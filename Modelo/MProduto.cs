using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MProduto
    {
        public int produto_cod { get; set; }
        public String produto_nome { get; set; }
        public String produto_descricao { get; set; }
        public Double produto_valorPago { get; set; }
        public Double produto_valorVenda { get; set; }
        public byte[] produto_foto { get; set; }  
        public float produto_qtde { get; set; }
        public int uniMedida_cod { get; set; }
        public int categoria_cod { get; set; }
        public int subCategoria_cod { get; set; }

        public MProduto()
        {
            this.produto_cod = 0;
            this.produto_nome = "";
            this.produto_descricao = "";
            this.produto_valorPago = 0;
            this.produto_valorVenda = 0;
            this.produto_qtde = 0;
            this.uniMedida_cod = 0;
            this.categoria_cod = 0;
            this.subCategoria_cod = 0;
        }

        /*Esse construtor foi criado para poder indicar onde está a foto do produto
         e poder carregar dentro do vetor
         Aqui a foto recebe uma String*/
        public MProduto(int ProCod, String ProNome, String ProDesc, String ProFoto,
            Double ProValorPag, Double ProValorVd, float ProQtde, int undMedidaCod,
            int CatCod, int subCatCod)
        {
            this.produto_cod = ProCod;
            this.produto_nome = ProNome;
            this.produto_descricao = ProDesc;
            //proprieda da foto.
            this.CarregaImagem(ProFoto);
            this.produto_valorPago = ProValorPag;
            this.produto_valorVenda = ProValorVd;
            this.produto_qtde = ProQtde;
            this.uniMedida_cod = undMedidaCod;
            this.categoria_cod = CatCod;
            this.subCategoria_cod = subCatCod;
        }
        /* E esse construtor foi criado para poder receber o vetor pronto, que representa a foto
         * e poder passar a informação dentro do vetor produto_foto.
        Aqui a foto recebe um vetor Byte[]*/
        public MProduto(int ProCod, String ProNome, String ProDesc, Byte[] ProFoto, 
            Double ProValorPag, Double ProValorVd, float ProQtde, int undMedidaCod, 
            int CatCod, int subCatCod)
        {
            this.produto_cod = ProCod;
            this.produto_nome = ProNome;
            this.produto_descricao = ProDesc;
            this.produto_foto = ProFoto;
            this.produto_valorPago = ProValorPag;
            this.produto_valorVenda = ProValorVd;
            this.produto_qtde = ProQtde;
            this.uniMedida_cod = undMedidaCod;
            this.categoria_cod = CatCod;
            this.subCategoria_cod = subCatCod;
        }


        //Método para carregar imagem, dentro do sistema, na tela de produto.
        public void CarregaImagem (String imagem)
        {
            try
            {
                /*se a string imagem estiver vazia ou nula, ele executa o return e sai
                 * do método CarregaImagem. Caso contrário, executa os comandos abaixo */
                if (string.IsNullOrEmpty(imagem))
                    return;
                /*FileInfo serve para criar, copiar, excluir, mover e abrir arquivos.
                 Ajuda também na criação de objetos FileStream.
                 */
                FileInfo arqImagem = new FileInfo(imagem);
                /*Aqui é onde a imagem está sendo representada, de maneira bruta, na memória
                 do computador. Ou seja, o arquivo está sendo passado em dados brutos,
                 isso significa que está passando apenas bytes. Ele ainda não sabe que tipo
                 de aqruivo está sendo processado.*/
                FileStream fs = new FileStream(imagem, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Aqui eu aloco os bytes dentro de um vetor para poder representar a imagem
                this.produto_foto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Aqui é feita a leitura dos dados brutos e armazena na proprieda produto_foto
                int ReadByte = fs.Read(this.produto_foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}

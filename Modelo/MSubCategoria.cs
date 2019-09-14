using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MSubCategoria
    {
        public int subCategoria_cod { get; set; }
        public String subCategoria_nome { get; set; }
        /*CodigoCategoria foi criado nesta classe SubCategoria por conta do relacionamento entre elas. Na tabela, Codigo Categoria é
         chave estrangeira em subcategoria.*/
        public int categoria_cod { get; set; }


        /*Esse é o construtor da classe. Ele deve ser criado sempre que um objeto é instanciado.
         Mesmo se eu não tivesse criado, o programa iria criar automaticamente. Eu criei apenas para iniciar as propriedades da classe.
         No caso elas irão iniciar recebendo um valor. */
        public MSubCategoria()
        {
            this.categoria_cod = 0;
            this.subCategoria_cod = 0;
            this.subCategoria_nome = "";
        }
        /*Esse segundo construtor foi criado para passar uma informação para o objeto quando ele for criado. As informações 
         são as que estão dentro dos parâmetros.*/
        public MSubCategoria(int subCatCod, String subCatNome, int CatCod)
        {
            this.categoria_cod = subCatCod;
            this.subCategoria_nome = subCatNome;
            this.subCategoria_cod = CatCod;
        }

        public MSubCategoria(string subCategoriaNome, int codigoCategoria)
        {
            this.subCategoria_nome = subCategoriaNome;
            categoria_cod = codigoCategoria;
        }
    }
}
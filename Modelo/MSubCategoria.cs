using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MSubCategoria
    {
        public int SubCategoriaCod { get; set; }
        public String SubCategoriaNome { get; set; }
        /*CodigoCategoria foi criado nesta classe SubCategoria por conta do relacionamento entre elas. Na tabela, Codigo Categoria é
         chave estrangeira em subcategoria.*/
        public int CategoriaCod { get; set; }


        /*Esse é o construtor da classe. Ele deve ser criado sempre que um objeto é instanciado.
         Mesmo se eu não tivesse criado, o programa iria criar automaticamente. Eu criei apenas para iniciar as propriedades da classe.
         No caso elas irão iniciar recebendo um valor. */
        public MSubCategoria()
        {
            CategoriaCod = 0;
            SubCategoriaCod = 0;
            SubCategoriaNome = "";
        }
        /*Esse segundo construtor foi criado para passar uma informação para o objeto quando ele for criado. As informações 
         são as que estão dentro dos parâmetros.*/
        public MSubCategoria(int subCatCod, String subCatNome, int CatCod)
        {
            CategoriaCod = CatCod;
            SubCategoriaNome = subCatNome;
            SubCategoriaCod = subCatCod;
        }

        public MSubCategoria(string subCategoriaNome, int codigoCategoria)
        {
            SubCategoriaNome = subCategoriaNome;
            CategoriaCod = codigoCategoria;
        }
    }
}
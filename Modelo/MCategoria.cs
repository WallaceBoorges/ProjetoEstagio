using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MCategoria
    {
        public int categoria_cod  { get; set; }
        public String categoria_nome { get; set; }

        /*Esse é o construtor da classe. Ele deve ser criado sempre que um objeto é instanciado.
         Mesmo se eu não tivesse criado, o programa iria criar automaticamente. Eu criei apenas para iniciar as propriedades.*/
        public MCategoria()
        {
            this.categoria_cod = 0;
            this.categoria_nome = "";
        }
        /*Esse segundo construtor foi criado para passar uma informação para o objeto quando ele for criado. As informações 
         são as que estão dentro dos parâmetros.*/
        public MCategoria(int CatCod, String CatNome)
        {
            this.categoria_cod = CatCod;
            this.categoria_nome = CatNome;
        }

        public MCategoria(string nomeCategoria)
        {
            categoria_nome = nomeCategoria;
        }
    }
}
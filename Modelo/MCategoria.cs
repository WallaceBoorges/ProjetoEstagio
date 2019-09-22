using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MCategoria
    {
        public int categoriaCod  { get; set; }
        public String categoriNome { get; set; }

        /*Esse é o construtor da classe. Ele deve ser criado sempre que um objeto é instanciado.
         Mesmo se eu não tivesse criado, o programa iria criar automaticamente. Eu criei apenas para iniciar as propriedades.*/
        public MCategoria()
        {
            this.categoriaCod = 0;
            this.categoriNome = "";
        }
        /*Esse segundo construtor foi criado para passar uma informação para o objeto quando ele for criado. As informações 
         são as que estão dentro dos parâmetros.*/
        public MCategoria(int CatCod, String CatNome)
        {
            this.categoriaCod = CatCod;
            this.categoriNome = CatNome;
        }

        public MCategoria(string nomeCategoria)
        {
            categoriNome = nomeCategoria;
        }
    }
}
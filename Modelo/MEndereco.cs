using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MEndereco
    {
        public int CodigoEndereco { get; set; }
        public int CepEndereco { get; set; }
        public String LogradouroEndereco { get; set; }
        public String BairroEndereco { get; set; }
        public int NumeroEndereco { get; set; }
        public String CidadeEndereco { get; set; }
        public String EstadoEndereco { get; set; }

        public MEndereco()
        {
            this.CodigoEndereco = 0;
            this.CepEndereco = 0;
            this.LogradouroEndereco = "";
            this.BairroEndereco = "";
            this.NumeroEndereco = 0;
            this.CidadeEndereco = "";
            this.EstadoEndereco = "";
        }
        //Construtor gerado para poder instanciar a o objeto na MEndereco na camada GUI
        public MEndereco(int cepEndereco, string logradouroEndereco, string bairroEndereco, int numeroEndereco, string cidadeEndereco, string estadoEndereco)
        {
            CepEndereco = cepEndereco;
            LogradouroEndereco = logradouroEndereco;
            BairroEndereco = bairroEndereco;
            NumeroEndereco = numeroEndereco;
            CidadeEndereco = cidadeEndereco;
            EstadoEndereco = estadoEndereco;
        }

    }
}

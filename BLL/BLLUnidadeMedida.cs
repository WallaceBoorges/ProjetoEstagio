using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUnidadeMedida
    {
        public static void Incluir(MUnidadeMedida modelo)
        {
            if (modelo.nomeUniMedida.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório!");
            }
            //Para ficar tudo maiúsculo
            modelo.nomeUniMedida = modelo.nomeUniMedida.ToUpper();
            DALUnidadeMedida.Incluir(modelo);
        }
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Alterar(MUnidadeMedida modelo)
        {
            if (modelo.codigoUniMedida <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório!");
            }

            if (modelo.nomeUniMedida.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório!");
            }
            //Para ficar tudo maiúsculo
            modelo.nomeUniMedida = modelo.nomeUniMedida.ToUpper();
            DALUnidadeMedida.Alterar(modelo);
        }
       
        public static void Excluir(int codigo)
        {
            DALCategoria.Excluir(codigo);
        }
        public static DataTable LocalizarDados(String valor)
        {
            //Analisando se foi localizado algum registro
            if (DALSubCategoria.LocalizarDados(valor).Rows.Count > 0)
            {
                return DALUnidadeMedida.LocalizarDados(valor);
            }
            else
            {
                throw new Exception("Não foi encontrado nenhum registro!");
            }
        }
        public static DataTable CarregarGrid()
        {
            return DALUnidadeMedida.CarregarGrid();
        }
    }
}


﻿using DAL;
using Modelo;
using System;

namespace BLL
{
    public class BLLParcelasCompras
    {
        /* Aqui foi criada uma pequena restrição para o usuário*/
        public static void Incluir(MParcelasCompra modelo)
        {
            DALParcelasCompra.Incluir(modelo);
        }

        public static void Excluir(MParcelasCompra modelo)
        {
            DALParcelasCompra.Excluir(modelo);
        }

        public static void ConfPag(String data, int cod)
        {
            DALParcelasCompra.ConfPag(data, cod);
        }
    }
}

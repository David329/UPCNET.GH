using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Categoria
    {
        private String IdCategoria;
        private String Monto;

        public Categoria(string idCategoria, string monto)
        {
            IdCategoria = idCategoria;
            Monto = monto;
        }

        public String getIdCategoria() { return IdCategoria; }
        public String getMonto() { return Monto; }
    }
}
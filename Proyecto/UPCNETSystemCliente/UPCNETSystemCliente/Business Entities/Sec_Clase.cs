using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Sec_Clase
    {
        private String IdClase;
        private String IdSecClase;
        private String Dia;
        private String HoraIni;
        private String HoraFin;

        public Sec_Clase(string idClase, string idSecClase, string dia, string horaIni, string horaFin)
        {
            IdClase = idClase;
            IdSecClase = idSecClase;
            Dia = dia;
            HoraIni = horaIni;
            HoraFin = horaFin;
        }

        public String getIdClase() { return IdClase; }
        public String getIdSecClase() { return IdSecClase; }
        public String getDia() { return Dia; }
        public String getHoraIni() { return HoraIni; }
        public String getHoraFin() { return HoraFin; }

    }
}
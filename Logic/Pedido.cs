using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2Farmcia.Logic
{
    public class Pedido
    {
        public string Nombremedicamento { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string Distribuidor { get; set; }
        public string Sucursal { get; set; }  
        public Pedido() {
            Nombremedicamento = string.Empty;
            Tipo = string.Empty;
            Distribuidor = string.Empty;
        }
        public Pedido(string nombremedicamento, string tipo, int cantidad, string distribuidor, string sucursalprincipal)
        {
            Nombremedicamento = nombremedicamento;
            Tipo = tipo;
            Cantidad = cantidad;
            Distribuidor = distribuidor;
            Sucursal = sucursalprincipal;
        }
    }
}

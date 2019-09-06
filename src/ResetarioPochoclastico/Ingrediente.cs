using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetarioPochoclastico
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public int StockMinimo { get; set; }
        public string MostrarDatos
        {
            get
            {
                return Nombre + " / " + Cantidad;
            }
        }
    }
}

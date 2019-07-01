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
        public double Costo { get; set; }
        public int StockMinimo { get; set; }

    }
}

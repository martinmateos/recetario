using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetarioPochoclastico
{
    public class RecetaIngrediente
    {
        public Ingrediente Ingrediente { get; set; }
        public int Cantidad { get; set; }
        public string DatosRecetaIngrediente
        {
            get
            {
                return $"{Cantidad} {Ingrediente.Nombre}";
            }
        }
    }
}

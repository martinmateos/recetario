using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetarioPochoclastico
{
    public class Receta
    {
        public string Nombre { get; set; }
        public List<RecetaIngrediente> Ingredientes { get; set; }

        public string MostrarDatosReceta
        {
            get
            {
                return $"{Nombre}";
            }
        }
    }
}

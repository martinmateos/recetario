using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetarioPochoclastico
{
    class Controlador
    {
        public List<Receta> Recetas { get; }
        public List<Ingrediente> ListIngredientes { get; }
        public Controlador()
        {
            Recetas = new List<Receta>();
            ListIngredientes = new List<Ingrediente>();
        }
       
        public void AgregarReceta (string nombreReceta, string ingredientes,double costoReceta, double tiempoPreparacion )
        {
            Receta receta = new Receta()
            {
                NombreReceta=nombreReceta,
                Ingredientes=ingredientes,
                CostoReceta=costoReceta,
                TiempoPreparacion=tiempoPreparacion
            };
        }
        public void AgregarIngredientes (string nombreIngrediente, double cantidad, double costoIngrediente)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                NombreIngrediente = nombreIngrediente,
                Cantidad = cantidad,
                CostoIngrediente = costoIngrediente
            };
        }
        public void BorrarIngredientes(Ingrediente ingrediente)
        {
            ListIngredientes.Remove(ingrediente);
        }
        public void ModIngrediente (Ingrediente ingrediente, string nombreIngrediente, double cantidad, double costoIngrediente)
        {
            ingrediente.NombreIngrediente = nombreIngrediente;
            ingrediente.Cantidad = cantidad;
            ingrediente.CostoIngrediente = costoIngrediente;
        }
    }
}

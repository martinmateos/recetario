using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetarioPochoclastico
{
    class Controlador
    {
        public List<Receta> ListRecetas { get; }
        public List<Ingrediente> ListIngredientes { get; }
        public List<RecetaIngrediente> ListRecetaIngredientes { get; }
        public Controlador()
        {
            ListRecetas = new List<Receta>();
            ListIngredientes = new List<Ingrediente>();
            ListRecetaIngredientes = new List<RecetaIngrediente>();
        }
        //abm receta
        public void AgregarReceta (string nombreReceta, List<RecetaIngrediente> ingredientes )
        {
            Receta receta = new Receta()
            {
                Nombre=nombreReceta,
                Ingredientes=ingredientes
            };
            ListRecetas.Add(receta);
        }
        public void BorrarReceta (Receta receta)
        {
            ListRecetas.Remove(receta);
        }
        public void ModReceta (Receta receta, string nombreReceta, List<RecetaIngrediente> ingredientes)
        {
            receta.Ingredientes = ingredientes;
            receta.Nombre = nombreReceta;
        }
        //-----

        //abm de ingrediente
        public void AgregarIngredientes (string nombreIngrediente, int cantidad, double costoIngrediente)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                Nombre = nombreIngrediente,
                Cantidad = cantidad,
                Costo = costoIngrediente
            };
            ListIngredientes.Add(ingrediente);
        }
        public void BorrarIngredientes(Ingrediente ingrediente)
        {
            ListIngredientes.Remove(ingrediente);
        }
        public void ModIngrediente (Ingrediente ingrediente, string nombreIngrediente, int cantidad, double costoIngrediente)
        {
            ingrediente.Nombre = nombreIngrediente;
            ingrediente.Cantidad = cantidad;
            ingrediente.Costo = costoIngrediente;
        }
        //-----

        //abm RecetaIngrediente

        public void AddRecetaIngrediente (Receta receta, Ingrediente ingrediente, int cantidad)
        {
            RecetaIngrediente recetaIngrediente = new RecetaIngrediente()
            {
                Ingrediente = ingrediente,
                Cantidad=cantidad
            };
            receta.Ingredientes.Add(recetaIngrediente);
        }


        //----------
    }
}

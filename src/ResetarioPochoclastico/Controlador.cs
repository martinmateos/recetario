using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetarioPochoclastico
{
     public static class  Controlador // clase estatica, se relaciona con las demas clases declarando solo con su nombre
    {
        public static List<Receta> ListRecetas { get; }
        public static List<Ingrediente> ListIngredientes { get; private set; }
        public static List<RecetaIngrediente> ListRecetaIngredientes { get; }
         static Controlador()
        {
            ListRecetas = new List<Receta>();
            ListIngredientes = new List<Ingrediente>();
            ListRecetaIngredientes = new List<RecetaIngrediente>();
            Cargar();
        }
        //abm receta
        public static void AgregarReceta (string nombreReceta)
        {
            Receta receta = new Receta()
            {
                Nombre = nombreReceta,
                //Ingredientes = null
            };
            ListRecetas.Add(receta);
        }
        public static void BorrarReceta (Receta receta)
        {
            ListRecetas.Remove(receta);
        }
        public static void ModReceta (Receta receta, string nombreReceta, List<RecetaIngrediente> ingredientes)
        {
            receta.Ingredientes = ingredientes;
            receta.Nombre = nombreReceta;
        }
        public static void HacerReceta (Receta receta, string nombreReceta, List<RecetaIngrediente> ingredientes)
        {
           
        }
        //-----

        //abm de ingrediente
        public static void AgregarIngredientes (string nombreIngrediente, int cantidad, decimal costoIngrediente, int puntoDePedido)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                Nombre = nombreIngrediente,
                Cantidad = cantidad,
                Costo = costoIngrediente,
                StockMinimo = puntoDePedido

            };
            ListIngredientes.Add(ingrediente);
            Guardar();
        }
        public static void BorrarIngredientes(Ingrediente ingrediente)
        {
            ListIngredientes.Remove(ingrediente);
            Guardar();
        }
        public static void ModIngrediente (Ingrediente ingrediente, string nombreIngrediente, int cantidad, decimal costoIngrediente, int puntoDePedido)
        {
            ingrediente.Nombre = nombreIngrediente;
            ingrediente.Cantidad = cantidad;
            ingrediente.Costo = costoIngrediente;
            ingrediente.StockMinimo = puntoDePedido;
            Guardar();
        }
        //-----

        //abm RecetaIngrediente

        public static void AddRecetaIngrediente (Receta receta, Ingrediente ingrediente, int cantidad)
        {
            RecetaIngrediente recetaIngrediente = new RecetaIngrediente()
            {
                Ingrediente = ingrediente,
                Cantidad=cantidad
            };
            receta.Ingredientes.Add(recetaIngrediente);
        }

        //GUARDAR---------------

        public static void Guardar()
        {
            using (StreamWriter ESCRITOR = new StreamWriter("ingrediente.json")) //StreamWriter crea o sobrescribe un archivo de texto
            {
                string ingredienteJson = JsonConvert.SerializeObject(ListIngredientes);
                ESCRITOR.Write(ingredienteJson);
            }
        }
        
        //CARGAR--------------------
        public static void Cargar()
        {
            if (File.Exists("ingrediente.json"))
            using (StreamReader LEYENTE = new StreamReader("ingrediente.json"))
            {
                string ingredienteJson = LEYENTE.ReadToEnd();//lee 
                ListIngredientes = JsonConvert.DeserializeObject<List<Ingrediente>>(ingredienteJson);
            }
        }
    }
}

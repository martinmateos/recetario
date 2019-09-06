using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResetarioPochoclastico
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent(); 
            RefrescarListBox();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void IngredientesDisp_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingrediente ingrediente = IngredientesDisp_ListBox.SelectedItem as Ingrediente;
            if (ingrediente != null)
            {
                CantidadDisp_Textbox.Text = ingrediente.Cantidad.ToString();//Muestra la cantidad de ingredientes en el texbox de la cantidad disp.
            }
           
        }
        //Refresca la lista de ingredientes disponibles
        private void RefrescarListBox()
        {
            IngredientesDisp_ListBox.Items.Clear();
            foreach (Ingrediente ingrediente in Controlador.ListIngredientes)
            {
                IngredientesDisp_ListBox.Items.Add(ingrediente); // Agrega los ingredientes a la ListBox
            }
        }
        private void recetas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IngredientesReceta_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //Pasaje de ingrediente con su cantidad por el boton
        private void UsarIngrediente_Button_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = IngredientesDisp_ListBox.SelectedItem as Ingrediente;
            Receta receta = recetas_listBox.SelectedItem as Receta;

            if (receta!=null && ingrediente != null)
            {
                Controlador.AddRecetaIngrediente(receta, ingrediente, int.Parse(Cantidad_Textbox2.Text));
                RefrescarListBoxRecetaIngrediente(receta);
            }
            
        }

        private void RefrescarListBoxRecetaIngrediente(Receta receta)
        {
            if (receta != null)
            {
                IngredientesReceta_ListBox.Items.Clear();
                foreach (RecetaIngrediente recetaIngrediente in receta.Ingredientes)
                {
                    IngredientesReceta_ListBox.Items.Add(recetaIngrediente);
                }
            }
        }

        private void RefrescarListBoxRecetas()
        {
            recetas_listBox.Items.Clear();
            foreach (Receta receta in Controlador.ListRecetas)
            {
                recetas_listBox.Items.Add(receta);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_Textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_receta_button_Click(object sender, EventArgs e)
        {
            Controlador.AgregarReceta(NombreReceta_Textbox.Text);
            RefrescarListBoxRecetas();
        }
    }
}
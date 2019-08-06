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

        private void UsarIngrediente_Button_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = IngredientesDisp_ListBox.SelectedItem as Ingrediente; //Pasaje de ingrediente con su cantidad
            RecetaIngrediente recetaIngrediente = new RecetaIngrediente()
            {
               Cantidad=int.Parse(Cantidad_Textbox2.Text),
               Ingrediente=ingrediente
            };
            IngredientesReceta_ListBox.Items.Add(recetaIngrediente);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class Form1 : Form
    {
        Controlador controlador;//menciona

        public Form1()
        {
            InitializeComponent();
            controlador = new Controlador();//existe 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ModificarIngrediente_button_Click(object sender, EventArgs e)
        {

        }

        private void borrar_ingr_button_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = ingredientes_listBox.SelectedItem as Ingrediente;
            controlador.BorrarIngredientes(ingrediente);
            Refrescar();
        }
        private void Refrescar()
        {
            ingredientes_listBox.Items.Clear();
            recetas_listBox.Items.Clear();
            foreach (Ingrediente ingrediente in controlador.ListIngredientes)
            {
                ingredientes_listBox.Items.Add(ingrediente);
            }
            foreach (Receta receta in controlador.Recetas)
            {
                recetas_listBox.Items.Add(receta);
            }
        }
    }
}

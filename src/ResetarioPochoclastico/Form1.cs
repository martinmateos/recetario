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
        public Form1()
        {
            InitializeComponent();
        }

        private void Pasaje_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Abre la ventana de Form2, donde estan las recetas.
            form2.ShowDialog();
        }

     
        private void comprar_ingr_button_Click(object sender, EventArgs e)
        {
            Controlador.AgregarIngredientes(ingrediente_textbox.Text, int.Parse(Cantidad_textbox.Text), int.Parse(Precio_textbox.Text), int.Parse(PdP_textbox.Text));
            RefrescarListBox();
        }

        private void borrar_ingr_button_Click(object sender, EventArgs e)
        {
            Controlador.BorrarIngredientes(ingredientes_listBox.SelectedItem as Ingrediente);
            RefrescarListBox();
        }

        private void mod_ingr_button_Click(object sender, EventArgs e)
        {
            Controlador.ModIngrediente(ingredientes_listBox.SelectedItem as Ingrediente, ingrediente_textbox.Text, int.Parse(Cantidad_textbox.Text), int.Parse(Precio_textbox.Text), int.Parse(PdP_textbox.Text));
            RefrescarListBox();
        }
        private void RefrescarListBox()
        {
            ingredientes_listBox.Items.Clear();
            foreach (Ingrediente ingrediente in Controlador.ListIngredientes)
            {
                ingredientes_listBox.Items.Add(ingrediente); // Agrega los ingredientes a la ListBox
            }
        }

        private void ingredientes_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ingrediente ingrediente = ingredientes_listBox.SelectedItem as Ingrediente; // Muestra los datos del Ingrediente seleccionados en los TextBox
            if (ingrediente != null)
            {
                ingrediente_textbox.Text = ingrediente.Nombre;
                Cantidad_textbox.Text = ingrediente.Cantidad.ToString();
                Precio_textbox.Text = ingrediente.Costo.ToString();
                PdP_textbox.Text = ingrediente.StockMinimo.ToString();
            }
        }
    }
}

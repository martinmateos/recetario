namespace ResetarioPochoclastico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ingredientes_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ingrediente_textbox = new System.Windows.Forms.TextBox();
            this.Cantidad_textbox = new System.Windows.Forms.TextBox();
            this.Precio_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comprar_ingr_button = new System.Windows.Forms.Button();
            this.borrar_ingr_button = new System.Windows.Forms.Button();
            this.mod_ingr_button = new System.Windows.Forms.Button();
            this.PdP_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Pasaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingredientes_listBox
            // 
            this.ingredientes_listBox.DisplayMember = "MostrarDatos";
            this.ingredientes_listBox.FormattingEnabled = true;
            this.ingredientes_listBox.Location = new System.Drawing.Point(308, 60);
            this.ingredientes_listBox.Name = "ingredientes_listBox";
            this.ingredientes_listBox.Size = new System.Drawing.Size(177, 277);
            this.ingredientes_listBox.TabIndex = 1;
            this.ingredientes_listBox.SelectedIndexChanged += new System.EventHandler(this.ingredientes_listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "INGREDIENTES DISPONIBLES";
            // 
            // ingrediente_textbox
            // 
            this.ingrediente_textbox.Location = new System.Drawing.Point(145, 94);
            this.ingrediente_textbox.Name = "ingrediente_textbox";
            this.ingrediente_textbox.Size = new System.Drawing.Size(120, 20);
            this.ingrediente_textbox.TabIndex = 11;
            // 
            // Cantidad_textbox
            // 
            this.Cantidad_textbox.Location = new System.Drawing.Point(145, 142);
            this.Cantidad_textbox.Name = "Cantidad_textbox";
            this.Cantidad_textbox.Size = new System.Drawing.Size(120, 20);
            this.Cantidad_textbox.TabIndex = 12;
            // 
            // Precio_textbox
            // 
            this.Precio_textbox.Location = new System.Drawing.Point(145, 190);
            this.Precio_textbox.Name = "Precio_textbox";
            this.Precio_textbox.Size = new System.Drawing.Size(120, 20);
            this.Precio_textbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingrediente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad (g)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio ";
            // 
            // comprar_ingr_button
            // 
            this.comprar_ingr_button.Location = new System.Drawing.Point(145, 285);
            this.comprar_ingr_button.Name = "comprar_ingr_button";
            this.comprar_ingr_button.Size = new System.Drawing.Size(120, 23);
            this.comprar_ingr_button.TabIndex = 21;
            this.comprar_ingr_button.Text = "Agregar Ingrediente";
            this.comprar_ingr_button.UseVisualStyleBackColor = true;
            this.comprar_ingr_button.Click += new System.EventHandler(this.comprar_ingr_button_Click);
            // 
            // borrar_ingr_button
            // 
            this.borrar_ingr_button.Location = new System.Drawing.Point(145, 314);
            this.borrar_ingr_button.Name = "borrar_ingr_button";
            this.borrar_ingr_button.Size = new System.Drawing.Size(120, 23);
            this.borrar_ingr_button.TabIndex = 26;
            this.borrar_ingr_button.Text = "Borrar ingrediente";
            this.borrar_ingr_button.UseVisualStyleBackColor = true;
            this.borrar_ingr_button.Click += new System.EventHandler(this.borrar_ingr_button_Click);
            // 
            // mod_ingr_button
            // 
            this.mod_ingr_button.Location = new System.Drawing.Point(145, 343);
            this.mod_ingr_button.Name = "mod_ingr_button";
            this.mod_ingr_button.Size = new System.Drawing.Size(120, 23);
            this.mod_ingr_button.TabIndex = 27;
            this.mod_ingr_button.Text = "Modificar ingredientes";
            this.mod_ingr_button.UseVisualStyleBackColor = true;
            this.mod_ingr_button.Click += new System.EventHandler(this.mod_ingr_button_Click);
            // 
            // PdP_textbox
            // 
            this.PdP_textbox.Location = new System.Drawing.Point(145, 244);
            this.PdP_textbox.Name = "PdP_textbox";
            this.PdP_textbox.Size = new System.Drawing.Size(120, 20);
            this.PdP_textbox.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Punto de pedido";
            // 
            // Pasaje
            // 
            this.Pasaje.Location = new System.Drawing.Point(470, 362);
            this.Pasaje.Name = "Pasaje";
            this.Pasaje.Size = new System.Drawing.Size(170, 42);
            this.Pasaje.TabIndex = 38;
            this.Pasaje.Text = "RECETAS -->";
            this.Pasaje.UseVisualStyleBackColor = true;
            this.Pasaje.Click += new System.EventHandler(this.Pasaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 416);
            this.Controls.Add(this.Pasaje);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PdP_textbox);
            this.Controls.Add(this.mod_ingr_button);
            this.Controls.Add(this.borrar_ingr_button);
            this.Controls.Add(this.comprar_ingr_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Precio_textbox);
            this.Controls.Add(this.Cantidad_textbox);
            this.Controls.Add(this.ingrediente_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientes_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ingredientes_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ingrediente_textbox;
        private System.Windows.Forms.TextBox Cantidad_textbox;
        private System.Windows.Forms.TextBox Precio_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button comprar_ingr_button;
        private System.Windows.Forms.Button borrar_ingr_button;
        private System.Windows.Forms.Button mod_ingr_button;
        private System.Windows.Forms.TextBox PdP_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Pasaje_a_recetas;
        private System.Windows.Forms.Button Pasaje;
    }
}


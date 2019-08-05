namespace ResetarioPochoclastico
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UsarIngrediente_Button = new System.Windows.Forms.Button();
            this.IngredientesReceta_ListBox = new System.Windows.Forms.ListBox();
            this.IngredientesDisp_ListBox = new System.Windows.Forms.ListBox();
            this.NombreReceta_Textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.agregar_receta_button = new System.Windows.Forms.Button();
            this.hacer_button = new System.Windows.Forms.Button();
            this.modificar_receta_button = new System.Windows.Forms.Button();
            this.borrar_receta_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recetas_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Ingredientes de la Receta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cantidad (g)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 44;
            // 
            // UsarIngrediente_Button
            // 
            this.UsarIngrediente_Button.Location = new System.Drawing.Point(212, 200);
            this.UsarIngrediente_Button.Name = "UsarIngrediente_Button";
            this.UsarIngrediente_Button.Size = new System.Drawing.Size(117, 39);
            this.UsarIngrediente_Button.TabIndex = 43;
            this.UsarIngrediente_Button.Text = ">>>";
            this.UsarIngrediente_Button.UseVisualStyleBackColor = true;
            // 
            // IngredientesReceta_ListBox
            // 
            this.IngredientesReceta_ListBox.FormattingEnabled = true;
            this.IngredientesReceta_ListBox.Location = new System.Drawing.Point(374, 93);
            this.IngredientesReceta_ListBox.Name = "IngredientesReceta_ListBox";
            this.IngredientesReceta_ListBox.Size = new System.Drawing.Size(152, 225);
            this.IngredientesReceta_ListBox.TabIndex = 42;
            // 
            // IngredientesDisp_ListBox
            // 
            this.IngredientesDisp_ListBox.FormattingEnabled = true;
            this.IngredientesDisp_ListBox.Location = new System.Drawing.Point(32, 93);
            this.IngredientesDisp_ListBox.Name = "IngredientesDisp_ListBox";
            this.IngredientesDisp_ListBox.Size = new System.Drawing.Size(152, 212);
            this.IngredientesDisp_ListBox.TabIndex = 41;
            this.IngredientesDisp_ListBox.SelectedIndexChanged += new System.EventHandler(this.IngredientesDisp_ListBox_SelectedIndexChanged);
            // 
            // NombreReceta_Textbox
            // 
            this.NombreReceta_Textbox.Location = new System.Drawing.Point(212, 109);
            this.NombreReceta_Textbox.Name = "NombreReceta_Textbox";
            this.NombreReceta_Textbox.Size = new System.Drawing.Size(117, 20);
            this.NombreReceta_Textbox.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ingredientes Disponibles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nombre de Receta";
            // 
            // agregar_receta_button
            // 
            this.agregar_receta_button.Location = new System.Drawing.Point(212, 261);
            this.agregar_receta_button.Name = "agregar_receta_button";
            this.agregar_receta_button.Size = new System.Drawing.Size(120, 52);
            this.agregar_receta_button.TabIndex = 36;
            this.agregar_receta_button.Text = "Agregar receta";
            this.agregar_receta_button.UseVisualStyleBackColor = true;
            // 
            // hacer_button
            // 
            this.hacer_button.Location = new System.Drawing.Point(188, 430);
            this.hacer_button.Name = "hacer_button";
            this.hacer_button.Size = new System.Drawing.Size(120, 23);
            this.hacer_button.TabIndex = 51;
            this.hacer_button.Text = "¡A cocinar!";
            this.hacer_button.UseVisualStyleBackColor = true;
            // 
            // modificar_receta_button
            // 
            this.modificar_receta_button.Location = new System.Drawing.Point(188, 401);
            this.modificar_receta_button.Name = "modificar_receta_button";
            this.modificar_receta_button.Size = new System.Drawing.Size(120, 23);
            this.modificar_receta_button.TabIndex = 50;
            this.modificar_receta_button.Text = "Modificar receta";
            this.modificar_receta_button.UseVisualStyleBackColor = true;
            // 
            // borrar_receta_button
            // 
            this.borrar_receta_button.Location = new System.Drawing.Point(188, 372);
            this.borrar_receta_button.Name = "borrar_receta_button";
            this.borrar_receta_button.Size = new System.Drawing.Size(120, 23);
            this.borrar_receta_button.TabIndex = 49;
            this.borrar_receta_button.Text = "Borrar Receta";
            this.borrar_receta_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "RECETAS";
            // 
            // recetas_listBox
            // 
            this.recetas_listBox.FormattingEnabled = true;
            this.recetas_listBox.Location = new System.Drawing.Point(32, 372);
            this.recetas_listBox.Name = "recetas_listBox";
            this.recetas_listBox.Size = new System.Drawing.Size(120, 95);
            this.recetas_listBox.TabIndex = 47;
            this.recetas_listBox.SelectedIndexChanged += new System.EventHandler(this.recetas_listBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 497);
            this.Controls.Add(this.hacer_button);
            this.Controls.Add(this.modificar_receta_button);
            this.Controls.Add(this.borrar_receta_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recetas_listBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UsarIngrediente_Button);
            this.Controls.Add(this.IngredientesReceta_ListBox);
            this.Controls.Add(this.IngredientesDisp_ListBox);
            this.Controls.Add(this.NombreReceta_Textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.agregar_receta_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button UsarIngrediente_Button;
        private System.Windows.Forms.ListBox IngredientesReceta_ListBox;
        private System.Windows.Forms.ListBox IngredientesDisp_ListBox;
        private System.Windows.Forms.TextBox NombreReceta_Textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregar_receta_button;
        private System.Windows.Forms.Button hacer_button;
        private System.Windows.Forms.Button modificar_receta_button;
        private System.Windows.Forms.Button borrar_receta_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox recetas_listBox;
    }
}
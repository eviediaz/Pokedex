namespace Pokemon.UI
{
    partial class FrmPokemon
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
            lbTitulo = new Label();
            lbID = new Label();
            tbPokemonId = new TextBox();
            tbNombre = new TextBox();
            label1 = new Label();
            tbPeso = new TextBox();
            label2 = new Label();
            tbAltura = new TextBox();
            label3 = new Label();
            tbHabilidad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbTipo1 = new ComboBox();
            cbTipo2 = new ComboBox();
            cbDeb1 = new ComboBox();
            cbDeb2 = new ComboBox();
            label6 = new Label();
            cbDeb3 = new ComboBox();
            cbDeb4 = new ComboBox();
            btnAceptar = new Button();
            label7 = new Label();
            pbImagen = new PictureBox();
            label8 = new Label();
            tbDescripcion = new TextBox();
            tbCategoria = new TextBox();
            label9 = new Label();
            tbImagen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(338, 29);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(60, 20);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "lbTitulo";
            lbTitulo.Click += lbTitulo_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(59, 79);
            lbID.Name = "lbID";
            lbID.Size = new Size(27, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID:";
            // 
            // tbPokemonId
            // 
            tbPokemonId.Location = new Point(143, 76);
            tbPokemonId.Name = "tbPokemonId";
            tbPokemonId.Size = new Size(244, 27);
            tbPokemonId.TabIndex = 2;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(143, 122);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(244, 27);
            tbNombre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 125);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // tbPeso
            // 
            tbPeso.Location = new Point(143, 170);
            tbPeso.Name = "tbPeso";
            tbPeso.Size = new Size(244, 27);
            tbPeso.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 173);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "Peso:";
            // 
            // tbAltura
            // 
            tbAltura.Location = new Point(143, 259);
            tbAltura.Name = "tbAltura";
            tbAltura.Size = new Size(244, 27);
            tbAltura.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 262);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "Altura:";
            // 
            // tbHabilidad
            // 
            tbHabilidad.Location = new Point(143, 305);
            tbHabilidad.Name = "tbHabilidad";
            tbHabilidad.Size = new Size(244, 27);
            tbHabilidad.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 308);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Habilidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 345);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 11;
            label5.Text = "Tipo:";
            // 
            // cbTipo1
            // 
            cbTipo1.FormattingEnabled = true;
            cbTipo1.Location = new Point(59, 373);
            cbTipo1.Name = "cbTipo1";
            cbTipo1.Size = new Size(142, 28);
            cbTipo1.TabIndex = 12;
            // 
            // cbTipo2
            // 
            cbTipo2.FormattingEnabled = true;
            cbTipo2.Location = new Point(245, 373);
            cbTipo2.Name = "cbTipo2";
            cbTipo2.Size = new Size(142, 28);
            cbTipo2.TabIndex = 13;
            // 
            // cbDeb1
            // 
            cbDeb1.FormattingEnabled = true;
            cbDeb1.Location = new Point(59, 458);
            cbDeb1.Name = "cbDeb1";
            cbDeb1.Size = new Size(142, 28);
            cbDeb1.TabIndex = 16;
            // 
            // cbDeb2
            // 
            cbDeb2.FormattingEnabled = true;
            cbDeb2.Location = new Point(245, 458);
            cbDeb2.Name = "cbDeb2";
            cbDeb2.Size = new Size(142, 28);
            cbDeb2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 429);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 14;
            label6.Text = "Debilidad:";
            // 
            // cbDeb3
            // 
            cbDeb3.FormattingEnabled = true;
            cbDeb3.Location = new Point(59, 500);
            cbDeb3.Name = "cbDeb3";
            cbDeb3.Size = new Size(142, 28);
            cbDeb3.TabIndex = 18;
            // 
            // cbDeb4
            // 
            cbDeb4.FormattingEnabled = true;
            cbDeb4.Location = new Point(245, 500);
            cbDeb4.Name = "cbDeb4";
            cbDeb4.Size = new Size(142, 28);
            cbDeb4.TabIndex = 17;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(313, 565);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(175, 34);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 70);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 20;
            label7.Text = "Imagen:";
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(443, 91);
            pbImagen.MaximumSize = new Size(323, 298);
            pbImagen.MinimumSize = new Size(323, 298);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(323, 298);
            pbImagen.TabIndex = 21;
            pbImagen.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 429);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 22;
            label8.Text = "Descripcion:";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(442, 458);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(324, 70);
            tbDescripcion.TabIndex = 23;
            // 
            // tbCategoria
            // 
            tbCategoria.Location = new Point(143, 215);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(244, 27);
            tbCategoria.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 218);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 24;
            label9.Text = "Categoria:";
            // 
            // tbImagen
            // 
            tbImagen.Location = new Point(442, 395);
            tbImagen.Name = "tbImagen";
            tbImagen.Size = new Size(324, 27);
            tbImagen.TabIndex = 26;
            // 
            // FrmPokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 611);
            Controls.Add(tbImagen);
            Controls.Add(tbCategoria);
            Controls.Add(label9);
            Controls.Add(tbDescripcion);
            Controls.Add(label8);
            Controls.Add(pbImagen);
            Controls.Add(label7);
            Controls.Add(btnAceptar);
            Controls.Add(cbDeb3);
            Controls.Add(cbDeb4);
            Controls.Add(cbDeb1);
            Controls.Add(cbDeb2);
            Controls.Add(label6);
            Controls.Add(cbTipo2);
            Controls.Add(cbTipo1);
            Controls.Add(label5);
            Controls.Add(tbHabilidad);
            Controls.Add(label4);
            Controls.Add(tbAltura);
            Controls.Add(label3);
            Controls.Add(tbPeso);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Controls.Add(tbPokemonId);
            Controls.Add(lbID);
            Controls.Add(lbTitulo);
            Name = "FrmPokemon";
            Text = "FrmPokemon";
            Load += FrmPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbID;
        private TextBox tbPokemonId;
        private TextBox tbNombre;
        private Label label1;
        private TextBox tbPeso;
        private Label label2;
        private TextBox tbAltura;
        private Label label3;
        private TextBox tbHabilidad;
        private Label label4;
        private Label label5;
        private ComboBox cbTipo1;
        private ComboBox cbTipo2;
        private ComboBox cbDeb1;
        private ComboBox cbDeb2;
        private Label label6;
        private ComboBox cbDeb3;
        private ComboBox cbDeb4;
        private Button btnAceptar;
        private Label label7;
        private PictureBox pbImagen;
        private Label label8;
        private TextBox tbDescripcion;
        private TextBox tbCategoria;
        private Label label9;
        private TextBox tbImagen;
    }
}
namespace Pokemon.UI
{
    partial class FrmAdmPokemon
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
            label1 = new Label();
            dgvPokemon = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Pokemon";
            // 
            // dgvPokemon
            // 
            dgvPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemon.Location = new Point(64, 65);
            dgvPokemon.MultiSelect = false;
            dgvPokemon.Name = "dgvPokemon";
            dgvPokemon.RowHeadersWidth = 51;
            dgvPokemon.RowTemplate.Height = 29;
            dgvPokemon.Size = new Size(686, 335);
            dgvPokemon.TabIndex = 1;
            dgvPokemon.CellContentClick += dgvPokemon_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(64, 418);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(195, 418);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 34);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(333, 418);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmAdmPokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPokemon);
            Controls.Add(label1);
            Name = "FrmAdmPokemon";
            Text = "FrmAdmUsuario";
            Load += FrmAdmPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPokemon;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
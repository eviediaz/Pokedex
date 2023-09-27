namespace Pokedex.UI
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
            this.dataGridPokemon = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPokemon
            // 
            this.dataGridPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPokemon.Location = new System.Drawing.Point(42, 44);
            this.dataGridPokemon.Name = "dataGridPokemon";
            this.dataGridPokemon.RowHeadersWidth = 51;
            this.dataGridPokemon.RowTemplate.Height = 24;
            this.dataGridPokemon.Size = new System.Drawing.Size(718, 406);
            this.dataGridPokemon.TabIndex = 0;
            this.dataGridPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPokemon_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmAdmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 541);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridPokemon);
            this.Name = "FrmAdmPokemon";
            this.Text = "FrmAdmPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPokemon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
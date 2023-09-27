using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex.BL.BC;

namespace Pokedex.UI
{
    public partial class FrmAdmPokemon : Form
    {
        public FrmAdmPokemon()
        {
            InitializeComponent();
        }

        private void dataGridPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dlgActualizarGrilla();

            int Numero = -1; // variable clasica
            Int32 Numero2; // variable objeto
            int? Numero3 = null; // variable nuelable
            var Numero4 = new Decimal(); // variable anonima
        }

        public void dlgActualizarGrilla()
        {
            PokemonBC objPokemonBC = new PokemonBC();
            dgvPokemon.DataSource = objPokemonBC.PokemonListar();
        }
    }
}

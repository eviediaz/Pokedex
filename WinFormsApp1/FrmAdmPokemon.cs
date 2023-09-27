using Pokedex.BL.BC;
using System.Windows.Forms;

namespace Pokemon.UI
{
    public partial class FrmAdmPokemon : Form
    {
        public FrmAdmPokemon()
        {
            InitializeComponent();
        }


        private void dgvPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAdmPokemon_Load(object sender, EventArgs e)
        {
            dlgActualizarGrilla();
        }

        public void dlgActualizarGrilla()
        {
            PokemonBC objPokemonBC = new PokemonBC();
            dgvPokemon.DataSource = objPokemonBC.PokemonListar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPokemon frm = new FrmPokemon();
            frm.objDelegado += dlgActualizarGrilla;
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPokemon = Convert.ToInt32(dgvPokemon.SelectedRows[0].Cells[0].Value);
                PokemonDebilidadBC objPDebilidadBC = new PokemonDebilidadBC();
                PokemonTipoBC objPTipoBC = new PokemonTipoBC();
                FrmPokemon frm = new FrmPokemon();
                frm.PokemonId = idPokemon;


                frm.objDelegado += dlgActualizarGrilla;
                frm.ShowDialog();

            }
            catch (Exception)
            {
                String strMensaje = "Seleccionar la fila correctamente";
                MessageBox.Show(strMensaje, "Sistema Pokemon", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el Pokemon seleccionado?", "Sistema Pokemon", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PokemonBC objPokemonBC = new PokemonBC();
                objPokemonBC.PokemonEliminar(Convert.ToInt32(dgvPokemon.SelectedRows[0].Cells[0].Value));
                dlgActualizarGrilla();
            }

        }
    }
}

using Pokedex.BL.BC;
using Pokedex.BL.BE;

using System;
using System.Reflection.Metadata.Ecma335;

namespace Pokemon.UI
{
    public partial class FrmPokemon : Form
    {
        public int? PokemonId { get; set; }
        public int? OldTipo1 { get; set; }
        public int? OldTipo2 { get; set; }
        public int? OldDeb1 { get; set; }
        public int? OldDeb2 { get; set; }
        public int? OldDeb3 { get; set; }
        public int? OldDeb4 { get; set; }
        public List<int?> OldDebs { get; set; }

        public List<int?> OldTipos { get; set; }

        public delegate void dlgActualizarGrilla();
        public dlgActualizarGrilla objDelegado;

        public FrmPokemon()
        {
            InitializeComponent();
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmPokemon_Load(object sender, EventArgs e)
        {

            TipoBC objTipoBC = new TipoBC();

            ComboBoxesGen(cbTipo1, objTipoBC);
            ComboBoxesGen(cbTipo2, objTipoBC);
            ComboBoxesGen(cbDeb1, objTipoBC);
            ComboBoxesGen(cbDeb2, objTipoBC);
            ComboBoxesGen(cbDeb3, objTipoBC);
            ComboBoxesGen(cbDeb4, objTipoBC);

            cbTipo1.SelectedIndex = -1;
            cbTipo2.SelectedIndex = -1;
            cbDeb1.SelectedIndex = -1;
            cbDeb2.SelectedIndex = -1;
            cbDeb3.SelectedIndex = -1;
            cbDeb4.SelectedIndex = -1;

            if (PokemonId.HasValue)
            {
                lbTitulo.Text = "Editar Pokemon";
                PokemonBC objPokemonBC = new PokemonBC();
                PokemonBE objPokemonBE = objPokemonBC.PokemonObtener(PokemonId.Value);

                tbPokemonId.Text = objPokemonBE.Id.ToString();
                tbPokemonId.Enabled = false;
                tbNombre.Text = objPokemonBE.Nombre.ToString();
                tbCategoria.Text = objPokemonBE.Categoria.ToString();
                tbAltura.Text = objPokemonBE.Altura.ToString();
                tbPeso.Text = objPokemonBE.Peso.ToString();
                tbHabilidad.Text = objPokemonBE.Habilidad;
                tbDescripcion.Text = objPokemonBE.Descripcion;
                tbImagen.Text = objPokemonBE.Imagen.ToString();
                pbImagen.LoadAsync(objPokemonBE.Imagen.ToString());
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;


                //De PokTipo, sacar 
                PokemonTipoBC objPokemonTipoBC = new PokemonTipoBC();
                List<int> lstPTipoBE = objPokemonTipoBC.PokemonObtener(PokemonId.Value);

                cbTipo1.Text = objTipoBC.TipoObtener(lstPTipoBE[0]).Nombre;
                OldTipo1 = lstPTipoBE[0];
                OldTipo2 = -1;

                if (lstPTipoBE.Count > 1)
                {
                    cbTipo2.Text = objTipoBC.TipoObtener(lstPTipoBE[1]).Nombre;
                    OldTipo2 = lstPTipoBE[1];
                }


                PokemonDebilidadBC objDebBC = new PokemonDebilidadBC();
                List<int> lstPDebBE = objDebBC.PokemonObtener(PokemonId.Value);
                cbDeb1.Text = objTipoBC.TipoObtener(lstPDebBE[0]).Nombre;
                OldDeb1 = lstPDebBE[0];
                OldDeb2 = -1;
                OldDeb3 = -1;
                OldDeb4 = -1;


                if (lstPDebBE.Count > 1)
                {
                    cbDeb2.Text = objTipoBC.TipoObtener(lstPDebBE[1]).Nombre;
                    OldDeb2 = lstPDebBE[1];

                    if (lstPDebBE.Count > 2)
                    {
                        cbDeb3.Text = objTipoBC.TipoObtener(lstPDebBE[2]).Nombre;
                        OldDeb3 = lstPDebBE[2];

                        if (lstPDebBE.Count > 3)
                        {
                            cbDeb4.Text = objTipoBC.TipoObtener(lstPDebBE[3]).Nombre;
                            OldDeb4 = lstPDebBE[3];
                        }
                    }
                }

            }
            else
            {
                lbTitulo.Text = "Agregar Pokemon";
            }
        }
        private void ComboBoxesGen(ComboBox comboBox, TipoBC objTipoBC)
        {
            comboBox.ValueMember = "Tipo Id";
            comboBox.DisplayMember = "Nombre";
            comboBox.DataSource = objTipoBC.TipoListar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            String strMensaje = PokemonId.HasValue ? "¿Estas seguro de editar el Pokemon?" :
                "¿Éstas seguro de agregar el Pokemon?"; //true and false

            if (MessageBox.Show(strMensaje, "Sistema Pokemon", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PokemonBC objPokemonBC = new PokemonBC();
                PokemonBE objPokemonBE = new PokemonBE();

                objPokemonBE.Nombre = tbNombre.Text;
                objPokemonBE.Categoria = tbCategoria.Text;
                objPokemonBE.Habilidad = tbHabilidad.Text;
                objPokemonBE.Descripcion = tbDescripcion.Text;
                objPokemonBE.Peso = Convert.ToDouble(tbPeso.Text);
                objPokemonBE.Altura = Convert.ToDouble(tbAltura.Text);
                objPokemonBE.Imagen = tbImagen.Text;

                PokemonTipoBC objPokemonTipoBC = new PokemonTipoBC();
                ComboBox[] cbTipos = new ComboBox[] { cbTipo1, cbTipo2 };
                List<PokemonTipoBE> lstPokemonTipoBE = new List<PokemonTipoBE>();
                OldTipos = new List<int?> { OldTipo1, OldTipo2 };


                PokemonDebilidadBC objPokemonDebBC = new PokemonDebilidadBC();
                ComboBox[] cbDebs = new ComboBox[] { cbDeb1, cbDeb2, cbDeb3, cbDeb4 };
                List<PokemonDebilidadBE> lstPokemonDebBE = new List<PokemonDebilidadBE>();
                OldDebs = new List<int?> { OldDeb1, OldDeb2, OldDeb3, OldDeb4 };


                if (PokemonId.HasValue)
                {
                    objPokemonBE.Id = PokemonId.Value;

                    CrearListaPorClase(lstPokemonTipoBE, cbTipos, PokemonId.Value);
                    CrearListaPorClase(lstPokemonDebBE, cbDebs, PokemonId.Value);

                    validarComboBox(lstPokemonTipoBE);
                    validarComboBox(lstPokemonDebBE);

                    objPokemonBC.PokemonEditar(objPokemonBE);
                    objPokemonTipoBC.TipoEditar(lstPokemonTipoBE);
                    objPokemonDebBC.DebilidadEditar(lstPokemonDebBE);

                    strMensaje = "El Pokemon ha sido editado con éxito";
                }
                else
                {
                    int pokemonId = Convert.ToInt32(tbPokemonId.Text);
                    objPokemonBE.Id = Convert.ToInt32(pokemonId);

                    CrearListaPorClase(lstPokemonTipoBE, cbTipos, pokemonId);
                    CrearListaPorClase(lstPokemonDebBE, cbDebs, pokemonId);

                    validarComboBox(lstPokemonTipoBE);
                    validarComboBox(lstPokemonDebBE);

                    objPokemonBC.PokemonInsertar(objPokemonBE);
                    objPokemonTipoBC.TipoInsertar(lstPokemonTipoBE);
                    objPokemonDebBC.DebilidadInsertar(lstPokemonDebBE);

                    strMensaje = "El Pokemon ha sido agregado con éxito";
                }

                MessageBox.Show(strMensaje, "Sistema Pokemon", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                objDelegado();
                this.Close();
            }
        }

        private void CrearListaPorClase<T>(List<T> lst, ComboBox[] cbs, int x)
        {
            int y = 0;
            foreach (ComboBox cb in cbs)
            {
                if (typeof(T) == typeof(PokemonDebilidadBE))
                {
                    PokemonDebilidadBE pd = new PokemonDebilidadBE();
                    pd.IdDebilidad = cb.SelectedIndex + 1;
                    pd.IdPokemon = x;
                    if (PokemonId.HasValue) { pd.OldIdDebilidad = (int)OldDebs.ElementAt(y); }
                    lst.Add((T)(object)pd);
                }
                else if (typeof(T) == typeof(PokemonTipoBE))
                {
                    PokemonTipoBE pt = new PokemonTipoBE();
                    pt.IdTipo = cb.SelectedIndex + 1;
                    pt.IdPokemon = x;
                    if (PokemonId.HasValue) { pt.OldIdTipo = (int)OldTipos.ElementAt(y); }
                    lst.Add((T)(object)pt);
                }
                y++;
            }
        }

        private void validarComboBox<T>(List<T> lst)
        {
            if (lst.FindAll(x => x.Equals(0)).Count() == lst.Count && (typeof(T) == typeof(PokemonDebilidadBE)))
            {
                MessageBox.Show("Ingresar como minimo una debilidad", "Sistema Pokemon", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (lst.FindAll(x => x.Equals(0)).Count() == lst.Count && (typeof(T) == typeof(PokemonTipoBE)))
            {
                MessageBox.Show("Ingresar como minimo un tipo", "Sistema Pokemon", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}

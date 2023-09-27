using Pokedex.BL.BE;
using Pokedex.BL.DALC;

namespace Pokedex.BL.BC
{
    public class PokemonTipoBC
    {
        public List<PokemonTipoBE> TipoListar()
        {
            try
            {
                PokemonTipoDALC objPokemonTipoDALC = new PokemonTipoDALC();
                return objPokemonTipoDALC.PokemonTipoListar();
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new List<PokemonTipoBE>();
            }
        }

        public List<int> PokemonObtener(int PokemonId)
        {
            try
            {
                PokemonTipoDALC objPokemonTipoDALC = new PokemonTipoDALC();
                return objPokemonTipoDALC.PTObtenerPokemon(PokemonId);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new List<int>();
            }
        }

        public bool TipoInsertar(List<PokemonTipoBE> lstPTipoBE)
        {
            try
            {
                PokemonTipoDALC objPokemonTipoDALC = new PokemonTipoDALC();
                return objPokemonTipoDALC.TipoInsertar(lstPTipoBE);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }

        public bool TipoEditar(List<PokemonTipoBE> lstPTipoBE)
        {
            try
            {
                PokemonTipoDALC objPokemonTipoDALC = new PokemonTipoDALC();
                return objPokemonTipoDALC.TipoEditar(lstPTipoBE);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }
    }
}

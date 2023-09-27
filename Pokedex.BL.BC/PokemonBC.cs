using Pokedex.BL.BE;
using Pokedex.BL.DALC;

namespace Pokedex.BL.BC
{
    public class PokemonBC
    {
        public List<PokemonBE> PokemonListar()
        {
            try
            {
                PokemonDALC objPokemonDALC = new PokemonDALC();
                return objPokemonDALC.PokemonListar();
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new List<PokemonBE>();
            }
        }

        public bool PokemonInsertar(PokemonBE objPokemonBE)
        {
            try
            {
                PokemonDALC objPokemonDALC = new PokemonDALC();
                return objPokemonDALC.PokemonInsertar(objPokemonBE);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }

        public bool PokemonEditar(PokemonBE objPokemonBE)
        {
            try
            {
                PokemonDALC objPokemonDALC = new PokemonDALC();
                return objPokemonDALC.PokemonEditar(objPokemonBE);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }

        public bool PokemonEliminar(int Codigo)
        {
            try
            {
                PokemonDALC objPokemonDALC = new PokemonDALC();
                return objPokemonDALC.PokemonEliminar(Codigo);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }


        public PokemonBE PokemonObtener(int PokemonId)
        {
            try
            {
                PokemonDALC objPokemonDALC = new PokemonDALC();
                return objPokemonDALC.PokemonObtener(PokemonId);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new PokemonBE();
            }
        }
    }
}
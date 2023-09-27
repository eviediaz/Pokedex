using Pokedex.BL.BE;
using Pokedex.BL.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.BL.BC
{
    public class PokemonDebilidadBC
    {
        public List<PokemonDebilidadBE> PokemonDebilidadListar()
        {
			try
			{
				PokemonDebilidadDALC objPDebilidadDALC = new PokemonDebilidadDALC();
				return objPDebilidadDALC.PokemonDebilidadListar();
			}
			catch (Exception)
			{
				return new List<PokemonDebilidadBE>();
			}
        }

        public List<int> PokemonObtener(int PokemonId)
        {
            try
            {
                PokemonDebilidadDALC objDebDALC = new PokemonDebilidadDALC();
                return objDebDALC.PDObtenerPokemon(PokemonId);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new List<int>();
            }
        }

        public bool DebilidadInsertar(List<PokemonDebilidadBE> lstPDebilidadBE)
        {
            try
            {
                PokemonDebilidadDALC objPokemonDebilidadDALC = new PokemonDebilidadDALC();
                return objPokemonDebilidadDALC.DebilidadInsertar(lstPDebilidadBE);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }

        public bool DebilidadEditar(List<PokemonDebilidadBE> lstPDebilidadBE)
        {
            try
            {
                PokemonDebilidadDALC objPokemonDebilidadDALC = new PokemonDebilidadDALC();
                return objPokemonDebilidadDALC.DebilidadEditar(lstPDebilidadBE);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return false;
            }
        }
    }
}

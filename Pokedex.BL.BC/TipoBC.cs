using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.BL.BE;
using Pokedex.BL.DALC;

namespace Pokedex.BL.BC
{
    public class TipoBC
    {
        public List<String> TipoListar()
        {
            try
            {
                TipoDALC objTipoDALC = new TipoDALC();
                return objTipoDALC.TipoListar();
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new List<String>();
            }
        }

        public TipoBE TipoObtener(int TipoId)
        {
            try
            {
                TipoDALC objTipoDALC = new TipoDALC();
                return objTipoDALC.TipoObtener(TipoId);
            }
            catch (Exception ex)
            {
                // Guardar log del error
                return new TipoBE();
            }
        }
    }
}

using Microsoft.Data.SqlClient;
using Pokedex.BL.BE;
using System.Data;
using Pokedex.Utils;


namespace Pokedex.BL.DALC
{
    public class PokemonDebilidadDALC
    {
        public List<PokemonDebilidadBE> PokemonDebilidadListar()
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonDebilidadListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                List<PokemonDebilidadBE> LstPokemonDebilidadBE = new List<PokemonDebilidadBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PokemonDebilidadBE objPokemonDebilidadBE = new PokemonDebilidadBE();
                    objPokemonDebilidadBE.IdPokemon = Convert.ToInt32(reader[0]);
                    objPokemonDebilidadBE.IdDebilidad = Convert.ToInt32(reader[1]);
                    LstPokemonDebilidadBE.Add(objPokemonDebilidadBE);
                }
                reader.Close();

                return LstPokemonDebilidadBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<int> PDObtenerPokemon(int Codigo)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPDObtenerPokemon";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                List<int> LstPDipoBE = new List<int>();

                SqlParameter[] arrSqlParameter = new SqlParameter[1];
                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@IdPokemon";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = Codigo;
                Cmd.Parameters.AddRange(arrSqlParameter);

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PokemonDebilidadBE objPokemonDebilidadBE = new PokemonDebilidadBE();
                    objPokemonDebilidadBE.IdDebilidad = Convert.ToInt32(reader[1]);
                    LstPDipoBE.Add(objPokemonDebilidadBE.IdDebilidad);
                }
                reader.Close();

                return LstPDipoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DebilidadEditar(List<PokemonDebilidadBE> lstPDebilidadBE)
        {
            try
            {
                foreach (var lst in lstPDebilidadBE)
                {
                    String strCadenaConexion = Constantes.CadenaEvie;
                    SqlConnection Con = new SqlConnection(strCadenaConexion);
                    String strSP = "uspPokemonDebilidadEditar";
                    SqlCommand Cmd = new SqlCommand(strSP, Con);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] arrSqlParameter = new SqlParameter[3];

                    arrSqlParameter[0] = new SqlParameter();
                    arrSqlParameter[0].ParameterName = "@IdPokemon";
                    arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[0].Value = lst.IdPokemon;

                    arrSqlParameter[1] = new SqlParameter();
                    arrSqlParameter[1].ParameterName = "@IdDebilidad";
                    arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[1].Value = lst.IdDebilidad;

                    arrSqlParameter[2] = new SqlParameter();
                    arrSqlParameter[2].ParameterName = "@OldIdDeb";
                    arrSqlParameter[2].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[2].Value = lst.OldIdDebilidad;

                    Cmd.Parameters.AddRange(arrSqlParameter);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DebilidadInsertar(List<PokemonDebilidadBE> lstPDebilidadBE)
        {
            try
            {
                foreach (var lst in lstPDebilidadBE)
                {
                    String strCadenaConexion = Constantes.CadenaEvie;
                    SqlConnection Con = new SqlConnection(strCadenaConexion);
                    String strSP = "uspPokemonDebilidadInsertar";
                    SqlCommand Cmd = new SqlCommand(strSP, Con);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] arrSqlParameter = new SqlParameter[2];

                    arrSqlParameter[0] = new SqlParameter();
                    arrSqlParameter[0].ParameterName = "@IdPokemon";
                    arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[0].Value = lst.IdPokemon;

                    arrSqlParameter[1] = new SqlParameter();
                    arrSqlParameter[1].ParameterName = "@IdDebilidad";
                    arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[1].Value = lst.IdDebilidad;

                    Cmd.Parameters.AddRange(arrSqlParameter);
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Data;
using Pokedex.BL.BE;
using Microsoft.Data.SqlClient;
using Pokedex.Utils;

namespace Pokedex.BL.DALC
{
    public class PokemonTipoDALC
    {
        public List<PokemonTipoBE> PokemonTipoListar()
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonTipoListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                List<PokemonTipoBE> LstPokemonTipoBE = new List<PokemonTipoBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PokemonTipoBE objPokemonTipoBE = new PokemonTipoBE();
                    objPokemonTipoBE.IdPokemon = Convert.ToInt32(reader[0]);
                    objPokemonTipoBE.IdTipo = Convert.ToInt32(reader[1]);
                    LstPokemonTipoBE.Add(objPokemonTipoBE);
                }
                reader.Close();

                return LstPokemonTipoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<int> PTObtenerPokemon(int Codigo)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPTObtenerPokemon";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                List<int> LstPTipoBE = new List<int>();

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
                    PokemonTipoBE objPokemonTipoBE = new PokemonTipoBE();
                    objPokemonTipoBE.IdTipo = Convert.ToInt32(reader[1]);
                    LstPTipoBE.Add(objPokemonTipoBE.IdTipo);
                }
                reader.Close();

                return LstPTipoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TipoEditar(List<PokemonTipoBE> lstPTipoBE)
        {
            try
            {
                foreach(var lst in lstPTipoBE)
                {
                    String strCadenaConexion = Constantes.CadenaEvie;
                    SqlConnection Con = new SqlConnection(strCadenaConexion);
                    String strSP = "uspPokemonTipoEditar";
                    SqlCommand Cmd = new SqlCommand(strSP, Con);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] arrSqlParameter = new SqlParameter[3];

                    arrSqlParameter[0] = new SqlParameter();
                    arrSqlParameter[0].ParameterName = "@IdPokemon";
                    arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[0].Value = lst.IdPokemon;

                    arrSqlParameter[1] = new SqlParameter();
                    arrSqlParameter[1].ParameterName = "@IdTipo";
                    arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[1].Value = lst.IdTipo;

                    arrSqlParameter[2] = new SqlParameter();
                    arrSqlParameter[2].ParameterName = "@OldIdTipo";
                    arrSqlParameter[2].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[2].Value = lst.OldIdTipo;

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

        public bool TipoInsertar(List<PokemonTipoBE> lstPTipoBE)
        {
            try
            {
                foreach (var lst in lstPTipoBE)
                {
                    String strCadenaConexion = Constantes.CadenaEvie;
                    SqlConnection Con = new SqlConnection(strCadenaConexion);
                    String strSP = "uspPokemonTipoInsertar";
                    SqlCommand Cmd = new SqlCommand(strSP, Con);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] arrSqlParameter = new SqlParameter[2];

                    arrSqlParameter[0] = new SqlParameter();
                    arrSqlParameter[0].ParameterName = "@IdPokemon";
                    arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[0].Value = lst.IdPokemon;

                    arrSqlParameter[1] = new SqlParameter();
                    arrSqlParameter[1].ParameterName = "@IdTipo";
                    arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                    arrSqlParameter[1].Value = lst.IdTipo;

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

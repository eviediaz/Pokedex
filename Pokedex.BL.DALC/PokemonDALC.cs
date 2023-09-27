using System.Data;
using Pokedex.BL.BE;
using Microsoft.Data.SqlClient;
using Pokedex.Utils;

namespace Pokedex.BL.DALC
{
    public class PokemonDALC
    {
        public List<PokemonBE> PokemonListar()
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                List<PokemonBE> LstPokemonBE = new List<PokemonBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PokemonBE objPokemonBE = new PokemonBE();
                    objPokemonBE.Id = Convert.ToInt32(reader[0]);
                    objPokemonBE.Nombre = reader[1].ToString();
                    objPokemonBE.Categoria = reader[2].ToString();
                    objPokemonBE.Peso = Convert.ToDouble(reader[3]);
                    objPokemonBE.Altura = Convert.ToDouble(reader[4]);
                    objPokemonBE.Habilidad = reader[5].ToString();
                    objPokemonBE.Descripcion = reader[6].ToString();
                    objPokemonBE.Imagen = reader[7].ToString();

                    LstPokemonBE.Add(objPokemonBE);
                }
                reader.Close();

                return LstPokemonBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PokemonInsertar(PokemonBE objPokemonBE)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonInsertar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[8];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@Id";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objPokemonBE.Id;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@Nombre";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 100;
                arrSqlParameter[1].Value = objPokemonBE.Nombre;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@Categoria";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 50;
                arrSqlParameter[2].Value = objPokemonBE.Categoria;

                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = "@Peso";
                arrSqlParameter[3].SqlDbType = SqlDbType.Decimal;
                arrSqlParameter[3].Value = objPokemonBE.Peso;

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = "@Altura";
                arrSqlParameter[4].SqlDbType = SqlDbType.Decimal;
                arrSqlParameter[4].Value = objPokemonBE.Altura;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = "@Habilidad";
                arrSqlParameter[5].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[5].Size = 50;
                arrSqlParameter[5].Value = objPokemonBE.Habilidad;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = "@Descripcion";
                arrSqlParameter[6].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[6].Size = 300;
                arrSqlParameter[6].Value = objPokemonBE.Descripcion;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = "@Imagen";
                arrSqlParameter[7].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[7].Size = 500;
                arrSqlParameter[7].Value = objPokemonBE.Imagen;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PokemonEditar(PokemonBE objPokemonBE)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[8];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@Id";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objPokemonBE.Id;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = "@Nombre";
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 100;
                arrSqlParameter[1].Value = objPokemonBE.Nombre;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = "@Categoria";
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 50;
                arrSqlParameter[2].Value = objPokemonBE.Categoria;

                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = "@Peso";
                arrSqlParameter[3].SqlDbType = SqlDbType.Decimal;
                arrSqlParameter[3].Value = objPokemonBE.Peso;

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = "@Altura";
                arrSqlParameter[4].SqlDbType = SqlDbType.Decimal;
                arrSqlParameter[4].Value = objPokemonBE.Altura;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = "@Habilidad";
                arrSqlParameter[5].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[5].Size = 50;
                arrSqlParameter[5].Value = objPokemonBE.Habilidad;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = "@Descripcion";
                arrSqlParameter[6].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[6].Size = 300;
                arrSqlParameter[6].Value = objPokemonBE.Descripcion;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = "@Imagen";
                arrSqlParameter[7].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[7].Size = 500;
                arrSqlParameter[7].Value = objPokemonBE.Imagen;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
          catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PokemonEliminar(int Id)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[1];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@Id";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = Id;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PokemonBE PokemonObtener(int PokemonId)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspPokemonObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] arrSqlParameter = new SqlParameter[1];
                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@Id";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = PokemonId;
                Cmd.Parameters.AddRange(arrSqlParameter);
                PokemonBE objPokemonBE = new PokemonBE();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    objPokemonBE.Id = Convert.ToInt32(reader[0]);
                    objPokemonBE.Nombre = reader[1].ToString();
                    objPokemonBE.Categoria = reader[2].ToString();
                    objPokemonBE.Peso = Convert.ToDouble(reader[3]);
                    objPokemonBE.Altura = Convert.ToDouble(reader[4]);
                    objPokemonBE.Habilidad = reader[5].ToString();
                    objPokemonBE.Descripcion = reader[6].ToString();
                    objPokemonBE.Imagen = reader[7].ToString();
                }
                reader.Close();

                return objPokemonBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
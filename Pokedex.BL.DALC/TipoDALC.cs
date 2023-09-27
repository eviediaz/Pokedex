using Microsoft.Data.SqlClient;
using Pokedex.BL.BE;
using System.Data;
using Pokedex.Utils;


namespace Pokedex.BL.DALC
{
    public class TipoDALC
    {
        public List<String> TipoListar()
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                List<String> LstTipoBE = new List<String>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    TipoBE objTipoBE = new TipoBE();
                    objTipoBE.Nombre = reader[1].ToString();

                    LstTipoBE.Add(objTipoBE.Nombre);
                }
                reader.Close();

                return LstTipoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TipoBE TipoObtener(int TipoId)
        {
            try
            {
                String strCadenaConexion = Constantes.CadenaEvie;
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] arrSqlParameter = new SqlParameter[1];
                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = "@TipoId";
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = TipoId;
                Cmd.Parameters.AddRange(arrSqlParameter);

                TipoBE objTipoBE = new TipoBE();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    objTipoBE.Id = Convert.ToInt32(reader[0]);
                    objTipoBE.Nombre = reader[1].ToString();
                    objTipoBE.Color = reader[2].ToString();
                }
                reader.Close();

                return objTipoBE;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


using RHSCodingClub02.DTO;
using RHSCodingClub02.DTO.Parser;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DAL
{
    public abstract class DALBase
    {
        protected static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["RHSCodingClub"].ConnectionString;
            }
        }

        protected static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        protected static SqlCommand GetStoredProcCommand(string storedProc)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = GetSqlConnection();
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandText = storedProc;
            return sqlCmd;
        }

        protected static int ExecuteNonQuery(SqlCommand sqlCmd)
        {
            return sqlCmd.ExecuteNonQuery();
        }

        protected static T GetDTO<T>(ref SqlCommand sqlCmd) where T : DTOBase
        {
            T currentDTO = null;
            try
            {
                sqlCmd.Connection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    DTOParser baseParser = DTOParserFactory.GetParser(typeof(T));
                    baseParser.PopulateOrdinals(sqlReader);
                    currentDTO = (T)baseParser.PopulateDTO(sqlReader);
                    sqlReader.Close();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlCmd.Connection.Close();
                sqlCmd.Connection.Dispose();
            }
            return currentDTO;
        }

        protected static List<T> GetDTOList<T>(ref SqlCommand sqlCmd) where T : DTOBase
        {
            List<T> dtoList = new List<T>();
            try
            {
                sqlCmd.Connection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    DTOParser baseParser = DTOParserFactory.GetParser(typeof(T));
                    baseParser.PopulateOrdinals(sqlReader);
                    while (sqlReader.Read())
                    {
                        T currentDTO = null;
                        currentDTO = (T)baseParser.PopulateDTO(sqlReader);
                        dtoList.Add(currentDTO);
                    }
                    sqlReader.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlCmd.Connection.Close();
                sqlCmd.Connection.Dispose();
            }

            return dtoList;
        }

        protected static SqlParameter CreateInOutParameter(string parameterName, SqlDbType parameterType)
        {
            SqlParameter currentParameter = new SqlParameter();

            currentParameter.SqlDbType = parameterType;
            currentParameter.ParameterName = parameterName;
            currentParameter.Direction = ParameterDirection.InputOutput;

            return currentParameter;
        }

        protected static SqlParameter CreateInOutParameter(string parameterName, SqlDbType parameterType, int parameterSize)
        {
            SqlParameter currentParameter = new SqlParameter();

            currentParameter.SqlDbType = parameterType;
            currentParameter.ParameterName = parameterName;
            currentParameter.Size = parameterSize;
            currentParameter.Direction = ParameterDirection.InputOutput;

            return currentParameter;
        }
    }
}

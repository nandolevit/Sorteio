using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public enum enumExecutar
    {
        NonQuery,
        Scalar,
        DataTable
    }

    public class Cnx
    {
        MySqlParameterCollection mySqlParameterCollection = new MySqlCommand().Parameters;
        MySqlConnection mCnx;

        public bool Conectar()
        {
            try
            {
                mCnx = new MySqlConnection(StringCnx.Cnx);
                mCnx.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public void AddMySqlParameterCollection(string str, object obj)
        {
            mySqlParameterCollection.AddWithValue(str, obj);
        }

        public object ExecutarComandoMySql(string str, enumExecutar ext)
        {
            using(MySqlCommand cmd = new MySqlCommand(str, mCnx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3600;

                foreach (var pmt in mySqlParameterCollection)
                    cmd.Parameters.Add(pmt);

                try
                {
                    switch (ext)
                    {
                        case enumExecutar.NonQuery:

                            cmd.ExecuteNonQuery();
                            return true;

                        case enumExecutar.Scalar:

                            return Convert.ToInt32(cmd.ExecuteScalar());

                        case enumExecutar.DataTable:

                            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    da.Fill(dt);

                                    if (dt.Rows.Count > 0)
                                        return dt;
                                    else
                                        return null;
                                }
                            }

                        default:
                            return null;
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
                finally
                {
                    mCnx.Dispose();
                    mySqlParameterCollection.Clear();
                }
            }
        }
    }
}

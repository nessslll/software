using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for DBW
/// </summary>
public class DBW
{
    private static string connectionString;
    private static string connectionString2;
    static DBW()
    {
        connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;
        connectionString2 = System.Configuration.ConfigurationManager.ConnectionStrings["conStr2"].ConnectionString;
        //
        // TODO: Add constructor logic here
        //
    }

    public static string getConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["conStr1"].ConnectionString;
    }
    public static string getConnectionString2()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["conStr2"].ConnectionString;
    }

    public static SqlConnection Connection()
    {
        SqlConnection conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();
        }
        catch (Exception)
        {

            return null;
        }

        return conn;
    }

    public static int InsertUpdateAdmin(string Query)
    {
        int RowAffected;
        SqlConnection sqlCon = new SqlConnection(getConnectionString2());
        SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);
        sqlCon.Open();
        RowAffected = sqlCmd.ExecuteNonQuery();
        sqlCon.Close();
        return RowAffected;
    }

    public static int InsertUpdate(string Query)
    {
        int RowAffected;
        SqlConnection sqlCon = new SqlConnection(getConnectionString());
        SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);
        sqlCon.Open();
        RowAffected = sqlCmd.ExecuteNonQuery();
        sqlCon.Close();
        return RowAffected;
    }
    public static int InsertUpdate(string query, SqlParameter[] sParams)
    {
        int RowAffected;
        SqlConnection sqlCon = new SqlConnection(getConnectionString());
        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

        foreach (SqlParameter item in sParams)
        {
            sqlCmd.Parameters.Add(item);
        }
        sqlCon.Open();

        RowAffected = sqlCmd.ExecuteNonQuery();
        sqlCon.Close();
        return RowAffected;
    }
    public static int InsertUpdateByProc(string strcmd, SqlParameter[] sparam)
    {
        int RowAffected;
        SqlConnection sqlCon = new SqlConnection(getConnectionString());
        SqlCommand sqlCmd = new SqlCommand(strcmd, sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter item in sparam)
        {
            sqlCmd.Parameters.Add(item);
        }
        sqlCon.Open();

        RowAffected = sqlCmd.ExecuteNonQuery();
        sqlCon.Close();
        return RowAffected;
    }
    public static DataTable GetDatas(string procName, List<SqlParameter> sqlParameters)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return null;
        }
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = procName;
        cmd.Parameters.AddRange(sqlParameters.ToArray());
        DataTable table = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(table);
        cmd.Connection.Close();
        return table;
    }
    public static int DeleteData(string procName, List<SqlParameter> sqlParameters)
    {
        int rAff = 0;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return -1;
        }
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = procName;
        cmd.Parameters.AddRange(sqlParameters.ToArray());
        rAff = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        return (int)sqlParameters[sqlParameters.Count - 1].Value;
    }
    public static int DeleteData(string sql)
    {
        int rAff = 0;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return -1;
        }
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql;

        rAff = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        return rAff;

    }
    public static DataTable GetDatas(string procName)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return null;
        }
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = procName;

        DataTable table = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(table);
        cmd.Connection.Close();
        return table;
    }
    public static int GetDataCount(string procName, List<SqlParameter> sqlParameters)
    {
        int row = 0;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return -1;
        }
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = procName;
        cmd.Parameters.AddRange(sqlParameters.ToArray());
        row = (int)cmd.ExecuteScalar();
        cmd.Connection.Close();
        return row;
    }
    public static int UpdateData(string procName, List<SqlParameter> sqlParameters)
    {
        int rAff = 0;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return -1;
        }
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = procName;
        cmd.Parameters.AddRange(sqlParameters.ToArray());
        rAff = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        return (int)sqlParameters[sqlParameters.Count - 1].Value; ;
    }
    public static DataTable veriGetir(string query)
    {
        try
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand com = conn.CreateCommand();
            com.CommandText = query;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
        catch
        {
            return new DataTable();
        }
    }
    public static DataTable veriGetiradmin(string query)
    {
        try
        {
            OleDbConnection conn = new OleDbConnection(connectionString2);
            OleDbCommand com = conn.CreateCommand();
            com.CommandText = query;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
        catch
        {
            return new DataTable();
        }
    }
    public static DataTable GetDatasBySql(string sql)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = Connection();
        if (cmd.Connection == null)
        {
            return null;
        }

        cmd.CommandText = sql;

        DataTable table = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(table);
        cmd.Connection.Close();
        return table;
    }

    public static bool icerikGuncelle(string @baslik, string @icerik, int id)
    {

        List<SqlParameter> spParam = new List<SqlParameter>();
        spParam.Add(new SqlParameter("@baslik", baslik));
        spParam.Add(new SqlParameter("@icerik", icerik));
        spParam.Add(new SqlParameter("@id", id));
        int rAff = DBW.UpdateData("icerikGuncelle", spParam);
        if (rAff > 0)
        {
            return true;
        }

        return false;
    }
}

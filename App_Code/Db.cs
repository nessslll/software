using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public static class Db
{

    public static DataTable sqlTable(string sql)
    {
        try
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr1"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                da.Fill(dt);
            }
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable sqlTable(string sql, SqlParameter[] param)
    {
        try
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                da.SelectCommand.Parameters.AddRange(param);
                da.Fill(dt);
            }
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static int sqlKomut(string sql)
    {
        try
        {

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    return cmd.ExecuteNonQuery();
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static int sqlKomut(string sql, SqlParameter[] param)
    {
        try
        {

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddRange(param);
                    return cmd.ExecuteNonQuery();
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static int sqlKomutId(string sql)
    {
        try
        {

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    object id = cmd.ExecuteScalar();
                    return int.Parse(id.ToString());
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static int sqlKomutId(string sql, SqlParameter[] param)
    {
        try
        {

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddRange(param);
                    object id = cmd.ExecuteScalar();
                    return int.Parse(id.ToString());
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
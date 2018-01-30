using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using a_01_carApp.Models;

namespace a_01_carApp.DataAccess
{
    public class DataAccessLayer
    {
        public string InsertData(Account account)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FName", account.FName);
                cmd.Parameters.AddWithValue("@LName", account.LName);
                cmd.Parameters.AddWithValue("@Query", 1);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch (global::System.Exception)
            {
                result = "";
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public string UpdateData(Account account)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Account", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", account.Id);
                cmd.Parameters.AddWithValue("@FName", account.FName);
                cmd.Parameters.AddWithValue("@LName", account.LName);
                cmd.Parameters.AddWithValue("@Query", 2);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                result = "";
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public string DeleteData(Account account)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Account", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", account.Id);
                cmd.Parameters.AddWithValue("@FName", account.FName);
                cmd.Parameters.AddWithValue("@LName", account.LName);
                cmd.Parameters.AddWithValue("@Query", 3);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                result = "";
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Account> SelectAllData()
        {
            SqlConnection con = null;
            DataSet ds = null;
            List<Account> accountList = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Account", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", null);
                cmd.Parameters.AddWithValue("@FName", null);
                cmd.Parameters.AddWithValue("@LName", null);
                cmd.Parameters.AddWithValue("@Query", 4);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                accountList = new List<Account>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Account account = new Account();
                    account.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"].ToString());
                    account.FName = ds.Tables[0].Rows[i]["FName"].ToString();
                    account.LName = ds.Tables[0].Rows[i]["LName"].ToString();
                    
                    accountList.Add(account);
                }
                return accountList;
            }
            catch
            {
                return accountList;
            }
            finally
            {
                con.Close();
            }
        }

        public Account SelectDataById(string AccountId)
        {
            SqlConnection con = null;
            DataSet ds = null;
            Account account = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Account", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", AccountId);
                cmd.Parameters.AddWithValue("@FName", null);
                cmd.Parameters.AddWithValue("@LName", null);
                cmd.Parameters.AddWithValue("@Query", 5);
          
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    account = new Account();
                    account.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"].ToString());
                    account.FName = ds.Tables[0].Rows[i]["FName"].ToString();
                    account.LName = ds.Tables[0].Rows[i]["LastName"].ToString();
                }
                return account;
            }
            catch
            {
                return account;
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
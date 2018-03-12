using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using a_01_carApp.Models;
using a_01_carApp.Models.Invoices;

namespace a_01_carApp.DataAccess
{
    public class InvoicesDataAccess
    {
        public List<Invoice> SelectAllInvoices()
        {
            SqlConnection con = null;
            List<Invoice> invoiceList = null;
            DataSet ds = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandText = "SELECT * FROM Invoices";

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                invoiceList = new List<Invoice>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Invoice invoice = new Invoice();
                    invoice.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"].ToString());
                    invoice.Details = ds.Tables[0].Rows[i]["Details"].ToString();
                    invoice.DateBilled = ds.Tables[0].Rows[i]["DateBilled"].ToString().AsDateTime();
                    invoice.PaymentDateReceived = ds.Tables[0].Rows[i]["PaymentDateReceived"].ToString().AsDateTime();
                    invoice.PaymentDateDue = ds.Tables[0].Rows[i]["PaymentDateDue"].ToString().AsDateTime();
                    invoice.InvoiceNumber = ds.Tables[0].Rows[i]["InvoiceNumber"].ToString();
                    invoice.InvoiceGross = Convert.ToDouble(ds.Tables[0].Rows[i]["InvoiceGross"].ToString());
                    invoice.CreditTotal = Convert.ToDouble(ds.Tables[0].Rows[i]["CreditTotal"].ToString());
                    invoice.TaxTotal = Convert.ToDouble(ds.Tables[0].Rows[i]["TaxTotal"].ToString());
                    invoice.PaymentReceived = Convert.ToDouble(ds.Tables[0].Rows[i]["PaymentReceived"].ToString());
                    invoice.CustomerId = Convert.ToInt32(ds.Tables[0].Rows[i]["CustomerId"].ToString());

                    invoiceList.Add(invoice);
                }
                invoiceList = invoiceList.OrderBy(a => a.PaymentDateDue).ToList();
                return invoiceList;
            }
            catch
            {
                return invoiceList;
            }
            finally
            {
                con.Close();
            }
        }

        public string InsertInvoice(Invoice invoice)
        {
            SqlConnection con = null;
            string result = "";

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["AutoAppConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandText = "INSERT INTO Invoices " +
                                  "(Details, DateBilled, PaymentDateReceived, PaymentDateDue, InvoiceNumber, InvoiceGross, CreditTotal, TaxTotal, PaymentReceived, CustomerId) " +
                                  "VALUES (@Details, @DateBilled, @PaymentDateReceived, @PaymentDateDue, @InvoiceNumber, @InvoiceGross, @CreditTotal, @TaxTotal, @PaymentReceived, @CustomerId)";
                cmd.Parameters.AddWithValue("@Details", invoice.Details);
                cmd.Parameters.AddWithValue("@DateBilled", invoice.DateBilled);
                cmd.Parameters.AddWithValue("@PaymentDateReceived", invoice.PaymentDateReceived);
                cmd.Parameters.AddWithValue("@PaymentDateDue", invoice.PaymentDateDue);
                cmd.Parameters.AddWithValue("@InvoiceNumber", invoice.InvoiceNumber);
                cmd.Parameters.AddWithValue("@InvoiceGross", invoice.InvoiceGross);
                cmd.Parameters.AddWithValue("@CreditTotal", invoice.CreditTotal);
                cmd.Parameters.AddWithValue("@TaxTotal", invoice.TaxTotal);
                cmd.Parameters.AddWithValue("@PaymentReceived", invoice.PaymentReceived);
                cmd.Parameters.AddWithValue("@CustomerId", invoice.CustomerId);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return "Error in insert";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
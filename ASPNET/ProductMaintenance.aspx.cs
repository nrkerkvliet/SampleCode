using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsPro.Administration
{
    public partial class ProductMaintenance : System.Web.UI.Page
    {
        protected void GridView1_PreRender(object sender, EventArgs e)
        {
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var parameters = SqlDataSource1.InsertParameters;
                parameters["ProductCode"].DefaultValue = txtCode.Text;
                parameters["Name"].DefaultValue = txtName.Text;
                parameters["Version"].DefaultValue = txtVersion.Text;
                parameters["ReleaseDate"].DefaultValue = txtRelease.Text;

                try
                {
                    SqlDataSource1.Insert();
                    txtCode.Text = "";
                    txtName.Text = "";
                    txtVersion.Text = "";
                    txtRelease.Text = "";
                }
                catch (Exception ex)
                {
                    lblMsg.Text = DatabaseErrorMessage(ex.Message);
                }
            }
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            if (e.Exception != null)
            {
                lblMsg.Text = DatabaseErrorMessage(e.Exception.Message);
                e.ExceptionHandled = true;
                e.KeepInEditMode = true;
            }
            else if (e.AffectedRows == 0)
            {
                lblMsg.Text = ConcurrencyErrorMessage();
            }
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            if (e.Exception != null)
            {
                lblMsg.Text = DatabaseErrorMessage(e.Exception.Message);
                e.ExceptionHandled = true;
            }
            else if (e.AffectedRows == 0)
            {
                lblMsg.Text = ConcurrencyErrorMessage();
            }
        }

        private string DatabaseErrorMessage(string errorMsg)
        {
            return $"<b>A database error has occurred:</b> {errorMsg}";
        }

        private string ConcurrencyErrorMessage()
        {
            return "Another user may have updated that Product. " + "Please try again";
        }
    }
}
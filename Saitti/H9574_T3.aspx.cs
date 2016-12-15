using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class H9574_T3 : System.Web.UI.Page
{
    //protected static DemoxOy ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        FillControls();
    }

    protected void FillControls()
    {
        //dropdownlist
        //var retval = ctx.Customers;
        //var retval = from c in ctx.Customers
        //             orderby c.lastname
        //             select c;
        //sama lambda tyylillä
        /*var retval = ctx.Customers.OrderBy(x => x.lastname);
        ddlCustomers.DataSource = retval.ToList();
        ddlCustomers.DataTextField = "lastname";
        ddlCustomers.DataValueField = "id";
        ddlCustomers.DataBind();
        //lisätään tyhjä alkio ddl:ään
        ddlCustomers.Items.Insert(0, string.Empty);
        //CRUDia varten
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        //SetButtons();*/
    }

    protected void btnTestingConnection_Click(object sender, EventArgs e)
    {
        try
        {

        }
        catch (InvalidCastException)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Tietokantayhteys epäonnistui');", true);
        }
    }
}
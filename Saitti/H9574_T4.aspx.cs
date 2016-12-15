using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class H9574_T4 : System.Web.UI.Page
{
    string RockoXML;
    protected void Page_Load(object sender, EventArgs e)
    {
        //luetaan web.configista xml-tiedoston nimi
        RockoXML = ConfigurationManager.AppSettings["tiedosto"];
        lblMessage.Text = RockoXML;
    }


    protected void btnHaeKaikki_Click(object sender, EventArgs e)
    {
        //luetaan xml-tiedostosta tiedot ja esitetään ne GridViewssä
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        //Jostain syystä testaaminen epäonnistuu, koska oikeudet ei riitä xml filun katseluun...
        ds.ReadXml(Server.MapPath(RockoXML));
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        //datan sitominen ui-kontrolliin
        gvData.DataSource = dv;
        gvData.DataBind();
        lblMessage.Text = string.Format("Löytyi {0} levyä", dt.Rows.Count);
    }

    protected void btnHaeArtisti_Click(object sender, EventArgs e)
    {

    }
}
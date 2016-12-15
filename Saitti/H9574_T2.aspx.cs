using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class H9574_T2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Täytetään dropbox
            PopulateDDL();
            //kuvan esikatselu valittuna
            
            string filename = DDLpicture.SelectedItem.Text;
            Image.ImageUrl = "~/Pictures/" + Path.GetFileName(filename);
        }
        catch (Exception ex)
        {
            myLabel.Text = ex.Message;
        }
    }
    public void PopulateDDL()
    {
        //Tiedon hakeminen
        try
        {
            List<String> photos = new List<string>();
            string photosPath = MapPath("~/Pictures");
            string[] files = Directory.GetFiles(photosPath);
            int i = 0;
            foreach (var filename in files)
            {
                DDLpicture.Items.Insert(i, new ListItem(Path.GetFileName(filename)));
                i = i + 1;
            }
            //Tiedon sitominen
            DDLpicture.DataBind();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    protected void DDLpicture_SelectedIndexChanged(object sender, EventArgs e)
    {
        string filename = DDLpicture.SelectedItem.Text;
        Image.ImageUrl = "~/Pictures/" + Path.GetFileName(filename);
        //Response.Redirect(Request.RawUrl);
    }
}
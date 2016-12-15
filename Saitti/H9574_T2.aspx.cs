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
            //Bind photos to Repeater
            //Repeater1.DataSource = GetPhotos();
            //Repeater1.DataBind();

            //kuvan esikatselu
            string filename = DDLpicture.SelectedItem.Text;
            Image.ImageUrl = "~/Pictures/" + Path.GetFileName(filename);
            Response.Redirect(Request.RawUrl);
        }
        catch (Exception ex)
        {
            myLabel.Text = ex.Message;
        }
    }
    protected List<String> GetPhotos()
    {
        try
        {
            List<String> photos = new List<string>();
            string photosPath = MapPath("~/Pictures");
            string[] files = Directory.GetFiles(photosPath);
            foreach (var filename in files)
            {
                photos.Add("~/Pictures/" + Path.GetFileName(filename));
            }
            return photos;
        }
        catch (Exception ex)
        {
            throw;
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
            foreach (var filename in files)
            {
                DDLpicture.Items.Insert(0, new ListItem(Path.GetFileName(filename)));
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
        Image image = this.Kuva;
        image.ImageUrl = ((DropDownList)sender).SelectedValue;
    }
}
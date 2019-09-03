using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shipping : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        if (!this.IsPostBack)
        {
            //set Province options
            Province.Items.Add("Province");
            Province.Items.Add("British Columbia");
            Province.Items.Add("Alberta");
            Province.Items.Add("Saskatchewan");
            Province.Items.Add("Manitoba");
            Province.Items.Add("Ontario");
            Province.Items.Add("Quebec");
            Province.Items.Add("New Brunswick");
            Province.Items.Add("Price Edward Island");
            Province.Items.Add("Nova Scotia");
            Province.Items.Add("Newfoundland & Labrador");
        }
    }

    protected void OnSubmit_Click(object sender, EventArgs e)
    {

        Session["firstName"] = FirstName.Text;

        Response.Redirect("ThankYou.aspx"); 
    }
}
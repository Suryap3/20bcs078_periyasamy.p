using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace website
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {

           
             Response.Redirect("home.aspx", true);
 
             //For wrong login
             // ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('SORRY','LOGIN FAILED','warning')", true);
 
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home
{
    public partial class ClerkHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Response.Cookies["Login"] != null)
            {
                //lbs_status.Text = Request.Cookies["Login"]["password"];
                //string temp = Session["str"].ToString();
                 //Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", temp, true);
            }
            else
            {
                Response.Redirect("ClerkLogin.aspx");
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("login");
            cook.Expires = DateTime.Now.AddMinutes(-1);
            Response.Cookies.Add(cook);
            Response.Redirect("Clerklogin.aspx");
        }
    }
}
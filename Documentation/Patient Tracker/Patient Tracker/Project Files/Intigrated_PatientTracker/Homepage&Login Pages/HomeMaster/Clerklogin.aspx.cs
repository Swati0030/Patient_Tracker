using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BEL;

namespace HomeMaster
{
    public partial class Clerklogin : System.Web.UI.Page
    {
        Clerklogin_BEL belclogin = new Clerklogin_BEL();
        Clerklogin_BLL bllclogin = new Clerklogin_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack) {
               
            //}
        }

        protected void Btn_ClerkLogin_Click(object sender, EventArgs e)
        {
            belclogin.UserId = Txt_Userid.Text.Trim();
            belclogin._Pass = Txt_Password.Text.Trim();
            belclogin.UserType = Txt_UserType.Text.Trim();
            try
            {
                int result = bllclogin.Clerklogin(belclogin);
                if (result >0)
                {
                    Response.Redirect("ClerkHome.aspx");
                }
                else 
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Invalid Username/Password');", true);
                    //lbl_Status.Text = "Invalid Username/Password";
                    
                }
            }
            catch(Exception ex)          
            {                
            Response.Write("Oops! error occured :" +
            ex.Message.ToString());
            }
            belclogin = null;
            bllclogin = null;        
        }
    }
}
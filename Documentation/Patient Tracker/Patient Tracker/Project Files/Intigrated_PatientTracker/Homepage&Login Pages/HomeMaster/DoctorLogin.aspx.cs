using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEL;
using BLL;

namespace HomeMaster
{
    public partial class DoctorLogin : System.Web.UI.Page
    {
        Doctorlogin_BEL beldlogin = new Doctorlogin_BEL();
        Doctorlogin_BLL blldlogin = new Doctorlogin_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_DoctorLogin_Click(object sender, EventArgs e)
        {
            beldlogin.Userid = Txt_Userid.Text.Trim();
            beldlogin.Password = Txt_Password.Text.Trim();
            beldlogin.UserType = Txt_UserType.Text.Trim();
            try
            {

                int result = blldlogin.Doctorlogin(beldlogin);

                if (result ==1)
                {
                    //HttpCookie cook = new HttpCookie("Login");
                    Session["Id"] = Txt_Userid.Text;
                    //cook["password"] = Txt_Password.Text;
                    //cook.Expires = DateTime.Now.AddMinutes(1);
                    //Response.Cookies.Add(cook);
                    Response.Redirect("Doctorhome.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Login Failed. Please check Username / Password')", true);

                }



            }
            catch (Exception ex)
            {

                Response.Write("Oops! error occured :" +
                ex.Message.ToString());
            }
            beldlogin = null;
            blldlogin = null;

        }
    }
}
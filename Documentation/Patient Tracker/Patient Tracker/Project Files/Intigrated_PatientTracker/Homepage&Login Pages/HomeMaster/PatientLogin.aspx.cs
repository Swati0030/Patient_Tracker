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
    public partial class PatientLogin : System.Web.UI.Page
    {
        Patientlogin_BEL plogin = new Patientlogin_BEL();
        Patientlogin_BLL ploginbll = new Patientlogin_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Btn_PatientLogin_Click(object sender, EventArgs e)
        {
            plogin.Userid = Txt_UserName.Text.Trim();
            plogin.Password = Txt_Password.Text.Trim();
            plogin.UserType = Txt_UserType.Text.Trim();
            int result = ploginbll.PatientLogin(plogin);
            if (result == 1)
            {
                Session["Id"] = Txt_UserName.Text;
                Response.Redirect("PatientHome.aspx");
                //Response.Redirect("PatientHome1.aspx?id="+Txt_UserName.Text);
            }
            else
            {
                Lbl_status.Text="Invalid Username and password";
            }
        }
    }
}
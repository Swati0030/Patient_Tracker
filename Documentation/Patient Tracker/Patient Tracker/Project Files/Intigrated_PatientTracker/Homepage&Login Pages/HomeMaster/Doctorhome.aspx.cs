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
    public partial class Doctorhome : System.Web.UI.Page
    {
        Doctorhome_BEL dhbel = new Doctorhome_BEL();
        Doctorhome_BLL dhbll = new Doctorhome_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                dhbel.Doctorid= Session["Id"].ToString();
                string name = dhbll.getname_bll(dhbel);
                Lbl_Load.Text = "Welcome "+"Dr."+name.ToUpper();
            }           
        }

        protected void Btn_viewhistory_Click(object sender, EventArgs e)
        {
            dhbel.Patientid = Txt_Patientid.Text.Trim();
            int r=dhbll.check_bll(dhbel);
            if (r==1)
            {
                //int o=dhbll.regpatient_bll(dhbel);
                //if (o > 0)
                //{
                    Session["PId"] = Txt_Patientid.Text.Trim();
                    Session["Id"] = dhbel.Doctorid;
                    Response.Redirect("Consultationhistory.aspx");
                //}
                //else
                //{
                //    Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('No Records Found For Given Patientid');", true);
                //}
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Not a Registered Patient');", true);
            }
        }

        protected void Btn_prescription_Click(object sender, EventArgs e)
        {
            dhbel.Patientid = Txt_Patientid.Text.Trim();
            int r = dhbll.check_bll(dhbel);
            if (r==1)
            {
            Session["PId"] = Txt_Patientid.Text.Trim();
            Session["Id"] = dhbel.Doctorid;
            Response.Redirect("PrescriptionPage.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Not a Registered Patient');", true);
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("Id");
            Session.RemoveAll();
            Response.Redirect("DoctorLogin.aspx");
        }

    }
}
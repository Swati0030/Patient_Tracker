using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEL_Docregistration;
using BLL_Docregistration;

namespace HomeMaster
{
    public partial class DoctorRegistration1 : System.Web.UI.Page
    {
        Docregistration_BEL objdoctorregBEL = new Docregistration_BEL();
        Docregistration_BLL objdoctorregBLL = new Docregistration_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            //objdoctorregBEL._doctorid = Txt_Doctorid.Text.Trim();
            //Response.Write(Txt_Doctorid.Text);
            objdoctorregBEL._doctorname = Txt_DoctorName.Text.Trim();
            objdoctorregBEL._qualification = DDL_Qualification.Text.Trim();
            objdoctorregBEL._age = Convert.ToInt32(Txt_Age.Text.ToString().Trim());
            objdoctorregBEL._address = Txt_Address.Text.Trim();
            //if (Convert.ToInt32(Txt_Experience.Text) > 3)
            //{

            objdoctorregBEL._experience = Convert.ToInt32(Txt_Experience.Text.Trim());
            //}
            //else
            //{
            //    Txt_Experience.Text = "Wrong";
            //}
            objdoctorregBEL._contactnumber = double.Parse(Txt_ContactNumber.Text.ToString().Trim());
            objdoctorregBEL._emailid = Txt_Emailid.Text.Trim();
            //objdoctorregBEL._password = Txt_Password.Text.Trim();
            objdoctorregBEL._usertype = Txt_UserType.Text.Trim();
            string s = Txt_DoctorName.Text.Trim();
            string c = Txt_ContactNumber.Text.Trim();
            string q = DDL_Qualification.Text.Trim();
            string doctorid = string.Empty;
            string password = string.Empty;
            doctorid = "D" + s.Substring(0, 3) + c.Substring(0, 4);
            password = "D" + q + c.Substring(6, 4);
            objdoctorregBEL._doctorid = doctorid;
            objdoctorregBEL._password = password;
            int result = objdoctorregBLL.doctorregistration(objdoctorregBEL);
            if (result != 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Doctor details Registered successfully.');", true);
                Lbl_Status1.Text = "Please Note down the Doctor Id and Password" + "<br>" + "<br>" + "Doctor Id:   " + doctorid + "<br>" + "<br>" + "Password:   " + password;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Doctor already exists.Try Again');", true);
            }
        }
    }
}
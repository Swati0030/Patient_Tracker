using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEL_PatientRegistration;
using BLL_PatientRegistration;

namespace HomeMaster
{
    public partial class PatientRegistration : System.Web.UI.Page
    {
        PatientRegistration_BEL belpregistration = new PatientRegistration_BEL();
        PatientRegistration_BLL bllpregistration = new PatientRegistration_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            belpregistration.Patientname = Txt_PatientName.Text.Trim();
            belpregistration.Patientage = Convert.ToInt32(Txt_Age.Text.Trim());
            belpregistration.Patientaddress = Txt_PatientName.Text.Trim();
            belpregistration.Patientaddress = Txt_PatientAddress.Text.Trim();
            belpregistration.Patientcontactnumber = double.Parse(Txt_PatientContactNumber.Text.Trim());
            belpregistration.Emailid = Txt_Emailid.Text.Trim();
            belpregistration.Gender = DDL_Gender.Text.Trim();
            string s = Txt_PatientName.Text.Trim();
            string c = Txt_PatientContactNumber.Text.Trim();
            int l = s.Length;
            string userid = "P" + s.Substring(0, 3) + c.Substring(6, 4);
            string password = "$" + s.Substring((l - 3), 3) + c.Substring(6, 4);
            belpregistration.Patientid = userid;
            belpregistration.Password = password;
            belpregistration.Usertype = "Patient";
            int result = bllpregistration.Patientregistration(belpregistration);
            if (result > 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Patient Registered successfully. Please Note down the Patient Number and Password.');", true);
                Lbl_Result.Text = "Patient Id:  " + userid + "</br>" +"</br>"+ "Password:  " + password;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('User already Registered.Try again.');", true);
            }
        }

       
    }
}
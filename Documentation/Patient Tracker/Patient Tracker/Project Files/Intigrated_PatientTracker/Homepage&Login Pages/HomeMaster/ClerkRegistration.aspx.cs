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
    public partial class Clerk : System.Web.UI.Page
    {

        Clerkregistration_BLL objclerkregBLL = new Clerkregistration_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                //Btn_Register.Enabled = false;
            }
            
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Clerkregistration_BEL objclerkregBEL = new Clerkregistration_BEL();
            //objclerkregBEL._clerkid = Txt_Clerkid.Text.Trim();
            //objclerkregBEL._userid = Txt_Clerkid.Text.Trim();
            //Response.Write(Txt_Clerkid.Text);
            objclerkregBEL._clerkname = Txt_ClerkName.Text.Trim();
            objclerkregBEL._age = Convert.ToInt32(Txt_Age.Text.ToString().Trim());
            objclerkregBEL._address = Txt_Address.Text.Trim();
            objclerkregBEL._contactnumber = double.Parse(Txt_ContactNumber.Text.ToString().Trim());
            //objclerkregBEL._password = Txt_Password.Text.Trim();
            objclerkregBEL._doj = Convert.ToDateTime(Txt_DateOfJoining.Text.Trim());
            objclerkregBEL._emailid = Txt_Emailid.Text.Trim();
            //Response.Write(Txt_Clerkid.Text+Txt_ClerkName.Text);
            
            //string s = Txt_ClerkName.Text.Trim();
            //int l=s.Length;
            //string n=Txt_ContactNumber.Text.ToString().Trim();
            //int i=n.Length;
            //string c ="C"+n.Substring(0,4)+s.Substring(0,3);
            //objclerkregBEL._clerkid = c;
            objclerkregBEL._usertype = Txt_UserType.Text.Trim();
           string s=Txt_ClerkName.Text.Trim();
            int l=s.Length;
            string c=Txt_ContactNumber.Text.Trim();
            int l1=c.Length;
            string clerkid="C"+c.Substring(0,4)+s.Substring(0,3);
            string password="#"+s.Substring((l-3),3)+c.Substring((l1-4),4);
            objclerkregBEL._clerkid=clerkid;
            objclerkregBEL._password=password;
            objclerkregBEL._usertype="Clerk";


            int result = objclerkregBLL.clerkregistraion(objclerkregBEL);

            if (result != 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Your account has been created successfully!');", true);
                //lblStatus.Text = "Your account has been created successfully!";
                lblStatus1.Text = "Clerk Id :   "+ clerkid + "</br>"+"</br>"+"Password :   " + password;
                //Response.Redirect("ClerkLogin.aspx");
                Btn_Register.Enabled = false;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Error in creating your account. Please try again, later.');", true);
                //lblStatus.Text = "Error in creating your account. Please try again, later.";

            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Txt_DateOfJoining.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");
            Calendar1.Visible = false;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        
    }
}
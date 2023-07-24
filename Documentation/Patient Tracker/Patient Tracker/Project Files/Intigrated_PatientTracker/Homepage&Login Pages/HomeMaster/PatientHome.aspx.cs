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
    public partial class PatientHome : System.Web.UI.Page
    {
        Patienthome_BEL phbel = new Patienthome_BEL();
        Patienthome_BLL phbll = new Patienthome_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                phbel.Patientid = Session["Id"].ToString();
                int result=phbll.feedback_bll(phbel);
                if (result > 0)
                {
                    //Panel1.Visible = true;
                    Txt_Prescriptionid.Text = phbel.Prescriptionid;
                    Txt_ConsultationDate.Text = phbel.Consultationdate;
                    Txt_DoctorName.Text = phbel.Doctorname;
                    Txt_ProblemDescription.Text = phbel.Problemdesc;
                }
                else
                {
                    Txt_Prescriptionid.Visible = false;
                    Txt_ConsultationDate.Visible = false;
                    Txt_DoctorName.Visible = false;
                    Txt_ProblemDescription.Visible = false;
                    Txt_AdditionalNotes.Visible = false;

                    Lbl_Prescriptionid.Visible = false;
                    Lbl_consultationdate.Visible = false;
                    Lbl_DoctorName.Visible = false;
                    Lbl_ProblemDescription.Visible = false;
                    Btn_SubmitFeedback.Visible = false;
                    Btn_viewhistory.Visible = false;
                    Lbl_AdditionalNotes.Visible = false;

                    Lbl_State.Text = "New User"+ "</br>"+"No Data Found for This User";
                }
            }
        }

        protected void Btn_SubmitFeedback_Click(object sender, EventArgs e)
        {
            phbel.Additionalnotes = Txt_AdditionalNotes.Text;
            int r = phbll.submitfeedback_bll(phbel);
            if (r > 0)
            {
                Lbl_Status.Text = "Feedback Submitted Successfully";
                Btn_SubmitFeedback.Enabled = false;
            }
        }

        protected void Btn_viewhistory_Click(object sender, EventArgs e)
        {
            Session["Id"] = phbel.Patientid;
            Response.Redirect("PatientHistory.aspx");
        }

        protected void Btn_Logout1_Click(object sender, EventArgs e)
        {
            Session.Remove("Id");
            Session.RemoveAll();
            Response.Redirect("Patientlogin.aspx");
        }
    }
}
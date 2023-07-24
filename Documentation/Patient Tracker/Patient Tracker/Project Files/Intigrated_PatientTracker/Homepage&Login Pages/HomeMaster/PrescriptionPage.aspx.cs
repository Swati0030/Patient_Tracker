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
    public partial class PrescriptionPage : System.Web.UI.Page
    {
        Doctorhome_BEL dhbel = new Doctorhome_BEL();
        Doctorhome_BLL dhbll = new Doctorhome_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar_Prescription.Visible = false;
                Calendar_NextDate.Visible = false;
                //if (Session["Id"] != null && Session["PId"] != null)
                //{
                dhbel.Patientid = Session["PId"].ToString();
                dhbel.Doctorid = Session["Id"].ToString();
                Txt_Patientid.Text = dhbel.Patientid;
                Txt_Doctorid.Text = dhbel.Doctorid;
                //c = dhbll.consultationid_bll();
                //c++;
                    Txt_Consultationid.Text =  dhbll.consultationid_bll().ToString();
                    Response.Write(Txt_Consultationid.Text);
                   // p = dhbll.prescriptionnumber_bll(dhbel);
                   // p++;
                    Txt_PrescriptionNumber.Text = dhbll.prescriptionnumber_bll(dhbel).ToString();
                    Txt_Prescriptionid.Text = "PN" + dhbel.Patientid.ToString();
                    Txt_Consultationdate.Text = DateTime.Today.ToString("MM/dd/yyyy");
                    Txt_timeofvisit.Text = DateTime.Now.ToString("HH:mm");
                //}
                //else
                //Response.Write("dltyktyd");
            }
        }

        protected void Btn_Createprescription_Click(object sender, EventArgs e)
        {
            dhbel.Patientid = Txt_Patientid.Text.Trim();
            dhbel.Nextconsultationdate = Convert.ToDateTime(Txt_NextConsultationDate.Text.Trim());
            dhbel.Patientnumber = Convert.ToInt64(Txt_PatientNumber.Text.Trim());
            dhbel.Prescribedmedicinename = Txt_PrescribedMedicineName.Text.Trim();
            dhbel.Prescriptiondate = Convert.ToDateTime(Txt_PrescriptionDate.Text.Trim());
            dhbel.Prescriptionid = Txt_Prescriptionid.Text.Trim();
            dhbel.Prescriptionnumber = Convert.ToInt32(Txt_PrescriptionNumber.Text.Trim());
            dhbel.Problemdescription = Txt_ProblemDescription.Text.Trim();
            dhbel.Quantitytopurchase = Txt_QuantityToPurchase.Text.Trim();
            dhbel.Durationtocontinuemedicine = Convert.ToInt32(Txt_DurationToContinue.Text.Trim());
            dhbel.Dosage =Convert.ToInt32(Txt_Dosage.Text.Trim());
            dhbel.Doctorid = Txt_Doctorid.Text.Trim();
            dhbel.Consultationid = Txt_Consultationid.Text.Trim();
            dhbel.Alternatemedicinename = Txt_AlternateMedicineName.Text.Trim();
            dhbel.Additionalnotes = Txt_AdditionalNotes.Text.Trim();
            dhbel.Consultationdate =Convert.ToDateTime(Txt_Consultationdate.Text.Trim());
            try
            {

              long result = dhbll.createprescription_bll(dhbel);

                if (result == 1)
                {
                    Response.Redirect("Doctorhome.aspx");
                }
                else
                {
                    Response.Write(result);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Oops! error occured :" +
                ex.Message.ToString());
            }
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("Id");
            Session.Remove("Pid");
            Session.RemoveAll();
            Response.Redirect("DoctorLogin.aspx");
        }

        protected void Calendar_NextDate_SelectionChanged(object sender, EventArgs e)
        {
             Txt_NextConsultationDate.Text = Calendar_NextDate.SelectedDate.ToString("MM/dd/yyyy");
            Calendar_NextDate.Visible = false;
        }

        protected void ImageButton_NextDate_Click(object sender, ImageClickEventArgs e)
        {
             if (Calendar_NextDate.Visible)
            {
                Calendar_NextDate.Visible = false;
            }
            else
            {
                Calendar_NextDate.Visible = true;
            }
        }

        protected void Calendar_Prescription_SelectionChanged(object sender, EventArgs e)
        {
            Txt_PrescriptionDate.Text = Calendar_Prescription.SelectedDate.ToString("MM/dd/yyyy");
            Calendar_Prescription.Visible = false;
        }

        protected void ImageButton_Prescription_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar_Prescription.Visible)
            {
                Calendar_Prescription.Visible = false;
            }
            else
            {
                Calendar_Prescription.Visible = true;
            }
        }

        protected void Calendar_Prescription_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.Date<DateTime.Today.Date)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ForeColor = System.Drawing.Color.White;
            }
        }

        protected void Calendar_NextDate_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Today.Date)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ForeColor = System.Drawing.Color.White;
            }
        }

        

        
        }

       
    }

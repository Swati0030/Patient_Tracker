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
    public partial class BillGeneration : System.Web.UI.Page
    {
        BillGeneration_BEL bgenbel = new BillGeneration_BEL();
        BillGeneration_BLL bgenbll = new BillGeneration_BLL();
        int sum = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                Panel2.Visible = false;
                Txt_TotalCost.Text = sum.ToString();
            }
           
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
         
            bgenbel.Patientid = Txt_Patientid.Text.Trim();
            try
            {
                int i=bgenbll.bllpid(bgenbel);

                if (i == 1)
                {
                    Panel2.Visible = true;
                    Txt_DoctorName.Text = bgenbel.Doctorname;
                    Txt_ConsultationDate.Text = bgenbel.Consultationdate;
                    Txt_Doctorid.Text = bgenbel.Doctorid;
                    Txt_DateOfPrescription.Text = bgenbel.Dateofprescription;
                    Txt_Medicineid.Text = bgenbel.Medicineid;
                    Txt_PatientNumber.Text = bgenbel.Patientnumber;
                    Txt_PrescriptionNumber.Text = bgenbel.Prescriptionnumber;
                    Txt_QuantityToConsume.Text = bgenbel.Quantocon;
                    Txt_NextConsultationDate.Text = bgenbel.Nextconsuldate;

                }
                else
                 {

                     Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('No Data found!!');", true);
                     Panel2.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void Btn_GenerateBill_Click(object sender, EventArgs e)
        {
            int result = 0;
            bgenbel.Patientid = Txt_Patientid.Text.Trim();
            bgenbel.Doctorname = Txt_DoctorName.Text.Trim();
            bgenbel.Consultationdate = Txt_ConsultationDate.Text.Trim();
            bgenbel.Prescriptionnumber = Txt_PrescriptionNumber.Text.Trim();
            bgenbel.Doctorid = Txt_Doctorid.Text.Trim();
            bgenbel.Dateofprescription = Txt_DateOfPrescription.Text.Trim();
            bgenbel.Medicineid = Txt_Medicineid.Text.Trim();
            bgenbel.Patientnumber = Txt_PatientNumber.Text.Trim();
            bgenbel.Quantocon = Txt_QuantityToConsume.Text.Trim();
            bgenbel.Consulfee = int.Parse(Txt_ConsultationFee.Text.Trim());
            bgenbel.Medicinefee = int.Parse(Txt_MedicineCost.Text.Trim());
            bgenbel.Totalcost = int.Parse(Txt_TotalCost.Text.Trim());
            //Txt_TotalCost.Text = Txt_TotalCost.Text
            //int sum = bgenbel.Consulfee + bgenbel.Medicinefee;
            //bgenbel.Totalcost = sum;
            //Txt_TotalCost.Text=k.ToString();
            bgenbel.Paymentmode = DDL_PaymentMode.Text.Trim();
            bgenbel.Isbillpaid = DDL_IsBillPaid.Text.Trim();
            bgenbel.Nextconsuldate = Txt_NextConsultationDate.Text.Trim();
            try
            {
                result = bgenbll.bllbgen(bgenbel);
                if (result>0)
                {
                   Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Bill Generated Successfully!!');", true);
                   // Session["str"] = "Bill Created Successfully!!";
                    //Response.Redirect("ClerkHome.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {

            } 
        }

        protected void DDL_PaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDL_PaymentMode.SelectedValue.ToString() == "Cash")
            {

                Txt_CCNumber.Text = "0";
                Txt_CCNumber.Enabled = false;
            }
            else if (DDL_PaymentMode.SelectedValue.ToString() == "--SELECT--")
            {
                Txt_CCNumber.Enabled = false;
            }
            else
            {
                Txt_CCNumber.Text = null;
                Txt_CCNumber.Enabled = true;
            }
        }

        protected void Txt_MedicineCost_TextChanged(object sender, EventArgs e)
        {
            
            if (Txt_MedicineCost.Text.Count()<1)
            {
                Txt_TotalCost.Text = null;
                Txt_MedicineCost.AutoPostBack = false;   
            }
            else
            {
                Txt_MedicineCost.AutoPostBack = true;  
                int k = int.Parse(Txt_ConsultationFee.Text) + int.Parse(Txt_MedicineCost.Text);
                Txt_TotalCost.Text = k.ToString();
            }
            Txt_MedicineCost.AutoPostBack = true;
        }

    }
}
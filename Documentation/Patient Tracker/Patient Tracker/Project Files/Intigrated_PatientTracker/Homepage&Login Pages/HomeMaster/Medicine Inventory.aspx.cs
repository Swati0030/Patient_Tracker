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
    public partial class Medicine_Inventory : System.Web.UI.Page
    {
        Medicine_BEL belmedicine = new Medicine_BEL();
        Medicine_BLL bllmedicine = new Medicine_BLL();
        int random = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Random rdr = new Random();
            random = rdr.Next(10000, 99999);
            if (!IsPostBack)
            {
                Txt_Medicineid.Text = random.ToString();
                belmedicine.Medicineid = Convert.ToInt32(Txt_Medicineid.Text);

                Calendar1.Visible = false;
                Calendar2.Visible = false;


            }
        }

        protected void Btn_AddMedicine_Click(object sender, EventArgs e)
        {
            belmedicine.Doctorid = Txt_Doctorid.Text.Trim();
            belmedicine.Expirydate = Convert.ToDateTime(Txt_ExpiryDate.Text.Trim());
            belmedicine.Companyname = Txt_CompanyName.Text.Trim();
            belmedicine.Manufacturingdate = Convert.ToDateTime(Txt_ManufacturingDate.Text.Trim());
            belmedicine.Medicineid = Convert.ToInt32(Txt_Medicineid.Text);
            belmedicine.Medicinename = Txt_MedicineName.Text.Trim();
            belmedicine.Medicinetype = DDL_MedicineType.Text.Trim();
            belmedicine.Priceperunit = Convert.ToInt32(Txt_PricePerUnit.Text.Trim());
            belmedicine.Quantity = Convert.ToInt32(Txt_Quantity.Text.Trim());
            belmedicine.Storagetype = DDL_StorageType.Text.Trim();

            DateTime mdt = Convert.ToDateTime(Txt_ManufacturingDate.Text.Trim());
            DateTime edt = Convert.ToDateTime(Txt_ExpiryDate.Text.Trim());
            int diff = (edt - mdt).Days;
            int a = diff / 30;

            int result = 0;
            if (a <= 6)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Medicine has expired);", true);

            }

            else
            {
                result = bllmedicine.medicalInv(belmedicine);
            }
            //Response.Write("result");

            if (result > 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Medicine Stored Sucessfully');", true);
                //Btn_AddMedicine.Enabled = false;
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Error in creating your account. Please try again');", true);

            }
            bllmedicine = null;
            belmedicine = null;
            
            
        }
        
        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            Txt_ManufacturingDate.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");
            Calendar1.Visible = false;
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
                Calendar2.Visible = false;
            }
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            Txt_ExpiryDate.Text = Calendar2.SelectedDate.ToString("MM/dd/yyyy");
            Calendar2.Visible = false;
        }

        protected void calanderImage_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar2.Visible)
            {
                Calendar2.Visible = false;
            }
            else
            {
                Calendar2.Visible = true;
                Calendar1.Visible = false;
            }
        }
    }
}
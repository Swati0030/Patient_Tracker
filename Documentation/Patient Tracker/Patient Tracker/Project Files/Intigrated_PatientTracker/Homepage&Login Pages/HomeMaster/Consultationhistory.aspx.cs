using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BEL;
using BLL;

namespace HomeMaster
{
    public partial class Consultationhistory : System.Web.UI.Page
    {
        Doctorhome_BEL dhbel = new Doctorhome_BEL();
        Doctorhome_BLL dhbll = new Doctorhome_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["PId"] != null && Session["Id"] != null)
                {
                    dhbel.Patientid = Session["PId"].ToString();
                    dhbel.Doctorid = Session["Id"].ToString();
                    SqlDataAdapter da = dhbll.consultationhistory_bll(dhbel);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataTableReader dtr = dt.CreateDataReader();
                    if (dtr.Read())
                    {
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                   else
                   {
                    Lbl_history.Text = "No Records For The Entered Patientid";
                   }
                }
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
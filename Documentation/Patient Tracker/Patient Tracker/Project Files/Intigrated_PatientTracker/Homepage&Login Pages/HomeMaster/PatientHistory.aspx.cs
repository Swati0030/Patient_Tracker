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
    public partial class ViewHistory111 : System.Web.UI.Page
    {
        Patienthome_BEL phbel = new Patienthome_BEL();
        Patienthome_BLL phbll = new Patienthome_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                if (Session["Id"] != null)
                {
                    phbel.Patientid = Session["Id"].ToString();
                    SqlDataAdapter d = phbll.viewhistory_bll(phbel);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    List<string> dd = phbll.ddlist_bll(phbel);
                    foreach (string s in dd)
                    {


                        DropDownList1.Items.Add(s);

                    }

                }
            }  
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("Id");
            Session.RemoveAll();
            Response.Redirect("PatientLogin.aspx");
        }

        protected void Btn_Search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dr = phbll.prescriptionscreen_bll(DropDownList1.SelectedValue);
            DataTable t = new DataTable();
            dr.Fill(t);
            GridView2.DataSource = t;
            GridView2.DataBind();
        }

      
    }
}
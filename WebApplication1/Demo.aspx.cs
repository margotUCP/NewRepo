using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(txtName.Text + "</br>");

            Response.Write(lstLocation.SelectedItem.Text + "</br>");

            lblName.Visible = faux;
            txtName.Visible = false;
            lstLocation.Visible = faux;
            chkC.Visible = faux;
            chkASP.Visible = faux;
            rdFemale.Visible = faux;
            btnSubmit.Visible = faux;
        }
    }
}
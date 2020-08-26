using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace LD3_Web_App
{
    public partial class LD3WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnService_Click(object sender, EventArgs e)
        {
            ServiceReference1.StringWebServiceSoapClient serv = new ServiceReference1.StringWebServiceSoapClient();

            TextPost.Text = serv.Edit(TextAdd.Text);


        }
    }
}
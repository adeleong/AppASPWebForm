using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Submit.ServerClick += Submit_ServerCLick;

        }

        void Submit_ServerCLick(object sender, EventArgs e)
        {
            Message.InnerHtml = "You are 30";
        }
    }
}
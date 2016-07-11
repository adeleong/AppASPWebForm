using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebForm
{
    public partial class CookiesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var cookie = new HttpCookie("MyCookie", TextBox1.Text);
            Response.Cookies.Add(cookie);
        }
    }
}
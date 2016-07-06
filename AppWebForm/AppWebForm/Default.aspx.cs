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
           
        }

        void Submit_ServerCLick(object sender, EventArgs e)
        {
            Message.Text = "You are 35";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Session["BirthDate"] = BirthDate.Text;
            Application["Email"] = Email.Text;
            Message.Text = BirthDate.Text + " " + Email.Text;

        }

        protected void Retrieve_Click(object sender, EventArgs e)
        {
            string birthDate = "";
            string email = "";

            if (Session["BirthDate"] != null) {
                birthDate = Session["BirthDate"].ToString();
                
            }

            if (Application["Email"] != null) {
                email = Application["Email"].ToString();
            }

            RetrieveMessage.Text = "Retrieved " +birthDate + " " + email;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebForm
{
    public partial class WebFormControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool ssd = SSD.Checked;
            bool ram = SixteenGB.Checked;
            bool dual = DualMonitor.Checked;

            Message.Text = "You selected";
            Message.Text += ssd ? "SSD Drive" : "";
            Message.Text += ssd ? "16GB Ram" : "";
            Message.Text += ssd ? "Dual Monitor" : "";

            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString();
                }
            }

            Message.Text += "<br/>The customer";
            Message.Text += Male.Checked ? "Male" : "Female";
            Message.Text += "<br/>Your age grop is ";
            foreach (ListItem li in RadioButtonList1.Items)
            {
                if (li.Selected)
                {
                    Message.Text += li.Value.ToString() + ". ";
                }
            
            }

            Message.Text += "You selected Item";
            Message.Text += DropDownList1.SelectedValue.ToString();
        }
    }
}
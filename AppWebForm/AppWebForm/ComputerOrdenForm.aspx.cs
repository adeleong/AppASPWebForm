using AppWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppWebForm
{
    public partial class ComputerOrdenForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var order = new ComputerOrder();
            order.OrdenId = 110;
            order.OrdenName = orderName.Text;
            order.Customer = customerName.Text;
            order.CustomerEmail = customerEmail.Text;
            order.DeliveryDate = DeliveryDate.SelectedDate;
            order.PartNumber = int.Parse(partNumber.Text);
            order.Rush = RushYes.Checked;
            Session["CurrentOrder"] = order;
            Response.Redirect("ReviewComputerOrder.aspx");
        }
    }
}
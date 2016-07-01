using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebForm.Models
{
    public class ComputerOrder
    {
        public int OrdenId { get; set; }
        public string OrdenName { get; set; }
        public string Customer { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PartNumber  { get; set; }
        public bool Rush { get; set; }

    }
}
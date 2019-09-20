using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUIFeatures.Models
{
    public class Deal
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public double DollarPrice { get; set; }
        public double PenPrice { get; set; }
        public int Discount { get; set; }
    }
}

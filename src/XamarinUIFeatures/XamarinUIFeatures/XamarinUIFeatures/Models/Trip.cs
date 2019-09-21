using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUIFeatures.Models
{
    public class Trip
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Departure { get; set; }
        public TimeSpan Arrival { get; set; }
        public string ImageUrl { get; set; }
    }
}

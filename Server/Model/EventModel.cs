using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Model
{
    public class EventModel
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime t_bookedTime { get ; set; }
        public double d_paid { get; set; }
        public double d_topay { get; set; }
        public string str_service { get; set; }
        public string str_status { get; set; }
    }
}

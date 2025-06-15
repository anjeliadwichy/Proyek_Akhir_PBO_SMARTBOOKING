using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelStatusBooking
    {
        public int id_status_booking { get; set; }
        public string status { get; set; }

        public ModelStatusBooking(int id_status_booking, string status)
        {
            this.id_status_booking = id_status_booking;
            this.status = status;
        }
    }
}

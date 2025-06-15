using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectakhirsem2.Model;

namespace projectakhirsem2.Controller
{
    internal interface IStatusBookingController
    {
        List<ModelStatusBooking> GetAll();
    }
}

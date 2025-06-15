using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelBookingRelated
    {
        public int id_booking { get; set; }

        public ModelBookingRelated(int id_booking)
        {
            this.id_booking = id_booking;
        }
    }

    public class ModelReview : ModelBookingRelated
    {
        public int rating { get; set; }
        public string komentar { get; set; }
        public DateTime tanggal_review { get; set; }

        public ModelReview(int rating, string komentar, DateTime tanggal_review, int id_booking)
            : base(id_booking)
        {
            this.rating = rating;
            this.komentar = komentar;
            this.tanggal_review = tanggal_review;
        }
    }
}

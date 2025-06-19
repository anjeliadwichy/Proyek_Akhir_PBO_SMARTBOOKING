using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelBookingRelated //OOP INHERITANCE, kelas induk
    {
        public int id_booking { get; set; } //bisa di getset dr luar kelas OOP ENCAPSULATION

        public ModelBookingRelated(int id_booking) //constructor
        {
            this.id_booking = id_booking; //mengisi properti id_booking dg argumen dr parameter
        }
    }

    public class ModelReview : ModelBookingRelated //kelas turunan
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

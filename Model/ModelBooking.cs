using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelBooking
    {
        public int id_booking { get; set; }
        public DateTime tanggal_booking { get; set; }
        public DateTime tanggal_pelaksanaan { get; set; }
        public TimeSpan waktu_mulai { get; set; }
        public TimeSpan waktu_selesai { get; set; }
        public string tempat { get; set; } 
        public string catatan { get; set; }
        public int id_pengguna { get; set; }
        public int? id_fotografer { get; set; }
        public int id_status_booking { get; set; }
        public int id_paket_jasa { get; set; }

        public ModelBooking(int id_booking, DateTime tanggal_booking, DateTime tanggal_pelaksanaan, TimeSpan waktu_mulai, TimeSpan waktu_selesai, string tempat, string catatan, int id_pengguna, int? id_fotografer, int id_status_booking, int id_paket_jasa)
        {
            this.id_booking = id_booking;
            this.tanggal_booking = tanggal_booking;
            this.tanggal_pelaksanaan = tanggal_pelaksanaan;
            this.waktu_mulai = waktu_mulai;
            this.waktu_selesai = waktu_selesai;
            this.tempat = tempat;
            this.catatan = catatan;
            this.id_pengguna = id_pengguna;
            this.id_fotografer = id_fotografer;
            this.id_status_booking = id_status_booking;
            this.id_paket_jasa = id_paket_jasa;
        }
    }
}

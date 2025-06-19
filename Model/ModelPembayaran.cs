using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelPembayaran : ModelBookingRelated
    {
        public int id_pembayaran { get; set; }
        public int total_harga { get; set; }
        public DateTime tanggal_pembayaran { get; set; }
        public int id_metode_pembayaran { get; set; }
        public ModelPembayaran(int id_pembayaran, int total_harga, DateTime tanggal_pembayaran, int id_metode_pembayaran, int id_booking)
            : base(id_booking)
        {
            this.id_pembayaran = id_pembayaran;
            this.total_harga = total_harga;
            this.tanggal_pembayaran = tanggal_pembayaran;
            this.id_metode_pembayaran = id_metode_pembayaran;
        }
    }
}

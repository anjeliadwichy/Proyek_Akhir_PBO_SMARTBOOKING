using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelMetodePembayaran
    {
        public int id_metode_pembayaran { get; set; }
        public string metode_pembayaran{ get; set; }
        public ModelMetodePembayaran(int id_metode_pembayaran, string metode_pembayaran)
        {
            this.id_metode_pembayaran = id_metode_pembayaran;
            this.metode_pembayaran = metode_pembayaran;
        }
    }
}

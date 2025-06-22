using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{

        public class ModelPaketJasa : ModelJenisLayanan
        {
            public int id_paket_jasa { get; set; }
            public string nama_paket { get; set; }
            public int harga { get; set; }
            public string deskripsi { get; set; }

            public ModelPaketJasa(int id_paket_jasa, string nama_paket, int harga, string deskripsi, int id_jenis_layanan, string nama_jenis)
                : base(id_jenis_layanan, nama_jenis)
            {
                this.id_paket_jasa = id_paket_jasa;
                this.nama_paket = nama_paket;
                this.harga = harga;
                this.deskripsi = deskripsi;
            }

            public override string GetDisplayInfo()
            {
                return $"{nama_paket} - Rp{harga:N0}";
            }
        }
}

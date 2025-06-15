using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelLayananBase
    {
        public int Id { get; protected set; }
        public string Nama { get; set; }

        public ModelLayananBase(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }

        public virtual string GetDisplayInfo()
        {
            return Nama;
        }
    }

    public class ModelPaketJasa : ModelLayananBase
    {
        public int id_jenis_layanan { get; set; }
        public int harga { get; set; }
        public string deskripsi { get; set; }

        public string nama_paket
        {
            get { return Nama; }  // dari base
            set { Nama = value; }
        }

        public int id_paket_jasa
        {
            get { return Id; }    // dari base
            private set { Id = value; }
        }

        public string DisplayInfo
        {
            get { return $"{nama_paket} - Rp{harga:N0}"; }
        }

        public ModelPaketJasa(int id_paket_jasa, string nama_paket, int id_jenis_layanan, int harga, string deskripsi)
            : base(id_paket_jasa, nama_paket)
        {
            this.id_jenis_layanan = id_jenis_layanan;
            this.harga = harga;
            this.deskripsi = deskripsi;
        }

        public override string GetDisplayInfo()
        {
            return $"{nama_paket} - Rp{harga:N0}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelJenisLayanan
    {
        public int id_jenis_layanan { get; private set; }
        public string nama_jenis { get; set; }

        public ModelJenisLayanan(int id_jenis_layanan, string nama_jenis)
        {
            this.id_jenis_layanan = id_jenis_layanan;
            this.nama_jenis = nama_jenis;
        }
    }
}

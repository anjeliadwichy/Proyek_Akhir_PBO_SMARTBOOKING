using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class ModelFotografer
    {
        public int id_fotografer { get; private set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string no_telepon { get; set; }

        public ModelFotografer(int id_fotografer, string nama, string email, string no_telepon)
        {
            this.id_fotografer = id_fotografer;
            this.nama = nama;
            this.email = email;
            this.no_telepon = no_telepon;
        }

    }
}

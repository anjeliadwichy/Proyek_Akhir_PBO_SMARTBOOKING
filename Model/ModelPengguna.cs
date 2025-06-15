using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Model
{
    public class PenggunaBase
    {
        public int id_pengguna { get; protected set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string no_telepon { get; set; }

        public PenggunaBase(int id_pengguna, string nama, string email, string no_telepon)
        {
            this.id_pengguna = id_pengguna;
            this.nama = nama;
            this.email = email;
            this.no_telepon = no_telepon;
        }

        public virtual string GetRole()
        {
            return "Pengguna";
        }
    }

    public class ModelPengguna : PenggunaBase
    {
        public string password { get; set; }

        public ModelPengguna(int id_pengguna, string nama, string email, string no_telepon, string password)
            : base(id_pengguna, nama, email, no_telepon)
        {
            this.password = password;
        }

        public override string GetRole()
        {
            return "Pengguna Biasa";
        }
    }

}

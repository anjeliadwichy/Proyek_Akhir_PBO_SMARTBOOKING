using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectakhirsem2.Model;

namespace projectakhirsem2.Controller
{
    internal interface IPenggunaController
    {
        List<ModelPengguna> GetAll();
        void Add(string nama, string email, string no_telepon, string password);
        PenggunaBase Login(string email, string password);
        int GetJumlahPengguna();
    }
}

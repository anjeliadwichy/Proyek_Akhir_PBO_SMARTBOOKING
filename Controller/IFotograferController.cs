using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectakhirsem2.Model;

namespace projectakhirsem2.Controller
{
    internal interface IFotograferController
    {
        List<ModelFotografer> GetAll();
        void Add(string nama, string email, string no_telepon);
        void Update(int id, string nama, string email, string no_telepon);
        void Delete(int id);
        int GetJumlahFotografer();
    }
}

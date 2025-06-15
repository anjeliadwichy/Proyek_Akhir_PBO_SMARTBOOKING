using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    public interface IPaketJasaController
    {
        List<ModelPaketJasa> GetAll();
        void Add(string nama, int idJenis, int harga, string deskripsi);
        void Update(int id, string nama, int idJenis, int harga, string deskripsi);
        void Delete(int id);
    }

}

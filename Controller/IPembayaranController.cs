using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    internal interface IPembayaranController
    {
        List<ModelPembayaran> GetAll();
        void Add(int total_harga, DateTime tanggal_pembayaran, int id_metode_pembayaran, int id_booking);
        DataTable GetBlmBayar();
        List<ModelPembayaran> GetAllPembayaranAdmin();
    }
}

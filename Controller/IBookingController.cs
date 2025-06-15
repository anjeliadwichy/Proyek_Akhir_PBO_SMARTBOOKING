using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    internal interface IBookingController
    {
        List<ModelBooking> GetAll();
        void Add(DateTime tanggal_booking, DateTime tanggal_pelaksanaan,
            TimeSpan waktu_mulai, TimeSpan waktu_selesai, string tempat, string catatan,
            int id_pengguna, int? id_fotografer, int id_status_booking, int id_paket_jasa);

        void UpdateStatusInputFotografer(int idBooking, int idStatus, int idFotografer);
        void UpdateStatusOnly(int idBooking, int idStatus);
        DataTable ViewRiwBooking(int id_pengguna);
        void BatalkanBooking(int idBooking);
        bool IsBookingConflict(DateTime tanggalPelaksanaan, TimeSpan waktuMulai, TimeSpan waktuSelesai);
        List<ModelBooking> GetSelesaiBelumDireviewByPengguna(int id_pengguna);
        int GetJumlahbooking();
        int GetJumlahpending();
        int GetJumlahsetujui();
        int GetJumlahbatal();
        int GetJumlahselesai();
    }
}

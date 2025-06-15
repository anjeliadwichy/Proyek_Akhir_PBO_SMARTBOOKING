using projectakhirsem2.Database;
using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    public class StatusBookingController : IStatusBookingController
    {
        public List<ModelStatusBooking> GetAll()
        {
            List<ModelStatusBooking> list = new List<ModelStatusBooking>();

            try
            {
                string query = "SELECT * FROM status_booking";
                DataTable dt = DB.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    ModelStatusBooking status = new ModelStatusBooking(
                        Convert.ToInt32(row["id_status_booking"]),
                        row["status"].ToString()
                    );

                    list.Add(status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jenis layanan: " + ex.Message);
            }

            return list;
        }
    }
}

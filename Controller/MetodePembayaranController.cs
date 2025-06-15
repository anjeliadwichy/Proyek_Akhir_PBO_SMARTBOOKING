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
    public class MetodePembayaranController : IMetodePembayaranController
    {
        public List<ModelMetodePembayaran> GetAll()
        {
            List<ModelMetodePembayaran> list = new List<ModelMetodePembayaran>();

            try
            {
                string query = "SELECT * FROM metode_pembayaran";
                DataTable dt = DB.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    ModelMetodePembayaran metode = new ModelMetodePembayaran(
                        Convert.ToInt32(row["id_metode_pembayaran"]),
                        row["metode_pembayaran"].ToString()
                    );

                    list.Add(metode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data metode pembayaran " + ex.Message);
            }

            return list;
        }
    }
}

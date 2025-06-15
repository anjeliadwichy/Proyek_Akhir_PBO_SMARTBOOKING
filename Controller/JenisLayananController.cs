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
    public class JenisLayananController : IJenisLayananController
    {
        public List<ModelJenisLayanan> GetAll()
        {
            List<ModelJenisLayanan> list = new List<ModelJenisLayanan>();

            try
            {
                string query = "SELECT * FROM jenis_layanan";
                DataTable dt = DB.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    ModelJenisLayanan jenis = new ModelJenisLayanan(
                        Convert.ToInt32(row["id_jenis_layanan"]),
                        row["nama_jenis"].ToString()
                    );

                    list.Add(jenis);
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

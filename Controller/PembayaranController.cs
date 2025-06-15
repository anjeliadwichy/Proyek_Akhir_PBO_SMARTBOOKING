using Npgsql;
using projectakhirsem2.Database;
using projectakhirsem2.Helpers;
using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    public class PembayaranController : IPembayaranController
    {
        public List<ModelPembayaran> GetAll()
	{
	    try
	    {
	        List<ModelPembayaran> list = new List<ModelPembayaran>();
	        string query = @"
	            SELECT 
	                p.id_pembayaran,
	                p.total_harga,
	                p.tanggal_pembayaran,
	                p.id_metode_pembayaran,
	                p.id_booking
	            FROM pembayaran p
	            JOIN booking b ON p.id_booking = b.id_booking
	            WHERE b.id_pengguna = @id_pengguna
	            ORDER BY p.id_pembayaran";
	
	        DataTable dt = DB.ExecuteQuery(query, new NpgsqlParameter("@id_pengguna", Session.id_pengguna));
	
	        foreach (DataRow row in dt.Rows)
	        {
	            var metode = new ModelPembayaran(
	                Convert.ToInt32(row["id_pembayaran"]),
	                Convert.ToInt32(row["total_harga"]),
	                Convert.ToDateTime(row["tanggal_pembayaran"]),
	                Convert.ToInt32(row["id_metode_pembayaran"]),
	                Convert.ToInt32(row["id_booking"])
	            );
	            list.Add(metode);
	        }
	
	        return list;
	    }
	    catch (Exception ex)
	    {
	        MessageBox.Show($"Database error: {ex.Message}");
	        return new List<ModelPembayaran>();
	    }
	}


        public void Add(int total_harga, DateTime tanggal_pembayaran, int id_metode_pembayaran, int id_booking)
        {
            DB.ExecuteNonQuery("INSERT INTO pembayaran(total_harga, tanggal_pembayaran, id_metode_pembayaran, id_booking) VALUES (@total_harga, @tanggal_pembayaran, @id_metode_pembayaran, @id_booking)",
                new NpgsqlParameter("@total_harga", total_harga),
                new NpgsqlParameter("@tanggal_pembayaran", tanggal_pembayaran),
                new NpgsqlParameter("@id_metode_pembayaran", id_metode_pembayaran),
                new NpgsqlParameter("@id_booking", id_booking)
            );
            MessageBox.Show("Metode pembayaran berhasil ditambahkan");
        }

        public DataTable GetBlmBayar()
	{
	    string query = @"
	        SELECT 
	            b.id_booking, 
	            b.tanggal_booking, 
	            pj.nama_paket,
	            pj.harga AS total_harga,
	            s.status,
	            b.tanggal_pelaksanaan,
	            b.waktu_mulai,
	            b.waktu_selesai
	        FROM booking b
	        JOIN paket_jasa pj ON b.id_paket_jasa = pj.id_paket_jasa
	        JOIN status_booking s ON b.id_status_booking = s.id_status_booking
	        WHERE b.id_pengguna = @id_pengguna
	          AND b.id_status_booking = 2 -- pastikan 2 artinya 'Belum Bayar'
	          AND NOT EXISTS (
	              SELECT 1 FROM pembayaran p WHERE p.id_booking = b.id_booking
	          );";
	
	    return DB.ExecuteQuery(query, new NpgsqlParameter("@id_pengguna", Session.id_pengguna));
	}
	
	public List<ModelPembayaran> GetAllPembayaranAdmin()
	{
	    try
	    {
	        List<ModelPembayaran> list = new List<ModelPembayaran>();
	        string query = @"
	            SELECT 
	                p.id_pembayaran,
	                p.total_harga,
	                p.tanggal_pembayaran,
	                p.id_metode_pembayaran,
	                p.id_booking
	            FROM pembayaran p
	            ORDER BY p.id_pembayaran";
	
	        DataTable dt = DB.ExecuteQuery(query);
	
	        foreach (DataRow row in dt.Rows)
	        {
	            var metode = new ModelPembayaran(
	                Convert.ToInt32(row["id_pembayaran"]),
	                Convert.ToInt32(row["total_harga"]),
	                Convert.ToDateTime(row["tanggal_pembayaran"]),
	                Convert.ToInt32(row["id_metode_pembayaran"]),
	                Convert.ToInt32(row["id_booking"])
	            );
	            list.Add(metode);
	        }
	
	        return list;
	    }
	    catch (Exception ex)
	    {
	        MessageBox.Show($"Database error: {ex.Message}");
	        return new List<ModelPembayaran>();
	    }
	}

    }
}

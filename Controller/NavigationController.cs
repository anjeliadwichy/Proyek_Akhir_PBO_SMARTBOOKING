using projectakhirsem2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    public class NavigationController
    {
        Form? openform;

        public void NavigateDashboard(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewDashboard();

            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Dashboard";
            openform.Show();
        }

        public void NavigatePaketJasa(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewPaketJasa();

            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Paket Jasa";
            openform.Show();
        }

        public void NavigateFotografer(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewFotografer();

            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Fotografer";
            openform.Show();
        }

        public void NavigateDataPengguna(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewDataPengguna();

            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Data Pengguna";
            openform.Show();
        }

        public void NavigateViewOpen(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewOpen();

            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Selamat Datang";
            openform.Show();
        }

        public void NavigateBooking(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewBooking();
            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Booking";
            openform.Show();
        }

        public void NavigateBookingAdmin(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewBookingAdmin();
            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Booking Admin";
            openform.Show();
        }

        public void NavigateReview(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewReview();
            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Review";
            openform.Show();
        }

        public void NavigateAllReview(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewAllReview();
            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Lihat Booking";
            openform.Show();
        }

        public void NavigateBatalBooking(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewBatalBooking();
            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Batalkan Booking";
            openform.Show();
        }

        public void NavigatePembayaran(Form form)
        {
            if (openform != null)
            {
                openform.Close();
                openform = null;
            }
            openform = new ViewPembayaran();
            openform.MdiParent = form;
            openform.Dock = DockStyle.Fill;
            form.Text = "Pembayaran Booking";
            openform.Show();
        }
    }
}

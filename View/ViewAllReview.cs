using projectakhirsem2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectakhirsem2.View
{
    public partial class ViewAllReview : Form
    {
        IReviewController reviewController = new ReviewController();
        public ViewAllReview()
        {
            InitializeComponent();
        }

        private void ViewAllReview_Load(object sender, EventArgs e)
        {
            dgvallreview.DataSource = reviewController.GetAllReview();
        }
    }
}

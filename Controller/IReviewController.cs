using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    internal interface IReviewController
    {
        List<ModelReview> GetAll();
        void AddReview(int rating, string komentar, DateTime tanggal_review, int id_booking);
        DataTable GetAllReview();
    }
}

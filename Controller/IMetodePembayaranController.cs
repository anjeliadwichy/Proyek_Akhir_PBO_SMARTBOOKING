using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    internal interface IMetodePembayaranController
    {
        List<ModelMetodePembayaran> GetAll();
    }
}

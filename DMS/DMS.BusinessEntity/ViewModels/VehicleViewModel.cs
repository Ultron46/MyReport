using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.BusinessEntity.Models
{
    public class VehicleViewModel
    {
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string VehicleName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdateDate { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
    }
}

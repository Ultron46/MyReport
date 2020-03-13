using System.Collections.Generic;

namespace DMS.BusinessEntity.Models
{
    public class CustomerViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerViewModel()
        {
            this.Vehicles = new HashSet<VehicleViewModel>();
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleViewModel> Vehicles { get; set; }
    }
}

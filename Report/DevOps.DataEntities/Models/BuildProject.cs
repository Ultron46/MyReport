//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevOps.DataEntities.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuildProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuildProject()
        {
            this.ServerBuilds = new HashSet<ServerBuild>();
        }
    
        public int BuildId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> BuildBy { get; set; }
        public Nullable<byte> Mejor_Version { get; set; }
        public Nullable<byte> Minor_Version { get; set; }
        public Nullable<int> Build_Version { get; set; }
        public string DownloadURL { get; set; }
        public string Status { get; set; }
        public System.DateTime BuildDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServerBuild> ServerBuilds { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}

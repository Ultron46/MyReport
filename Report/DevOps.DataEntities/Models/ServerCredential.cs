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
    
    public partial class ServerCredential
    {
        public int ServerCredentialsId { get; set; }
        public Nullable<int> ServerId { get; set; }
        public string HostName { get; set; }
        public string Password { get; set; }
        public string ConnectionString { get; set; }
    
        public virtual ServerConfig ServerConfig { get; set; }
    }
}

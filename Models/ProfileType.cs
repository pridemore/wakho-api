//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTransAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfileType
    {
        public ProfileType()
        {
            this.Shops = new HashSet<Shop>();
        }
    
        public int TypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Shop> Shops { get; set; }
    }
}

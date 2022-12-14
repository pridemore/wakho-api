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
    
    public partial class ChatRoom
    {
        public ChatRoom()
        {
            this.HiddenChats = new HashSet<HiddenChat>();
        }
    
        public int ChatRoomId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.TimeSpan> TimeCreated { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public string CreatorIP { get; set; }
        public Nullable<int> RecipientID { get; set; }
        public string Status { get; set; }
    
        public virtual Subscriber Subscriber { get; set; }
        public virtual ICollection<HiddenChat> HiddenChats { get; set; }
    }
}

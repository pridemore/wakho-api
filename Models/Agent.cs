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
    
    public partial class Agent
    {
        public Agent()
        {
            this.Agent_Post = new HashSet<Agent_Post>();
            this.PostsByAgents = new HashSet<PostsByAgent>();
            this.Wallets = new HashSet<Wallet>();
            this.payment_requests = new HashSet<payment_requests>();
        }
    
        public int AgentId { get; set; }
        public Nullable<int> SubscriberId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTel { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyLogo { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string BankName { get; set; }
        public string Account_Number { get; set; }
        public string Bank_Adress { get; set; }
        public string IDpic { get; set; }
        public string ProofRes { get; set; }
        public ImageUp upload1 { get; set; }
        public ImageUp upload2 { get; set; }

        public virtual ICollection<Agent_Post> Agent_Post { get; set; }
        public virtual Subscriber Subscriber { get; set; }
        public virtual ICollection<PostsByAgent> PostsByAgents { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
        public virtual ICollection<payment_requests> payment_requests { get; set; }
    }
}

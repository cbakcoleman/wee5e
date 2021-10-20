using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wee5e.Models
{
    public class Campaign
    {
        [Key]
        public int CampaignId {get;set;}

        public string CampaignName {get;set;}

        public string Description {get;set;}

        public int DMId {get;set;}

        public User DM {get;set;}

        //public List<Member> Members {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}
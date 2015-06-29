namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class Campaign
    {
    	
        public bool? Move { get; set; }
        
        public string ExceptionPolicyName { get; set; }
        
        public int? ABTestID { get; set; }
        
        public bool? IsSplitTestMaster { get; set; }
        
        public int? Weight { get; set; }
        
        public int? SplitTestId { get; set; }
        
        public CampaignSplitTest SplitTest { get; set; }
        
        public string CampaignName { get; set; }
        
        public string CampaignDescription { get; set; }
        
        public Client Client { get; set; }
        
        public List<Cycle> Cycles { get; set; }
        
        public int? ClientId { get; set; }
        
        public bool? IsFixed { get; set; }
        
        public int? CampaignType { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public bool? IsActive { get; set; }
        
        public bool? IsArchived { get; set; }
        
    }
}


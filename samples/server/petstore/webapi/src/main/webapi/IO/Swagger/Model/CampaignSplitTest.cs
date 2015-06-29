namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class CampaignSplitTest
    {
    	
        public string ExceptionPolicyName { get; set; }
        
        public string SplitTestName { get; set; }
        
        public string Outcome { get; set; }
        
        public string SplitTestDescription { get; set; }
        
        public int? ClientId { get; set; }
        
        public int? MasterCampaignId { get; set; }
        
        public int? ModifiedBy { get; set; }
        
        public DateTime? TestStartDate { get; set; }
        
        public DateTime? TestEndDate { get; set; }
        
        public bool? IsActive { get; set; }
        
        public bool? IsDeleted { get; set; }
        
    }
}


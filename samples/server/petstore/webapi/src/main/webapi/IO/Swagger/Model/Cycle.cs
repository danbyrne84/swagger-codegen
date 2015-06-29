namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class Cycle
    {
    	
        public int? Id { get; set; }
        
        public int? CampaignId { get; set; }
        
        public string ResponseMethod { get; set; }
        
        public int? ResponseTime { get; set; }
        
        public int? ResponseTimeDays { get; set; }
        
        public int? ResponseTimeHours { get; set; }
        
        public int? ResponseTimeMinutes { get; set; }
        
        public int? TemplateId { get; set; }
        
        public int? SequenceNumber { get; set; }
        
        public string ResponseSubject { get; set; }
        
        public string FriendlyName { get; set; }
        
        public List<string> TestingAddresses { get; set; }
        
    }
}


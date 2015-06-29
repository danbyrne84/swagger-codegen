namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class CampaignOverviewEntry
    {
    	
        public int? CampaignId { get; set; }
        
        public string CampaignName { get; set; }
        
        public int? CampaignSequenceNumber { get; set; }
        
        public bool? CampaignActive { get; set; }
        
        public DateTime? CampaignDateDeleted { get; set; }
        
        public int? CycleId { get; set; }
        
        public string CycleName { get; set; }
        
        public int? CycleSequenceNumber { get; set; }
        
        public bool? CycleDeleted { get; set; }
        
        public int? CycleResponseMethod { get; set; }
        
        public string CycleResponseSubject { get; set; }
        
        public DateTime? CycleDateDeleted { get; set; }
        
        public int? FilterId { get; set; }
        
        public int? FilterSequenceNumber { get; set; }
        
        public bool? FilterDeleted { get; set; }
        
        public int? FilterResponseMethod { get; set; }
        
        public string FilterResponseSubject { get; set; }
        
        public int? TemplateId { get; set; }
        
        public float? FilterMinPrice { get; set; }
        
        public float? FilterMaxPrice { get; set; }
        
        public string FilterKeywordsInclude { get; set; }
        
        public string FilterKeywordsExclude { get; set; }
        
        public int? NumberOfResponses { get; set; }
        
        public int? NumberOfConversions { get; set; }
        
        public float? Revenue { get; set; }
        
        public float? AverageSellDifference { get; set; }
        
        public long? AverageRecoveryTime { get; set; }
        
        public float? RevenuePerResponse { get; set; }
        
        public float? ResponsesConversionRate { get; set; }
        
    }
}


namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class SplitTestReport
    {
    	
        public int? SplitTestId { get; set; }
        
        public int? CampaignId { get; set; }
        
        public int? Weight { get; set; }
        
        public string CampaignName { get; set; }
        
        public int? Responses { get; set; }
        
        public int? Abandonments { get; set; }
        
        public float? ResponseRate { get; set; }
        
        public int? Tracked { get; set; }
        
        public float? TrackedRate { get; set; }
        
        public int? Opened { get; set; }
        
        public float? OpenRate { get; set; }
        
        public int? Conversions { get; set; }
        
        public float? ConversionRate { get; set; }
        
        public float? TrackConversionRate { get; set; }
        
        public float? OpenConversionRate { get; set; }
        
    }
}


namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class PerformanceReportEntry
    {
    	
        public int? CycleId { get; set; }
        
        public int? NumberOfResponses { get; set; }
        
        public float? Revenue { get; set; }
        
        public string FriendlyName { get; set; }
        
        public DateTime? DeletedDate { get; set; }
        
    }
}


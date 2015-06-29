namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class TrendsReport
    {
    	
        public int? DatePart { get; set; }
        
        public List<ChartEntry> Sales { get; set; }
        
        public List<ChartEntry> Abandonments { get; set; }
        
        public List<ChartEntry> Conversions { get; set; }
        
    }
}


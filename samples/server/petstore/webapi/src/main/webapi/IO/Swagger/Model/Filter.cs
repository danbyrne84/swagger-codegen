namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class Filter
    {
    	
        public int? CycleId { get; set; }
        
        public Cycle Cycle { get; set; }
        
        public double? MinPrice { get; set; }
        
        public double? MaxPrice { get; set; }
        
        public string KeywordsInclude { get; set; }
        
        public string KeywordsExclude { get; set; }
        
        public string TestingAddresses { get; set; }
        
        public int? SequenceNumber { get; set; }
        
        public int? TemplateId { get; set; }
        
        public ContentTemplate ResponseTemplate { get; set; }
        
        public int? ResponseMethod { get; set; }
        
    }
}


namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class ContentTemplate
    {
    	
        public int? Id { get; set; }
        
        public int? ClientId { get; set; }
        
        public int? ResonseMethod { get; set; }
        
        public string TempName { get; set; }
        
        public string TempContent { get; set; }
        
        public string TempThumb { get; set; }
        
        public string TempImage { get; set; }
        
        public DateTime? DateCreated { get; set; }
        
        public bool? Active { get; set; }
        
        public string TempRef { get; set; }
        
        public string EspCampaignId { get; set; }
        
        public string VersionComment { get; set; }
        
        public int? UpdatedById { get; set; }
        
        public int? CreatedById { get; set; }
        
        public DateTime? DateUpdated { get; set; }
        
        public string StrRedirectUrl { get; set; }
        
        public int? CustomTempId { get; set; }
        
    }
}


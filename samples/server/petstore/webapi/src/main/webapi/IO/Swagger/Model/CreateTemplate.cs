namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class CreateTemplate
    {
    	
        public int? ResponseMethodId { get; set; }
        
        public string TemplateName { get; set; }
        
        public string TemplateContent { get; set; }
        
        public int? ClientId { get; set; }
        
        public string TemplateThumb { get; set; }
        
        public string TemplateContents { get; set; }
        
        public string EspCampaignId { get; set; }
        
        public int? UserId { get; set; }
        
        public string VersionComment { get; set; }
        
        public string UnsubscribeUrl { get; set; }
        
        public int? UnsubscribeCustomTempId { get; set; }
        
    }
}


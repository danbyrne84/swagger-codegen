namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class TemplateHistory
    {
    	
        public int? TemplateId { get; set; }
        
        public string TemplateName { get; set; }
        
        public string TemplateContent { get; set; }
        
        public string UpdatedReasonComments { get; set; }
        
        public DateTime? UpdatedDateTime { get; set; }
        
        public User UpdatedBy { get; set; }
        
        public string UpdatedByName { get; set; }
        
        public string ViewTemplateHtml { get; set; }
        
        public string ViewTemplateHtmlSource { get; set; }
        
    }
}


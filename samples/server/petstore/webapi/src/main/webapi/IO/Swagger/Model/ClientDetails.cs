namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class ClientDetails
    {
    	
        public string ClientName { get; set; }
        
        public int? ClientContactFirstName { get; set; }
        
        public int? ClientContactLastName { get; set; }
        
        public int? ClientContactEmailAddress { get; set; }
        
        public string Address1 { get; set; }
        
        public string Address2 { get; set; }
        
        public string Address3 { get; set; }
        
        public string Town { get; set; }
        
        public string County { get; set; }
        
        public string Country { get; set; }
        
        public string Postcode { get; set; }
        
        public string Telephone { get; set; }
        
        public string ImageUrlPath { get; set; }
        
        public string ClientEsp { get; set; }
        
        public string ClientLanguage { get; set; }
        
        public string ClientType { get; set; }
        
        public string ClientWebsite { get; set; }
        
        public string Logo { get; set; }
        
        public int? ConversionDateRange { get; set; }
        
        public string ContactCentreEmails { get; set; }
        
        public string ReplyToEmails { get; set; }
        
        public DateTime? UtcSignupFromDate { get; set; }
        
        public DateTime? UtcSignupToDate { get; set; }
        
        public string AdditionalInfo { get; set; }
        
        public string ContactCentreFromAddress { get; set; }
        
        public string ParentId { get; set; }
        
        public bool? Activate { get; set; }
        
        public string LiveDateComments { get; set; }
        
        public bool? SetLive { get; set; }
        
    }
}


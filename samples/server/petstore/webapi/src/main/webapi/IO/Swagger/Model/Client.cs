namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class Client
    {
    	
        public int? Id { get; set; }
        
        public string ClientName { get; set; }
        
        public string EspData { get; set; }
        
        public string ApiKey { get; set; }
        
        public bool? BiteSize { get; set; }
        
        public int? SessionTime { get; set; }
        
        public string AdditionalInfo { get; set; }
        
        public string LiveDateComments { get; set; }
        
        public DateTime? ContractFromDate { get; set; }
        
        public DateTime? LiveDate { get; set; }
        
        public DateTime? ContractToDate { get; set; }
        
        public string ContactCentreEmails { get; set; }
        
        public string ContactCentreFromAddress { get; set; }
        
        public string ReplyToEmails { get; set; }
        
        public List<ClientWebsite> Urls { get; set; }
        
        public List<ClientSector> Sectors { get; set; }
        
        public string Address1 { get; set; }
        
        public string Address2 { get; set; }
        
        public string Address3 { get; set; }
        
        public string Town { get; set; }
        
        public bool? Active { get; set; }
        
        public int? ParentId { get; set; }
        
        public string County { get; set; }
        
        public string Country { get; set; }
        
        public string Postcode { get; set; }
        
        public string Telephone { get; set; }
        
        public string ContactFirstName { get; set; }
        
        public string ContactLastName { get; set; }
        
        public string ContactEmailAddress { get; set; }
        
        public string ClientLogo { get; set; }
        
        public string ClientThumbnailLogo { get; set; }
        
        public string ImageUrlPath { get; set; }
        
        public int? DefaultLanguageId { get; set; }
        
        public string Language { get; set; }
        
        public int? TypeId { get; set; }
        
        public int? ConversionDateRange { get; set; }
        
        public string Type { get; set; }
        
        public int? EspId { get; set; }
        
        public string Esp { get; set; }
        
        public DateTime? DateRegistered { get; set; }
        
        public string DefaultWebsite { get; set; }
        
        public bool? ApiUnsubscribe { get; set; }
        
        public bool? OsrEnabled { get; set; }
        
        public bool? PostPurchaseEnabled { get; set; }
        
    }
}


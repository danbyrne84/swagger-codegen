namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class Currency
    {
    	
        public string CurrencyCode { get; set; }
        
        public string CountryName { get; set; }
        
        public string CurrencyName { get; set; }
        
        public string CurrencySymbol { get; set; }
        
        public bool? Active { get; set; }
        
        public bool? IsDefault { get; set; }
        
        public bool? IsNewClientcurrency { get; set; }
        
    }
}


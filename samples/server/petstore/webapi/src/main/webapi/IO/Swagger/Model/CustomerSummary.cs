namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class CustomerSummary
    {
    	
        public int? ClientId { get; set; }
        
        public string ClientName { get; set; }
        
        public int? ClientTypeId { get; set; }
        
        public string ClientImageUrlPath { get; set; }
        
        public string ClientCurrencySymbol { get; set; }
        
        public string DashboardSessionId { get; set; }
        
        public int? DashboardCustomerId { get; set; }
        
        public string DashboardCustomerName { get; set; }
        
        public string DashboardCustomerEmail { get; set; }
        
        public string DashboardCustomerTelephone { get; set; }
        
        public DateTime? DashboardUtcDateCompleted { get; set; }
        
        public string TrackedSessionId { get; set; }
        
        public int? TrackedCustomerId { get; set; }
        
        public string TrackedCustomerName { get; set; }
        
        public string TrackedCustomerEmail { get; set; }
        
        public string TrackedCustomerTelephone { get; set; }
        
        public DateTime? TrackedUtcDateClicked { get; set; }
        
        public string CompletedSessionId { get; set; }
        
        public int? CompletedCustomerId { get; set; }
        
        public string CompletedCustomerName { get; set; }
        
        public string CompletedCustomerEmail { get; set; }
        
        public string CompletedCustomerTelephone { get; set; }
        
        public DateTime? CompletedUtcDateCompleted { get; set; }
        
        public string DashboardItemXml { get; set; }
        
        public string TrackedItemXml { get; set; }
        
        public string CompletedItemXml { get; set; }
        
        public string XmlItem { get; set; }
        
    }
}


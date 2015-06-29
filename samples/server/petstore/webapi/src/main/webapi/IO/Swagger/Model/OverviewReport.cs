namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class OverviewReport
    {
    	
        public int? NumberOfDirectSales { get; set; }
        
        public int? NumberOfAbandonments { get; set; }
        
        public int? NumberOfRecoveredSales { get; set; }
        
        public long? AverageRecoveryTime { get; set; }
        
        public int? TotalAnonymous { get; set; }
        
        public int? UniqueEmails { get; set; }
        
        public int? UniqueTelephoneNumbers { get; set; }
        
        public int? NumberOfResponsesSent { get; set; }
        
        public int? NumberOfUniqueTrackedResponses { get; set; }
        
        public float? ValueOfDirectSales { get; set; }
        
        public float? ValueOfAbandonments { get; set; }
        
        public float? ValueOfRecoveredSales { get; set; }
        
        public float? AverageSellDifference { get; set; }
        
        public float? AbandonmentRate { get; set; }
        
        public float? SalesIncrementPercentage { get; set; }
        
        public float? RevenuePerResponse { get; set; }
        
        public float? RevenuePerTracked { get; set; }
        
        public float? ResponsesConversionRate { get; set; }
        
        public float? TrackedConversionRate { get; set; }
        
        public float? AverageSaleValue { get; set; }
        
        public float? AverageAbandonmentValue { get; set; }
        
        public float? AverageRecoveredSaleValue { get; set; }
        
        public float? RevenueRecoveredPerDay { get; set; }
        
        public float? NumberOfUniqueTrackedResponsesPercentage { get; set; }
        
        public float? OpenRatePercentage { get; set; }
        
    }
}


namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class ClientRetargetingRule
    {
    	
        public string ExceptionPolicyName { get; set; }
        
        public int? ClientID { get; set; }
        
        public string Condition1 { get; set; }
        
        public string Condition2 { get; set; }
        
        public int? Condition1Validation { get; set; }
        
        public int? Condition2Validation { get; set; }
        
        public bool? Active { get; set; }
        
        public bool? Deleted { get; set; }
        
        public CommonRetargetingRule CommonRetargetingRule { get; set; }
        
    }
}


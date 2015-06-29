namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class CommonRetargetingRule
    {
    	
        public string ExceptionPolicyName { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public int? Condition1ValidationID { get; set; }
        
        public int? Condition2ValidationID { get; set; }
        
    }
}


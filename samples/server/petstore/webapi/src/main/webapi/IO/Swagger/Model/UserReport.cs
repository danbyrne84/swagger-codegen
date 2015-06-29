namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class UserReport
    {
    	
        public string Name { get; set; }
        
        public int? UserId { get; set; }
        
        public bool? IsDefaultReport { get; set; }
        
        public List<UserReportPart> ReportParts { get; set; }
        
    }
}


namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class Role
    {
    	
        public int? Id { get; set; }
        
        public string Name { get; set; }
        
        public int? ParentId { get; set; }
        
        public bool? Active { get; set; }
        
        public string Description { get; set; }
        
    }
}


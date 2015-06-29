namespace Api.Models
{
    /// <description>
    /// Customer Model Object
    /// </description>
    public class Customer
    {
    	
        public int? Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public int? Telephone { get; set; }
        
        public DateTime? DateAdded { get; set; }
        
    }
}


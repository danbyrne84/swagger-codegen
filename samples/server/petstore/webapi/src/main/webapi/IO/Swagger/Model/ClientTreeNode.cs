namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class ClientTreeNode
    {
    	
        public int? ClientId { get; set; }
        
        public int? TypeId { get; set; }
        
        public int? ParentId { get; set; }
        
        public string ClientName { get; set; }
        
        public bool? Active { get; set; }
        
        public DateTime? LiveDate { get; set; }
        
        public int? EspId { get; set; }
        
        public string Esp { get; set; }
        
        public int? Level { get; set; }
        
        public string Path { get; set; }
        
        public string Sectors { get; set; }
        
    }
}


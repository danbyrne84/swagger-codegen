namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class EspFormRow
    {
    	
        public int? EspId { get; set; }
        
        public string FieldName { get; set; }
        
        public string FieldType { get; set; }
        
        public int? FieldOrder { get; set; }
        
        public bool? Mandatory { get; set; }
        
        public string FormRowValue { get; set; }
        
    }
}


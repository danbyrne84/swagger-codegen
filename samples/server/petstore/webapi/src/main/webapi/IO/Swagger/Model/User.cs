namespace Api.Models
{
    /// <description>
    /// 
    /// </description>
    public class User
    {
    	
        public int? Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string EmailAddress { get; set; }
        
        public int? LanguageId { get; set; }
        
        public bool? Superuser { get; set; }
        
        public string Locale { get; set; }
        
        public int? ClientId { get; set; }
        
        public bool? RequirePasswordChange { get; set; }
        
    }
}


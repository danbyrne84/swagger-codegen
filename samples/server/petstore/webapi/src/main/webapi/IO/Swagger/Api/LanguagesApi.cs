namespace Api.Controllers
{

    private IService<LanguagesApiService, LanguagesApiResults> _service;

    public LanguagesApiController(IService<LanguagesApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return a list of Languages 
    /// </summary>
    
    /// <returns>List<Language></returns>
    [HttpGET]
    [Route("/languages")]
    public List<Language> LanguagesGet () {

      

      var result = _service.LanguagesGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


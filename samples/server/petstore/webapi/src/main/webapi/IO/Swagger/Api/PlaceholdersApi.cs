namespace Api.Controllers
{

    private IService<PlaceholdersApiService, PlaceholdersApiResults> _service;

    public PlaceholdersApiController(IService<PlaceholdersApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return Placeholders 
    /// </summary>
    
    /// <returns>List<Placeholder></returns>
    [HttpGET]
    [Route("/placeholders")]
    public List<Placeholder> PlaceholdersGet () {

      

      var result = _service.PlaceholdersGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


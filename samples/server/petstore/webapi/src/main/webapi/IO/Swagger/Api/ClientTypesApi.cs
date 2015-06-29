namespace Api.Controllers
{

    private IService<ClientTypesApiService, ClientTypesApiResults> _service;

    public ClientTypesApiController(IService<ClientTypesApi> service)
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


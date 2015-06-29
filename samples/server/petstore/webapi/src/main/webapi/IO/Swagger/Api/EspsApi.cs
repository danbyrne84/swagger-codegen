namespace Api.Controllers
{

    private IService<EspsApiService, EspsApiResults> _service;

    public EspsApiController(IService<EspsApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return Esps for a given client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<Esp></returns>
    [HttpGET]
    [Route("/clients/{clientId}/esp")]
    public List<Esp> ClientsClientIdEspGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdEspGet");
      

      var result = _service.ClientsClientIdEspGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return all ESPs 
    /// </summary>
    
    /// <returns>List<Esp></returns>
    [HttpGET]
    [Route("/esp")]
    public List<Esp> EspGet () {

      

      var result = _service.EspGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Form Rows for an ESPs 
    /// </summary>
    /// <param name="EspId">Esp ID</param>
    /// <returns>List<EspFormRow></returns>
    [HttpGET]
    [Route("/esp/{espId}/formRows")]
    public List<EspFormRow> EspEspIdFormRowsGet (int? EspId) {

      
      // verify the required parameter 'EspId' is set
      if (EspId == null) throw new ApiException(400, "Missing required parameter 'EspId' when calling EspEspIdFormRowsGet");
      

      var result = _service.EspEspIdFormRowsGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


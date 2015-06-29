namespace Api.Controllers
{

    private IService<CurrenciesApiService, CurrenciesApiResults> _service;

    public CurrenciesApiController(IService<CurrenciesApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return a list of Currencies for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<Currency></returns>
    [HttpGET]
    [Route("/clients/{clientId}/currencies")]
    public List<Currency> ClientsClientIdCurrenciesGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesGet");
      

      var result = _service.ClientsClientIdCurrenciesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update Currency for specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="Currency"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}/currencies")]
    public void ClientsClientIdCurrenciesPut (int? ClientId, ClientCurrency Currency) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesPut");
      
      // verify the required parameter 'Currency' is set
      if (Currency == null) throw new ApiException(400, "Missing required parameter 'Currency' when calling ClientsClientIdCurrenciesPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a Currency to the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="Currency"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{clientId}/currencies")]
    public void ClientsClientIdCurrenciesPost (int? ClientId, ClientCurrency Currency) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesPost");
      
      // verify the required parameter 'Currency' is set
      if (Currency == null) throw new ApiException(400, "Missing required parameter 'Currency' when calling ClientsClientIdCurrenciesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Currency from the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="CurrencyId">Currency ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/currencies/{currencyId}")]
    public void ClientsClientIdCurrenciesCurrencyIdDelete (int? ClientId, int? CurrencyId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesCurrencyIdDelete");
      
      // verify the required parameter 'CurrencyId' is set
      if (CurrencyId == null) throw new ApiException(400, "Missing required parameter 'CurrencyId' when calling ClientsClientIdCurrenciesCurrencyIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a list of Currencies 
    /// </summary>
    
    /// <returns>List<Currency></returns>
    [HttpGET]
    [Route("/currencies")]
    public List<Currency> CurrenciesGet () {

      

      var result = _service.CurrenciesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create a new Currency 
    /// </summary>
    /// <param name="Currency"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/currencies")]
    public void CurrenciesPost (Currency Currency) {

      
      // verify the required parameter 'Currency' is set
      if (Currency == null) throw new ApiException(400, "Missing required parameter 'Currency' when calling CurrenciesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a currency 
    /// </summary>
    /// <param name="Id">Currency ID</param>
    /// <returns>Currency</returns>
    [HttpGET]
    [Route("/currencies/{id}")]
    public Currency CurrenciesIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling CurrenciesIdGet");
      

      var result = _service.CurrenciesIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Currency 
    /// </summary>
    /// <param name="Id">Currency ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/currencies/{id}")]
    public void CurrenciesIdDelete (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling CurrenciesIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


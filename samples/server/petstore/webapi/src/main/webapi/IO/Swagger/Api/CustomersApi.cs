namespace Api.Controllers
{

    private IService<CustomersApiService, CustomersApiResults> _service;

    public CustomersApiController(IService<CustomersApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return a Customer 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>Customer</returns>
    [HttpGET]
    [Route("/customers/{id}")]
    public Customer CustomersIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling CustomersIdGet");
      

      var result = _service.CustomersIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a Customer Summary 
    /// </summary>
    /// <param name="Id">Customer ID</param>
    /// <returns>CustomerSummary</returns>
    [HttpGET]
    [Route("/customers/{id}/summary")]
    public CustomerSummary CustomersIdSummaryGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling CustomersIdSummaryGet");
      

      var result = _service.CustomersIdSummaryGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


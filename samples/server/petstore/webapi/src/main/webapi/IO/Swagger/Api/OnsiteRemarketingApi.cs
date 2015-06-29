namespace Api.Controllers
{

    private IService<OnsiteRemarketingApiService, OnsiteRemarketingApiResults> _service;

    public OnsiteRemarketingApiController(IService<OnsiteRemarketingApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return Onsite Report 
    /// </summary>
    
    /// <returns>OnsiteReport</returns>
    [HttpGET]
    [Route("/reports/onsite")]
    public OnsiteReport ReportsOnsiteGet () {

      

      var result = _service.ReportsOnsiteGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


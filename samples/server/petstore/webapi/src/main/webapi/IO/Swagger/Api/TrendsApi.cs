namespace Api.Controllers
{

    private IService<TrendsApiService, TrendsApiResults> _service;

    public TrendsApiController(IService<TrendsApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return a Trends Report 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="StartDate">Start date of the trends report</param>/// <param name="EndDate">End date of the trends report</param>/// <param name="DatePart">Date part for the trends report</param>/// <param name="ItemCurrency">Item currency for the trends report</param>
    /// <returns>TrendsReport</returns>
    [HttpGET]
    [Route("/reports/trends")]
    public TrendsReport ReportsTrendsGet (int? ClientId, DateTime? StartDate, DateTime? EndDate, int? DatePart, int? ItemCurrency) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ReportsTrendsGet");
      
      // verify the required parameter 'StartDate' is set
      if (StartDate == null) throw new ApiException(400, "Missing required parameter 'StartDate' when calling ReportsTrendsGet");
      
      // verify the required parameter 'EndDate' is set
      if (EndDate == null) throw new ApiException(400, "Missing required parameter 'EndDate' when calling ReportsTrendsGet");
      
      // verify the required parameter 'DatePart' is set
      if (DatePart == null) throw new ApiException(400, "Missing required parameter 'DatePart' when calling ReportsTrendsGet");
      
      // verify the required parameter 'ItemCurrency' is set
      if (ItemCurrency == null) throw new ApiException(400, "Missing required parameter 'ItemCurrency' when calling ReportsTrendsGet");
      

      var result = _service.ReportsTrendsGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


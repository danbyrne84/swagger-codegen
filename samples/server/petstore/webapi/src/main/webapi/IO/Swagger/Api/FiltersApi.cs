namespace Api.Controllers
{

    private IService<FiltersApiService, FiltersApiResults> _service;

    public FiltersApiController(IService<FiltersApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Create a new filter 
    /// </summary>
    /// <param name="CycleId">Cycle ID</param>/// <param name="Filter"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/cycles/{cycleId}/filters")]
    public void CyclesCycleIdFiltersPost (int? CycleId, Filter Filter) {

      
      // verify the required parameter 'CycleId' is set
      if (CycleId == null) throw new ApiException(400, "Missing required parameter 'CycleId' when calling CyclesCycleIdFiltersPost");
      
      // verify the required parameter 'Filter' is set
      if (Filter == null) throw new ApiException(400, "Missing required parameter 'Filter' when calling CyclesCycleIdFiltersPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a filter by ID 
    /// </summary>
    /// <param name="CycleId">Cycle ID</param>/// <param name="FilterId">Filter ID</param>
    /// <returns>Filter</returns>
    [HttpGET]
    [Route("/cycles/{cycleId}/filters/{filterId}")]
    public Filter CyclesCycleIdFiltersFilterIdGet (int? CycleId, int? FilterId) {

      
      // verify the required parameter 'CycleId' is set
      if (CycleId == null) throw new ApiException(400, "Missing required parameter 'CycleId' when calling CyclesCycleIdFiltersFilterIdGet");
      
      // verify the required parameter 'FilterId' is set
      if (FilterId == null) throw new ApiException(400, "Missing required parameter 'FilterId' when calling CyclesCycleIdFiltersFilterIdGet");
      

      var result = _service.CyclesCycleIdFiltersFilterIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a filter 
    /// </summary>
    /// <param name="CycleId">Cycle ID</param>/// <param name="FilterId">Cycle ID</param>/// <param name="Filter"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/cycles/{cycleId}/filters/{filterId}")]
    public void CyclesCycleIdFiltersFilterIdPut (int? CycleId, int? FilterId, Filter Filter) {

      
      // verify the required parameter 'CycleId' is set
      if (CycleId == null) throw new ApiException(400, "Missing required parameter 'CycleId' when calling CyclesCycleIdFiltersFilterIdPut");
      
      // verify the required parameter 'FilterId' is set
      if (FilterId == null) throw new ApiException(400, "Missing required parameter 'FilterId' when calling CyclesCycleIdFiltersFilterIdPut");
      
      // verify the required parameter 'Filter' is set
      if (Filter == null) throw new ApiException(400, "Missing required parameter 'Filter' when calling CyclesCycleIdFiltersFilterIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a filter 
    /// </summary>
    /// <param name="CycleId">Cycle ID</param>/// <param name="FilterId">Filter ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/cycles/{cycleId}/filters/{filterId}")]
    public void CyclesCycleIdFiltersFilterIdDelete (int? CycleId, int? FilterId) {

      
      // verify the required parameter 'CycleId' is set
      if (CycleId == null) throw new ApiException(400, "Missing required parameter 'CycleId' when calling CyclesCycleIdFiltersFilterIdDelete");
      
      // verify the required parameter 'FilterId' is set
      if (FilterId == null) throw new ApiException(400, "Missing required parameter 'FilterId' when calling CyclesCycleIdFiltersFilterIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


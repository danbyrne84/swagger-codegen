namespace Api.Controllers
{

    private IService<CyclesApiService, CyclesApiResults> _service;

    public CyclesApiController(IService<CyclesApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return all Cycles for the specified Campaign 
    /// </summary>
    /// <param name="CampaignId">Campaign ID</param>
    /// <returns>List<Cycle></returns>
    [HttpGET]
    [Route("/campaigns/{campaignId}/cycles")]
    public List<Cycle> CampaignsCampaignIdCyclesGet (int? CampaignId) {

      
      // verify the required parameter 'CampaignId' is set
      if (CampaignId == null) throw new ApiException(400, "Missing required parameter 'CampaignId' when calling CampaignsCampaignIdCyclesGet");
      

      var result = _service.CampaignsCampaignIdCyclesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a Cycle within the specified Campaign 
    /// </summary>
    /// <param name="CampaignId">Campaign ID</param>/// <param name="Cycle"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/campaigns/{campaignId}/cycles")]
    public void CampaignsCampaignIdCyclesPut (int? CampaignId, Cycle Cycle) {

      
      // verify the required parameter 'CampaignId' is set
      if (CampaignId == null) throw new ApiException(400, "Missing required parameter 'CampaignId' when calling CampaignsCampaignIdCyclesPut");
      
      // verify the required parameter 'Cycle' is set
      if (Cycle == null) throw new ApiException(400, "Missing required parameter 'Cycle' when calling CampaignsCampaignIdCyclesPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a Cycle to the specified Campaign 
    /// </summary>
    /// <param name="CampaignId">Campaign ID</param>/// <param name="Cycle"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/campaigns/{campaignId}/cycles")]
    public void CampaignsCampaignIdCyclesPost (int? CampaignId, Cycle Cycle) {

      
      // verify the required parameter 'CampaignId' is set
      if (CampaignId == null) throw new ApiException(400, "Missing required parameter 'CampaignId' when calling CampaignsCampaignIdCyclesPost");
      
      // verify the required parameter 'Cycle' is set
      if (Cycle == null) throw new ApiException(400, "Missing required parameter 'Cycle' when calling CampaignsCampaignIdCyclesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Cycle from the specified Campaign 
    /// </summary>
    /// <param name="CampaignId">Campaign ID</param>/// <param name="CycleId">Cycle ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/campaigns/{campaignId}/cycles/{cycleId}")]
    public void CampaignsCampaignIdCyclesCycleIdDelete (int? CampaignId, int? CycleId) {

      
      // verify the required parameter 'CampaignId' is set
      if (CampaignId == null) throw new ApiException(400, "Missing required parameter 'CampaignId' when calling CampaignsCampaignIdCyclesCycleIdDelete");
      
      // verify the required parameter 'CycleId' is set
      if (CycleId == null) throw new ApiException(400, "Missing required parameter 'CycleId' when calling CampaignsCampaignIdCyclesCycleIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return  a collection of Filters from a Cycle 
    /// </summary>
    /// <param name="CycleId">Cycle ID</param>
    /// <returns>List<Filter></returns>
    [HttpGET]
    [Route("/cycles/{cycleId}/filters")]
    public List<Filter> CyclesCycleIdFiltersGet (int? CycleId) {

      
      // verify the required parameter 'CycleId' is set
      if (CycleId == null) throw new ApiException(400, "Missing required parameter 'CycleId' when calling CyclesCycleIdFiltersGet");
      

      var result = _service.CyclesCycleIdFiltersGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


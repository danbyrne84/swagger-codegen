namespace Api.Controllers
{

    private IService<CampaignsApiService, CampaignsApiResults> _service;

    public CampaignsApiController(IService<CampaignsApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return a list of Campaigns for an AB Test 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns>List<Campaign></returns>
    [HttpGET]
    [Route("/abTests/{id}/campaigns")]
    public List<Campaign> AbTestsIdCampaignsGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling AbTestsIdCampaignsGet");
      

      var result = _service.AbTestsIdCampaignsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create a new Campaign 
    /// </summary>
    /// <param name="Campaign"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/campaigns")]
    public void CampaignsPost (Campaign Campaign) {

      
      // verify the required parameter 'Campaign' is set
      if (Campaign == null) throw new ApiException(400, "Missing required parameter 'Campaign' when calling CampaignsPost");
      

      

      if(result == false)
          
      }

      
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
    /// Update a Split Test of a Campaign 
    /// </summary>
    /// <param name="CampaignId">Campaign ID</param>/// <param name="SplitTestId">Split Test ID</param>/// <param name="SplitTest"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/campaigns/{campaignId}/splitTests/{splitTestId}")]
    public void CampaignsCampaignIdSplitTestsSplitTestIdPut (int? CampaignId, int? SplitTestId, CampaignSplitTest SplitTest) {

      
      // verify the required parameter 'CampaignId' is set
      if (CampaignId == null) throw new ApiException(400, "Missing required parameter 'CampaignId' when calling CampaignsCampaignIdSplitTestsSplitTestIdPut");
      
      // verify the required parameter 'SplitTestId' is set
      if (SplitTestId == null) throw new ApiException(400, "Missing required parameter 'SplitTestId' when calling CampaignsCampaignIdSplitTestsSplitTestIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update the priority of a Campaign 
    /// </summary>
    /// <param name="Id">Campaign ID</param>/// <param name="Move"></param>
    /// <returns></returns>
    [HttpPATCH]
    [Route("/campaigns/{id}")]
    public void CampaignsIdPatch (int? Id, Campaign Move) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling CampaignsIdPatch");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete all archived Campaigns for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/campaignArchive")]
    public void ClientsClientIdCampaignArchiveDelete (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCampaignArchiveDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return all Campaigns for specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="Archived">Include Archived Campaigns</param>/// <param name="Active">Include Active Campaigns</param>
    /// <returns>List<Campaign></returns>
    [HttpGET]
    [Route("/clients/{clientId}/campaigns")]
    public List<Campaign> ClientsClientIdCampaignsGet (int? ClientId, bool? Archived, bool? Active) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCampaignsGet");
      

      var result = _service.ClientsClientIdCampaignsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Campaign Overview Chart 
    /// </summary>
    
    /// <returns>List<CampaignOverviewEntry></returns>
    [HttpGET]
    [Route("/reports/campaigns")]
    public List<CampaignOverviewEntry> ReportsCampaignsGet () {

      

      var result = _service.ReportsCampaignsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Performance Report 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="CampaignId">Campaign ID</param>/// <param name="StartDate">Start Date to filter the campaigns from this date</param>/// <param name="EndDate">End Date to filter the campaigns to this date</param>
    /// <returns>List<PerformanceReportEntry></returns>
    [HttpGET]
    [Route("/reports/performance")]
    public List<PerformanceReportEntry> ReportsPerformanceGet (int? ClientId, int? CampaignId, DateTime? StartDate, DateTime? EndDate) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ReportsPerformanceGet");
      
      // verify the required parameter 'CampaignId' is set
      if (CampaignId == null) throw new ApiException(400, "Missing required parameter 'CampaignId' when calling ReportsPerformanceGet");
      

      var result = _service.ReportsPerformanceGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


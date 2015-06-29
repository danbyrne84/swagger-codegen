namespace Api.Controllers
{

    private IService<SplitTestsApiService, SplitTestsApiResults> _service;

    public SplitTestsApiController(IService<SplitTestsApi> service)
    {
        _service = service;
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
    /// Return a collection of split tests for a client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="IncludeArchived">Flag to include acrchived split tests</param>/// <param name="IncludeActiveOnly">Flag to include active only split tests</param>
    /// <returns>List<CampaignSplitTest></returns>
    [HttpGET]
    [Route("/clients/{clientId}/splitTests")]
    public List<CampaignSplitTest> ClientsClientIdSplitTestsGet (int? ClientId, bool? IncludeArchived, bool? IncludeActiveOnly) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdSplitTestsGet");
      

      var result = _service.ClientsClientIdSplitTestsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Split Test by ID 
    /// </summary>
    /// <param name="SplitTestId">Split Test ID</param>
    /// <returns>List<SplitTestReport></returns>
    [HttpGET]
    [Route("/reports/splitTest/{splitTestId}")]
    public List<SplitTestReport> ReportsSplitTestSplitTestIdGet (int? SplitTestId) {

      
      // verify the required parameter 'SplitTestId' is set
      if (SplitTestId == null) throw new ApiException(400, "Missing required parameter 'SplitTestId' when calling ReportsSplitTestSplitTestIdGet");
      

      var result = _service.ReportsSplitTestSplitTestIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create a new split test 
    /// </summary>
    /// <param name="SplitTest"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/splitTests")]
    public void SplitTestsPost (CampaignSplitTest SplitTest) {

      
      // verify the required parameter 'SplitTest' is set
      if (SplitTest == null) throw new ApiException(400, "Missing required parameter 'SplitTest' when calling SplitTestsPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Gets a specific Split Test 
    /// </summary>
    /// <param name="Id">Split Test ID</param>
    /// <returns>Object</returns>
    [HttpGET]
    [Route("/splitTests/{id}")]
    public Object SplitTestsIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling SplitTestsIdGet");
      

      var result = _service.SplitTestsIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    ///  Update a split test\n
    /// </summary>
    /// <param name="Id">Split Test ID</param>/// <param name="SplitTest"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/splitTests/{id}")]
    public void SplitTestsIdPut (int? Id, CampaignSplitTest SplitTest) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling SplitTestsIdPut");
      
      // verify the required parameter 'SplitTest' is set
      if (SplitTest == null) throw new ApiException(400, "Missing required parameter 'SplitTest' when calling SplitTestsIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Split Test 
    /// </summary>
    /// <param name="Id">The Split Test ID to delete</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/splitTests/{id}")]
    public void SplitTestsIdDelete (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling SplitTestsIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


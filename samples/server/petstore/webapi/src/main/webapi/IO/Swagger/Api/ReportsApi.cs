namespace Api.Controllers
{

    private IService<ReportsApiService, ReportsApiResults> _service;

    public ReportsApiController(IService<ReportsApi> service)
    {
        _service = service;
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
    
    /// <summary>
    /// Return Overview Report 
    /// </summary>
    
    /// <returns>OverviewReport</returns>
    [HttpGET]
    [Route("/reports/overview")]
    public OverviewReport ReportsOverviewGet () {

      

      var result = _service.ReportsOverviewGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Report parts 
    /// </summary>
    
    /// <returns>List<ReportPart></returns>
    [HttpGET]
    [Route("/reports/parts")]
    public List<ReportPart> ReportsPartsGet () {

      

      var result = _service.ReportsPartsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return report part by ID 
    /// </summary>
    /// <param name="ReportPartId">Report ID</param>
    /// <returns>ReportPart</returns>
    [HttpGET]
    [Route("/reports/parts/{reportPartId}")]
    public ReportPart ReportsPartsReportPartIdGet (int? ReportPartId) {

      
      // verify the required parameter 'ReportPartId' is set
      if (ReportPartId == null) throw new ApiException(400, "Missing required parameter 'ReportPartId' when calling ReportsPartsReportPartIdGet");
      

      var result = _service.ReportsPartsReportPartIdGet();

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
    
    /// <summary>
    /// Return a user reports for the current user 
    /// </summary>
    
    /// <returns></returns>
    [HttpGET]
    [Route("/reports/userReportParts")]
    public void ReportsUserReportPartsGet () {

      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add A Report Item 
    /// </summary>
    /// <param name="Report"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/reports/userReportParts")]
    public void ReportsUserReportPartsPost (AddUserReportPart Report) {

      
      // verify the required parameter 'Report' is set
      if (Report == null) throw new ApiException(400, "Missing required parameter 'Report' when calling ReportsUserReportPartsPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a User Report Part 
    /// </summary>
    /// <param name="PartId">Report part ID</param>
    /// <returns>List<UserReportPart></returns>
    [HttpGET]
    [Route("/reports/userReportParts/{partId}")]
    public List<UserReportPart> ReportsUserReportPartsPartIdGet (int? PartId) {

      
      // verify the required parameter 'PartId' is set
      if (PartId == null) throw new ApiException(400, "Missing required parameter 'PartId' when calling ReportsUserReportPartsPartIdGet");
      

      var result = _service.ReportsUserReportPartsPartIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete Report Parts for a User Report 
    /// </summary>
    /// <param name="PartId">Report ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/reports/userReportParts/{partId}")]
    public void ReportsUserReportPartsPartIdDelete (int? PartId) {

      
      // verify the required parameter 'PartId' is set
      if (PartId == null) throw new ApiException(400, "Missing required parameter 'PartId' when calling ReportsUserReportPartsPartIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return User Reports for a given user 
    /// </summary>
    
    /// <returns>UserReport</returns>
    [HttpGET]
    [Route("/reports/userReports")]
    public UserReport ReportsUserReportsGet () {

      

      var result = _service.ReportsUserReportsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return the Users default report 
    /// </summary>
    
    /// <returns>UserReport</returns>
    [HttpGET]
    [Route("/reports/userReports/default/")]
    public UserReport ReportsUserReportsDefaultGet () {

      

      var result = _service.ReportsUserReportsDefaultGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create a User Report 
    /// </summary>
    /// <param name="UserReport"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/reports/userReports/default/")]
    public void ReportsUserReportsDefaultPost (UserReport UserReport) {

      
      // verify the required parameter 'UserReport' is set
      if (UserReport == null) throw new ApiException(400, "Missing required parameter 'UserReport' when calling ReportsUserReportsDefaultPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return User Report by ID 
    /// </summary>
    /// <param name="ReportId">Report ID</param>
    /// <returns>UserReport</returns>
    [HttpGET]
    [Route("/reports/userReports/{reportId}")]
    public UserReport ReportsUserReportsReportIdGet (int? ReportId) {

      
      // verify the required parameter 'ReportId' is set
      if (ReportId == null) throw new ApiException(400, "Missing required parameter 'ReportId' when calling ReportsUserReportsReportIdGet");
      

      var result = _service.ReportsUserReportsReportIdGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


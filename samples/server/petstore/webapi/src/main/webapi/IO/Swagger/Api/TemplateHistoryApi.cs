namespace Api.Controllers
{

    private IService<TemplateHistoryApiService, TemplateHistoryApiResults> _service;

    public TemplateHistoryApiController(IService<TemplateHistoryApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return a history of Templates for specified Template 
    /// </summary>
    /// <param name="Id">Template ID</param>
    /// <returns>List<TemplateHistory></returns>
    [HttpGET]
    [Route("/templates/{id}/history")]
    public List<TemplateHistory> TemplatesIdHistoryGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling TemplatesIdHistoryGet");
      

      var result = _service.TemplatesIdHistoryGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a previous version of the specified Template 
    /// </summary>
    /// <param name="TemplateId">Template ID</param>/// <param name="TemplateHistoryId">Template History ID</param>
    /// <returns>TemplateHistory</returns>
    [HttpGET]
    [Route("/templates/{templateId}/history/{templateHistoryId}")]
    public TemplateHistory TemplatesTemplateIdHistoryTemplateHistoryIdGet (int? TemplateId, int? TemplateHistoryId) {

      
      // verify the required parameter 'TemplateId' is set
      if (TemplateId == null) throw new ApiException(400, "Missing required parameter 'TemplateId' when calling TemplatesTemplateIdHistoryTemplateHistoryIdGet");
      
      // verify the required parameter 'TemplateHistoryId' is set
      if (TemplateHistoryId == null) throw new ApiException(400, "Missing required parameter 'TemplateHistoryId' when calling TemplatesTemplateIdHistoryTemplateHistoryIdGet");
      

      var result = _service.TemplatesTemplateIdHistoryTemplateHistoryIdGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


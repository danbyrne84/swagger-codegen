namespace Api.Controllers
{

    private IService<TemplatesApiService, TemplatesApiResults> _service;

    public TemplatesApiController(IService<TemplatesApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return all Template Categories for a given client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<TemplateCategory></returns>
    [HttpGET]
    [Route("/clients/{clientId}/templateCategories")]
    public List<TemplateCategory> ClientsClientIdTemplateCategoriesGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplateCategoriesGet");
      

      var result = _service.ClientsClientIdTemplateCategoriesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a Template Category to the client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="TemplateCategory"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{clientId}/templateCategories")]
    public void ClientsClientIdTemplateCategoriesPost (int? ClientId, TemplateCategory TemplateCategory) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplateCategoriesPost");
      
      // verify the required parameter 'TemplateCategory' is set
      if (TemplateCategory == null) throw new ApiException(400, "Missing required parameter 'TemplateCategory' when calling ClientsClientIdTemplateCategoriesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Template Category for the specified client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="TemplateCategoryId">Template Category ID</param>
    /// <returns>TemplateCategory</returns>
    [HttpGET]
    [Route("/clients/{clientId}/templateCategories/{templateCategoryId}")]
    public TemplateCategory ClientsClientIdTemplateCategoriesTemplateCategoryIdGet (int? ClientId, int? TemplateCategoryId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdGet");
      
      // verify the required parameter 'TemplateCategoryId' is set
      if (TemplateCategoryId == null) throw new ApiException(400, "Missing required parameter 'TemplateCategoryId' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdGet");
      

      var result = _service.ClientsClientIdTemplateCategoriesTemplateCategoryIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a Template Category for a client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="TemplateCategoryId">Template Category ID</param>/// <param name="ClientTemplateCategory"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}/templateCategories/{templateCategoryId}")]
    public void ClientsClientIdTemplateCategoriesTemplateCategoryIdPut (int? ClientId, int? TemplateCategoryId, TemplateCategory ClientTemplateCategory) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdPut");
      
      // verify the required parameter 'TemplateCategoryId' is set
      if (TemplateCategoryId == null) throw new ApiException(400, "Missing required parameter 'TemplateCategoryId' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdPut");
      
      // verify the required parameter 'ClientTemplateCategory' is set
      if (ClientTemplateCategory == null) throw new ApiException(400, "Missing required parameter 'ClientTemplateCategory' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Template Category from a client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="TemplateCategoryId">Template Category ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/templateCategories/{templateCategoryId}")]
    public void ClientsClientIdTemplateCategoriesTemplateCategoryIdDelete (int? ClientId, int? TemplateCategoryId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdDelete");
      
      // verify the required parameter 'TemplateCategoryId' is set
      if (TemplateCategoryId == null) throw new ApiException(400, "Missing required parameter 'TemplateCategoryId' when calling ClientsClientIdTemplateCategoriesTemplateCategoryIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a list of Templates for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="Type">Template Type Filter</param>/// <param name="Name">Template Name Filter</param>/// <param name="Keywords">Template Keywords Filter</param>/// <param name="CampaignId">Template Campaign Filter</param>
    /// <returns>List<ContentTemplate></returns>
    [HttpGET]
    [Route("/clients/{clientId}/templates")]
    public List<ContentTemplate> ClientsClientIdTemplatesGet (int? ClientId, string Type, string Name, string Keywords, int? CampaignId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplatesGet");
      

      var result = _service.ClientsClientIdTemplatesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a collection of Hitmap Stats 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="TemplateId">Template ID</param>/// <param name="StartTime">Start Time</param>/// <param name="EndTime">End Time</param>
    /// <returns>List<TemplateHitmapStats></returns>
    [HttpGET]
    [Route("/clients/{clientId}/templates/{templateId}/hitmapStats")]
    public List<TemplateHitmapStats> ClientsClientIdTemplatesTemplateIdHitmapStatsGet (int? ClientId, int? TemplateId, DateTime? StartTime, DateTime? EndTime) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdTemplatesTemplateIdHitmapStatsGet");
      
      // verify the required parameter 'TemplateId' is set
      if (TemplateId == null) throw new ApiException(400, "Missing required parameter 'TemplateId' when calling ClientsClientIdTemplatesTemplateIdHitmapStatsGet");
      
      // verify the required parameter 'StartTime' is set
      if (StartTime == null) throw new ApiException(400, "Missing required parameter 'StartTime' when calling ClientsClientIdTemplatesTemplateIdHitmapStatsGet");
      
      // verify the required parameter 'EndTime' is set
      if (EndTime == null) throw new ApiException(400, "Missing required parameter 'EndTime' when calling ClientsClientIdTemplatesTemplateIdHitmapStatsGet");
      

      var result = _service.ClientsClientIdTemplatesTemplateIdHitmapStatsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add an Unsubscribe Template to the specified Client 
    /// </summary>
    /// <param name="Id">Client ID</param>/// <param name="UnsubscribeTemplate"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{id}/unsubscribeTemplates")]
    public void ClientsIdUnsubscribeTemplatesPost (int? Id, UnsubscribeTemplate UnsubscribeTemplate) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ClientsIdUnsubscribeTemplatesPost");
      
      // verify the required parameter 'UnsubscribeTemplate' is set
      if (UnsubscribeTemplate == null) throw new ApiException(400, "Missing required parameter 'UnsubscribeTemplate' when calling ClientsIdUnsubscribeTemplatesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create a new Template 
    /// </summary>
    /// <param name="Template"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/templates")]
    public void TemplatesPost (CreateTemplate Template) {

      
      // verify the required parameter 'Template' is set
      if (Template == null) throw new ApiException(400, "Missing required parameter 'Template' when calling TemplatesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a Template 
    /// </summary>
    /// <param name="Id">Template ID</param>
    /// <returns>ContentTemplate</returns>
    [HttpGET]
    [Route("/templates/{id}")]
    public ContentTemplate TemplatesIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling TemplatesIdGet");
      

      var result = _service.TemplatesIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a Template 
    /// </summary>
    /// <param name="Id">Template ID</param>/// <param name="Template"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/templates/{id}")]
    public void TemplatesIdPut (int? Id, ContentTemplate Template) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling TemplatesIdPut");
      
      // verify the required parameter 'Template' is set
      if (Template == null) throw new ApiException(400, "Missing required parameter 'Template' when calling TemplatesIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete the specified Template 
    /// </summary>
    /// <param name="Id">Template ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/templates/{id}")]
    public void TemplatesIdDelete (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling TemplatesIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a Template 
    /// </summary>
    /// <param name="Id">Template ID</param>/// <param name="Template"></param>
    /// <returns></returns>
    [HttpPATCH]
    [Route("/templates/{id}")]
    public void TemplatesIdPatch (int? Id, ContentTemplate Template) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling TemplatesIdPatch");
      
      // verify the required parameter 'Template' is set
      if (Template == null) throw new ApiException(400, "Missing required parameter 'Template' when calling TemplatesIdPatch");
      

      

      if(result == false)
          
      }

      
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
    /// Return the in use templates for the specified Template 
    /// </summary>
    /// <param name="Id">Template ID</param>
    /// <returns>TemplateInUse</returns>
    [HttpGET]
    [Route("/templates/{id}/inUse")]
    public TemplateInUse TemplatesIdInUseGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling TemplatesIdInUseGet");
      

      var result = _service.TemplatesIdInUseGet();

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


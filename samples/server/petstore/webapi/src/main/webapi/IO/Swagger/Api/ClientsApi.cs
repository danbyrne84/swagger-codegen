namespace Api.Controllers
{

    private IService<ClientsApiService, ClientsApiResults> _service;

    public ClientsApiController(IService<ClientsApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return Client Tree 
    /// </summary>
    /// <param name="ClientId">ID of the root client</param>/// <param name="LiveClientsOnly">Whether or not only live clients are required</param>/// <param name="TypeId">The type of clients to recover</param>
    /// <returns>List<ClientTreeNode></returns>
    [HttpGET]
    [Route("/clientTree")]
    public List<ClientTreeNode> ClientTreeGet (int? ClientId, bool? LiveClientsOnly, int? TypeId) {

      

      var result = _service.ClientTreeGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Clients 
    /// </summary>
    /// <param name="Status">Status code of client</param>/// <param name="TypeId">Type ID of client</param>/// <param name="Fields">Fields to recover</param>/// <param name="Level">Level to recover clients from</param>
    /// <returns>List<Client></returns>
    [HttpGET]
    [Route("/clients")]
    public List<Client> ClientsGet (int? Status, int? TypeId, string Fields, int? Level) {

      

      var result = _service.ClientsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create Client 
    /// </summary>
    /// <param name="Client"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients")]
    public void ClientsPost (BasicClient Client) {

      
      // verify the required parameter 'Client' is set
      if (Client == null) throw new ApiException(400, "Missing required parameter 'Client' when calling ClientsPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Get Client by ID 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>Client</returns>
    [HttpGET]
    [Route("/clients/{clientId}")]
    public Client ClientsClientIdGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdGet");
      

      var result = _service.ClientsClientIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update Client Details 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="ClientDetails"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}")]
    public void ClientsClientIdPut (int? ClientId, ClientDetails ClientDetails) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdPut");
      
      // verify the required parameter 'ClientDetails' is set
      if (ClientDetails == null) throw new ApiException(400, "Missing required parameter 'ClientDetails' when calling ClientsClientIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete Client 
    /// </summary>
    /// <param name="ClientId">ID of client to delete</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}")]
    public void ClientsClientIdDelete (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update Partial Client Details 
    /// </summary>
    /// <param name="ClientId">ID of client to update</param>/// <param name="ClientDetails"></param>
    /// <returns></returns>
    [HttpPATCH]
    [Route("/clients/{clientId}")]
    public void ClientsClientIdPatch (int? ClientId, ClientDetails ClientDetails) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdPatch");
      
      // verify the required parameter 'ClientDetails' is set
      if (ClientDetails == null) throw new ApiException(400, "Missing required parameter 'ClientDetails' when calling ClientsClientIdPatch");
      

      

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
    /// Return a list of Currencies for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<Currency></returns>
    [HttpGET]
    [Route("/clients/{clientId}/currencies")]
    public List<Currency> ClientsClientIdCurrenciesGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesGet");
      

      var result = _service.ClientsClientIdCurrenciesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update Currency for specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="Currency"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}/currencies")]
    public void ClientsClientIdCurrenciesPut (int? ClientId, ClientCurrency Currency) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesPut");
      
      // verify the required parameter 'Currency' is set
      if (Currency == null) throw new ApiException(400, "Missing required parameter 'Currency' when calling ClientsClientIdCurrenciesPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a Currency to the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="Currency"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{clientId}/currencies")]
    public void ClientsClientIdCurrenciesPost (int? ClientId, ClientCurrency Currency) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesPost");
      
      // verify the required parameter 'Currency' is set
      if (Currency == null) throw new ApiException(400, "Missing required parameter 'Currency' when calling ClientsClientIdCurrenciesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Currency from the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="CurrencyId">Currency ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/currencies/{currencyId}")]
    public void ClientsClientIdCurrenciesCurrencyIdDelete (int? ClientId, int? CurrencyId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdCurrenciesCurrencyIdDelete");
      
      // verify the required parameter 'CurrencyId' is set
      if (CurrencyId == null) throw new ApiException(400, "Missing required parameter 'CurrencyId' when calling ClientsClientIdCurrenciesCurrencyIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Client response methods 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<ResponseMethod></returns>
    [HttpGET]
    [Route("/clients/{clientId}/responseMethods")]
    public List<ResponseMethod> ClientsClientIdResponseMethodsGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdResponseMethodsGet");
      

      var result = _service.ClientsClientIdResponseMethodsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a response method to a Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="ClientResponseMethod"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{clientId}/responseMethods")]
    public void ClientsClientIdResponseMethodsPost (int? ClientId, ClientResponseMethod ClientResponseMethod) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdResponseMethodsPost");
      
      // verify the required parameter 'ClientResponseMethod' is set
      if (ClientResponseMethod == null) throw new ApiException(400, "Missing required parameter 'ClientResponseMethod' when calling ClientsClientIdResponseMethodsPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Response Method from a Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="ResponseMethodId">Unsubscribe Template ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/responseMethods/{responseMethodId}")]
    public void ClientsClientIdResponseMethodsResponseMethodIdDelete (int? ClientId, int? ResponseMethodId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdResponseMethodsResponseMethodIdDelete");
      
      // verify the required parameter 'ResponseMethodId' is set
      if (ResponseMethodId == null) throw new ApiException(400, "Missing required parameter 'ResponseMethodId' when calling ClientsClientIdResponseMethodsResponseMethodIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Retargeting Rules for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<RetargetingRule></returns>
    [HttpGET]
    [Route("/clients/{clientId}/retargetingRules")]
    public List<RetargetingRule> ClientsClientIdRetargetingRulesGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdRetargetingRulesGet");
      

      var result = _service.ClientsClientIdRetargetingRulesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a Retargeting Rule to the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="RetargetingRule"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{clientId}/retargetingRules")]
    public void ClientsClientIdRetargetingRulesPost (int? ClientId, ClientRetargetingRule RetargetingRule) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdRetargetingRulesPost");
      
      // verify the required parameter 'RetargetingRule' is set
      if (RetargetingRule == null) throw new ApiException(400, "Missing required parameter 'RetargetingRule' when calling ClientsClientIdRetargetingRulesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete Retargeting Rules from the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/retargetingRules")]
    public void ClientsClientIdRetargetingRulesDelete (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdRetargetingRulesDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a Retargeting Rule for the specified Client 
    /// </summary>
    /// <param name="RuleId">Rule ID</param>/// <param name="ClientId">Client ID</param>/// <param name="RetargetingRule"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}/retargetingRules/{ruleId}")]
    public void ClientsClientIdRetargetingRulesRuleIdPut (int? RuleId, int? ClientId, ClientRetargetingRule RetargetingRule) {

      
      // verify the required parameter 'RuleId' is set
      if (RuleId == null) throw new ApiException(400, "Missing required parameter 'RuleId' when calling ClientsClientIdRetargetingRulesRuleIdPut");
      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdRetargetingRulesRuleIdPut");
      
      // verify the required parameter 'RetargetingRule' is set
      if (RetargetingRule == null) throw new ApiException(400, "Missing required parameter 'RetargetingRule' when calling ClientsClientIdRetargetingRulesRuleIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return all sectors for a given client. 
    /// </summary>
    /// <param name="ClientId">Client ID</param>
    /// <returns>List<Sector></returns>
    [HttpGET]
    [Route("/clients/{clientId}/sectors")]
    public List<Sector> ClientsClientIdSectorsGet (int? ClientId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdSectorsGet");
      

      var result = _service.ClientsClientIdSectorsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a sector to the client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="ClientSector"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{clientId}/sectors")]
    public void ClientsClientIdSectorsPost (int? ClientId, ClientSector ClientSector) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdSectorsPost");
      
      // verify the required parameter 'ClientSector' is set
      if (ClientSector == null) throw new ApiException(400, "Missing required parameter 'ClientSector' when calling ClientsClientIdSectorsPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a sector from a client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="SectorId">Sector ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/sectors/{sectorId}")]
    public void ClientsClientIdSectorsSectorIdDelete (int? ClientId, int? SectorId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdSectorsSectorIdDelete");
      
      // verify the required parameter 'SectorId' is set
      if (SectorId == null) throw new ApiException(400, "Missing required parameter 'SectorId' when calling ClientsClientIdSectorsSectorIdDelete");
      

      

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
    /// Get an Unsubscribe Template for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="UnsubscribeTemplateId">Unsubscribed Template ID</param>
    /// <returns>UnsubscribeTemplate</returns>
    [HttpGET]
    [Route("/clients/{clientId}/unsubscribeTemplates/{unsubscribeTemplateId}")]
    public UnsubscribeTemplate ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdGet (int? ClientId, int? UnsubscribeTemplateId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdGet");
      
      // verify the required parameter 'UnsubscribeTemplateId' is set
      if (UnsubscribeTemplateId == null) throw new ApiException(400, "Missing required parameter 'UnsubscribeTemplateId' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdGet");
      

      var result = _service.ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update an Unsubscribe Template for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="UnsubscribeTemplateId">Unsubscribe Template ID</param>/// <param name="UnsubscribeTemplate"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}/unsubscribeTemplates/{unsubscribeTemplateId}")]
    public void ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdPut (int? ClientId, int? UnsubscribeTemplateId, UnsubscribeTemplate UnsubscribeTemplate) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdPut");
      
      // verify the required parameter 'UnsubscribeTemplateId' is set
      if (UnsubscribeTemplateId == null) throw new ApiException(400, "Missing required parameter 'UnsubscribeTemplateId' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdPut");
      
      // verify the required parameter 'UnsubscribeTemplate' is set
      if (UnsubscribeTemplate == null) throw new ApiException(400, "Missing required parameter 'UnsubscribeTemplate' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete an Unsubscribe Template 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="UnsubscribeTemplateId">Unsubscribe Template ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/unsubscribeTemplates/{unsubscribeTemplateId}")]
    public void ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdDelete (int? ClientId, int? UnsubscribeTemplateId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdDelete");
      
      // verify the required parameter 'UnsubscribeTemplateId' is set
      if (UnsubscribeTemplateId == null) throw new ApiException(400, "Missing required parameter 'UnsubscribeTemplateId' when calling ClientsClientIdUnsubscribeTemplatesUnsubscribeTemplateIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a URL for the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="UrlId">URL ID</param>/// <param name="ClientUrl"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/clients/{clientId}/urls/{urlId}")]
    public void ClientsClientIdUrlsUrlIdPut (int? ClientId, int? UrlId, ClientUrl ClientUrl) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdUrlsUrlIdPut");
      
      // verify the required parameter 'UrlId' is set
      if (UrlId == null) throw new ApiException(400, "Missing required parameter 'UrlId' when calling ClientsClientIdUrlsUrlIdPut");
      
      // verify the required parameter 'ClientUrl' is set
      if (ClientUrl == null) throw new ApiException(400, "Missing required parameter 'ClientUrl' when calling ClientsClientIdUrlsUrlIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a URL from the specified Client 
    /// </summary>
    /// <param name="ClientId">Client ID</param>/// <param name="UrlId">URL ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/clients/{clientId}/urls/{urlId}")]
    public void ClientsClientIdUrlsUrlIdDelete (int? ClientId, int? UrlId) {

      
      // verify the required parameter 'ClientId' is set
      if (ClientId == null) throw new ApiException(400, "Missing required parameter 'ClientId' when calling ClientsClientIdUrlsUrlIdDelete");
      
      // verify the required parameter 'UrlId' is set
      if (UrlId == null) throw new ApiException(400, "Missing required parameter 'UrlId' when calling ClientsClientIdUrlsUrlIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a list of Unsubscribe Templates for the specified Client 
    /// </summary>
    /// <param name="Id">Client ID</param>
    /// <returns>List<UnsubscribeTemplate></returns>
    [HttpGET]
    [Route("/clients/{id}/unsubscribeTemplates")]
    public List<UnsubscribeTemplate> ClientsIdUnsubscribeTemplatesGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ClientsIdUnsubscribeTemplatesGet");
      

      var result = _service.ClientsIdUnsubscribeTemplatesGet();

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
    /// Return a list of URLs for the specified Client 
    /// </summary>
    /// <param name="Id">Client ID</param>
    /// <returns>List<Url></returns>
    [HttpGET]
    [Route("/clients/{id}/urls")]
    public List<Url> ClientsIdUrlsGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ClientsIdUrlsGet");
      

      var result = _service.ClientsIdUrlsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Get all Users for the specified Client 
    /// </summary>
    /// <param name="Id">Client ID</param>
    /// <returns>List<User></returns>
    [HttpGET]
    [Route("/clients/{id}/users")]
    public List<User> ClientsIdUsersGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ClientsIdUsersGet");
      

      var result = _service.ClientsIdUsersGet();

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
    /// Return all sectors 
    /// </summary>
    
    /// <returns>List<Sector></returns>
    [HttpGET]
    [Route("/sectors")]
    public List<Sector> SectorsGet () {

      

      var result = _service.SectorsGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


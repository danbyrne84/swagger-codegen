namespace Api.Controllers
{

    private IService<RetargetingRulesApiService, RetargetingRulesApiResults> _service;

    public RetargetingRulesApiController(IService<RetargetingRulesApi> service)
    {
        _service = service;
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
    /// Return Common Retargeting Rules 
    /// </summary>
    
    /// <returns>List<CommonRetargetingRule></returns>
    [HttpGET]
    [Route("/commonRetargetingRules")]
    public List<CommonRetargetingRule> CommonRetargetingRulesGet () {

      

      var result = _service.CommonRetargetingRulesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return Common Retargeting Rule 
    /// </summary>
    /// <param name="Id">Retargeting Rule ID</param>
    /// <returns>CommonRetargetingRule</returns>
    [HttpGET]
    [Route("/commonRetargetingRules/{id}")]
    public CommonRetargetingRule CommonRetargetingRulesIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling CommonRetargetingRulesIdGet");
      

      var result = _service.CommonRetargetingRulesIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a list of Retargeting Rule Validations 
    /// </summary>
    
    /// <returns>List<RetargetingRuleValidation></returns>
    [HttpGET]
    [Route("/retargetingRuleValidations")]
    public List<RetargetingRuleValidation> RetargetingRuleValidationsGet () {

      

      var result = _service.RetargetingRuleValidationsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a Retargeting Rule Validation 
    /// </summary>
    /// <param name="Id">Retargeting Rule Validation ID</param>
    /// <returns>RetargetingRuleValidation</returns>
    [HttpGET]
    [Route("/retargetingRuleValidations/{id}")]
    public RetargetingRuleValidation RetargetingRuleValidationsIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling RetargetingRuleValidationsIdGet");
      

      var result = _service.RetargetingRuleValidationsIdGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


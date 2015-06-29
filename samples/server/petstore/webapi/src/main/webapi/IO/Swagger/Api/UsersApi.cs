namespace Api.Controllers
{

    private IService<UsersApiService, UsersApiResults> _service;

    public UsersApiController(IService<UsersApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Add a URL to the specified Client 
    /// </summary>
    /// <param name="Id">Client ID</param>/// <param name="ClientUrl"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/clients/{id}/urls")]
    public void ClientsIdUrlsPost (int? Id, ClientUrl ClientUrl) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling ClientsIdUrlsPost");
      
      // verify the required parameter 'ClientUrl' is set
      if (ClientUrl == null) throw new ApiException(400, "Missing required parameter 'ClientUrl' when calling ClientsIdUrlsPost");
      

      

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
    /// Add a User to a Group 
    /// </summary>
    /// <param name="GroupId">Group ID</param>/// <param name="User"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/groups/{groupId}/users")]
    public void GroupsGroupIdUsersPost (int? GroupId, GroupUser User) {

      
      // verify the required parameter 'GroupId' is set
      if (GroupId == null) throw new ApiException(400, "Missing required parameter 'GroupId' when calling GroupsGroupIdUsersPost");
      
      // verify the required parameter 'User' is set
      if (User == null) throw new ApiException(400, "Missing required parameter 'User' when calling GroupsGroupIdUsersPost");
      

      

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
    
    /// <summary>
    /// Return all Users 
    /// </summary>
    
    /// <returns>List<User></returns>
    [HttpGET]
    [Route("/users")]
    public List<User> UsersGet () {

      

      var result = _service.UsersGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Create a new User 
    /// </summary>
    /// <param name="User"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/users")]
    public void UsersPost (User User) {

      
      // verify the required parameter 'User' is set
      if (User == null) throw new ApiException(400, "Missing required parameter 'User' when calling UsersPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a User 
    /// </summary>
    /// <param name="Id">User ID</param>
    /// <returns>User</returns>
    [HttpGET]
    [Route("/users/{id}")]
    public User UsersIdGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling UsersIdGet");
      

      var result = _service.UsersIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a User 
    /// </summary>
    /// <param name="Id">User ID</param>/// <param name="User"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/users/{id}")]
    public void UsersIdPut (int? Id, User User) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling UsersIdPut");
      
      // verify the required parameter 'User' is set
      if (User == null) throw new ApiException(400, "Missing required parameter 'User' when calling UsersIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a User 
    /// </summary>
    /// <param name="Id">User ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/users/{id}")]
    public void UsersIdDelete (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling UsersIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Get all Roles for the specified User 
    /// </summary>
    /// <param name="Id">User ID</param>
    /// <returns>List<Role></returns>
    [HttpGET]
    [Route("/users/{id}/roles")]
    public List<Role> UsersIdRolesGet (int? Id) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling UsersIdRolesGet");
      

      var result = _service.UsersIdRolesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a role to the specified User 
    /// </summary>
    /// <param name="Id">User ID</param>/// <param name="Role"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/users/{id}/roles")]
    public void UsersIdRolesPost (int? Id, UserRole Role) {

      
      // verify the required parameter 'Id' is set
      if (Id == null) throw new ApiException(400, "Missing required parameter 'Id' when calling UsersIdRolesPost");
      
      // verify the required parameter 'Role' is set
      if (Role == null) throw new ApiException(400, "Missing required parameter 'Role' when calling UsersIdRolesPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a collection of Groups for a User 
    /// </summary>
    /// <param name="UserId">User ID</param>
    /// <returns>List<Group></returns>
    [HttpGET]
    [Route("/users/{userId}/groups")]
    public List<Group> UsersUserIdGroupsGet (int? UserId) {

      
      // verify the required parameter 'UserId' is set
      if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling UsersUserIdGroupsGet");
      

      var result = _service.UsersUserIdGroupsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete a Role from the specified User 
    /// </summary>
    /// <param name="UserId">User ID</param>/// <param name="RoleId">Role ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/users/{userId}/roles/{roleId}")]
    public void UsersUserIdRolesRoleIdDelete (int? UserId, int? RoleId) {

      
      // verify the required parameter 'UserId' is set
      if (UserId == null) throw new ApiException(400, "Missing required parameter 'UserId' when calling UsersUserIdRolesRoleIdDelete");
      
      // verify the required parameter 'RoleId' is set
      if (RoleId == null) throw new ApiException(400, "Missing required parameter 'RoleId' when calling UsersUserIdRolesRoleIdDelete");
      

      

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


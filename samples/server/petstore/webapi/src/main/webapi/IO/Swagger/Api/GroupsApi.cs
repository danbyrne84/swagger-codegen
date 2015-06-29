namespace Api.Controllers
{

    private IService<GroupsApiService, GroupsApiResults> _service;

    public GroupsApiController(IService<GroupsApi> service)
    {
        _service = service;
    }

    
    
    /// <summary>
    /// Return all User Groups 
    /// </summary>
    
    /// <returns>List<Group></returns>
    [HttpGET]
    [Route("/groups")]
    public List<Group> GroupsGet () {

      

      var result = _service.GroupsGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Adds a new group 
    /// </summary>
    /// <param name="Group"></param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/groups")]
    public void GroupsPost (Group Group) {

      
      // verify the required parameter 'Group' is set
      if (Group == null) throw new ApiException(400, "Missing required parameter 'Group' when calling GroupsPost");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return User Group by ID 
    /// </summary>
    /// <param name="GroupId">Group ID</param>
    /// <returns>Group</returns>
    [HttpGET]
    [Route("/groups/{groupId}")]
    public Group GroupsGroupIdGet (int? GroupId) {

      
      // verify the required parameter 'GroupId' is set
      if (GroupId == null) throw new ApiException(400, "Missing required parameter 'GroupId' when calling GroupsGroupIdGet");
      

      var result = _service.GroupsGroupIdGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Update a user group 
    /// </summary>
    /// <param name="GroupId">Group ID</param>/// <param name="Group"></param>
    /// <returns></returns>
    [HttpPUT]
    [Route("/groups/{groupId}")]
    public void GroupsGroupIdPut (int? GroupId, Group Group) {

      
      // verify the required parameter 'GroupId' is set
      if (GroupId == null) throw new ApiException(400, "Missing required parameter 'GroupId' when calling GroupsGroupIdPut");
      
      // verify the required parameter 'Group' is set
      if (Group == null) throw new ApiException(400, "Missing required parameter 'Group' when calling GroupsGroupIdPut");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return all Roles for a Group 
    /// </summary>
    /// <param name="GroupId">Group ID</param>
    /// <returns>List<Group></returns>
    [HttpGET]
    [Route("/groups/{groupId}/roles")]
    public List<Group> GroupsGroupIdRolesGet (int? GroupId) {

      
      // verify the required parameter 'GroupId' is set
      if (GroupId == null) throw new ApiException(400, "Missing required parameter 'GroupId' when calling GroupsGroupIdRolesGet");
      

      var result = _service.GroupsGroupIdRolesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Delete all Roles from a Group 
    /// </summary>
    /// <param name="GroupId">Group ID</param>
    /// <returns></returns>
    [HttpDELETE]
    [Route("/groups/{groupId}/roles")]
    public void GroupsGroupIdRolesDelete (int? GroupId) {

      
      // verify the required parameter 'GroupId' is set
      if (GroupId == null) throw new ApiException(400, "Missing required parameter 'GroupId' when calling GroupsGroupIdRolesDelete");
      

      

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Add a Role to a Group 
    /// </summary>
    /// <param name="GroupId">Group ID</param>/// <param name="RoleId">Role ID</param>
    /// <returns></returns>
    [HttpPOST]
    [Route("/groups/{groupId}/roles/{roleId}")]
    public void GroupsGroupIdRolesRoleIdPost (int? GroupId, int? RoleId) {

      
      // verify the required parameter 'GroupId' is set
      if (GroupId == null) throw new ApiException(400, "Missing required parameter 'GroupId' when calling GroupsGroupIdRolesRoleIdPost");
      
      // verify the required parameter 'RoleId' is set
      if (RoleId == null) throw new ApiException(400, "Missing required parameter 'RoleId' when calling GroupsGroupIdRolesRoleIdPost");
      

      

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
    
	
  }  
  
}


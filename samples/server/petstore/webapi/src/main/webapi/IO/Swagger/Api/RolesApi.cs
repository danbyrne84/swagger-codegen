namespace Api.Controllers
{

    private IService<RolesApiService, RolesApiResults> _service;

    public RolesApiController(IService<RolesApi> service)
    {
        _service = service;
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
    /// Return all Roles 
    /// </summary>
    
    /// <returns>List<Role></returns>
    [HttpGET]
    [Route("/roles")]
    public List<Role> RolesGet () {

      

      var result = _service.RolesGet();

      if(result == false)
          
      }

      
    }
    
    /// <summary>
    /// Return a Role by Id 
    /// </summary>
    /// <param name="RoleId">Role ID</param>
    /// <returns>Role</returns>
    [HttpGET]
    [Route("/roles/{roleId}")]
    public Role RolesRoleIdGet (int? RoleId) {

      
      // verify the required parameter 'RoleId' is set
      if (RoleId == null) throw new ApiException(400, "Missing required parameter 'RoleId' when calling RolesRoleIdGet");
      

      var result = _service.RolesRoleIdGet();

      if(result == false)
          
      }

      
    }
    
	
  }  
  
}


namespace Api.Controllers
{

    private IService<ClientTreeApiService, ClientTreeApiResults> _service;

    public ClientTreeApiController(IService<ClientTreeApi> service)
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
    
	
  }  
  
}


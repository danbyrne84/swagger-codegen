namespace Api.Controllers
{

    private IService<{{classname}}Service, {{classname}}Results> _service;

    public {{classname}}Controller(IService<{{classname}}> service)
    {
        _service = service;
    }

    {{#operations}}
    {{#operation}}
    /// <summary>
    /// {{summary}} {{notes}}
    /// </summary>
    {{#allParams}}/// <param name="{{paramName}}">{{description}}</param>{{/allParams}}
    /// <returns>{{#returnType}}{{{returnType}}}{{/returnType}}</returns>
    [Http{{httpMethod}}]
    [Route("{{path}}")]
    public {{#returnType}}{{{returnType}}}{{/returnType}}{{^returnType}}void{{/returnType}} {{operationId}} ({{#allParams}}{{{dataType}}} {{paramName}}{{#hasMore}}, {{/hasMore}}{{/allParams}}) {

      {{#allParams}}{{#required}}
      // verify the required parameter '{{paramName}}' is set
      if ({{paramName}} == null) throw new ApiException(400, "Missing required parameter '{{paramName}}' when calling {{operationId}}");
      {{/required}}{{/allParams}}

      {{#returnType}}var result = _service.{{operationId}}();{{/returnType}}

      if(result == false)
          
      }

      
    }
    {{/operation}}
	
  }  
  {{/operations}}
}


﻿using Swashbuckle.Swagger;
using System.Collections.Generic;
using System.Web.Http.Description;

public class AddAuthorizationHeaderParameter : IOperationFilter
{
    public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
    {
        if (operation.parameters == null)
            operation.parameters = new List<Parameter>();

        operation.parameters.Add(new Parameter
        {
            name = "Authorization",
            @in = "header",
            type = "string",
            required = true
        });
    }
}

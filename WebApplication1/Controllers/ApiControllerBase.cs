﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers;
[ApiController]
[Route("api/[controller]")]

public class ApiControllerBase : ControllerBase
{
    public ISender _mediator = null;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
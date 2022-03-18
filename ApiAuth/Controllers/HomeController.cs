﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("v1")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => $"Autenticado - {User.Identity.Name}";

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "manager, employee")]
        public string Employee() => $"Funcionário - {User.Identity.Name}";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}

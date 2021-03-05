﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AnotherBlog.CommentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value from Comment Api" };
        }
    }
}

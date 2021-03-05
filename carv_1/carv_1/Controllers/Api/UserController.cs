﻿using DataClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsClass.Common;
using ModelsClass.MethodParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace carv_1.Controllers.Api
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        //[ProducesResponseType(typeof(CreateUser))]
        public ActionResult CreateUser(CreateUser input)
        {
            if (ModelState.IsValid)
            {
                User_Data user_Business = new User_Data();
                var output = user_Business.CreateUser(input);
                switch (output.Result)
                {
                    case (Result.success):
                        return Ok(output);
                    case (Result.alreadyExist):
                        return BadRequest(output);
                    default:
                        return StatusCode(500,output);
                }
            }
            else
            {
                return BadRequest();
            }
            
        }
        
        
        [HttpPost]
        [Route("login")]
        //[ProducesResponseType(typeof(CreateUser))]
        public ActionResult LoginUser(UserLoginIn input)
        {
            if (ModelState.IsValid)
            {
                User_Data user_Business = new User_Data();
                var output = user_Business.Login(input);
                switch (output.Result)
                {
                    case (Result.success):
                        return Ok(output);
                    default:
                        return StatusCode(500,output);
                }
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
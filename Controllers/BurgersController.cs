using System;
using System.Collections.Generic;
using BurgerShack2.Models;
using BurgerShack2.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack2.Controllers
{
    [ApiController]//Is attribute - inherits from the Attributes Class
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase //Inherit from controller base to use their stuff
    {
        private readonly BurgersService _burgerService; //_ means private property

        public BurgersController(BurgersService burgerService) //BurgerService is datatype
        {
            _burgerService = burgerService; //burgerService is being assigned to _burgerService to be used throughout the class                       
        }

        [HttpGet]//Attribute from the Attributes Class
        public ActionResult<List<Burger>> GetBurgers()
        {
            try 
            {
                List<Burger> burgers = _burgerService.GetBurgers();
                return Ok(burgers);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }    
        }
    }
}
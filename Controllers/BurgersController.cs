
using System;
using System.Collections.Generic;
using BurgerShack2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack2.Controllers
{
    [ApiController]//What does this do?
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase //What does this do again?
    {
        private readonly BurgersService _burgerService; //What does this do?

        public BurgersController(BurgersService burgerService) //What does this do?
        {
            _burgerService = burgerService; //What does this do?
        }

        [HttpGet]
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
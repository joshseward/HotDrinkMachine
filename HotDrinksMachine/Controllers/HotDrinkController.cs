using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDrinksMachine.HotDrinks;
using HotDrinksMachine.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotDrinksMachine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotDrinkController : ControllerBase
    {
        private readonly ILogger<HotDrinkController> _logger;
        private readonly IHotDrinkFactory _hotDrinkFactory;

        public HotDrinkController(ILogger<HotDrinkController> logger, IHotDrinkFactory hotDrinkFactory)
        {
            _logger = logger;
            _hotDrinkFactory = hotDrinkFactory;
        }

        [HttpGet("{hotDrinkId:int}")]
        public ActionResult<List<string>> GetHotDrink(int hotDrinkId)
        {
            try
            {
                if(hotDrinkId > 0)
                {
                    var hotdrink = _hotDrinkFactory.GetHotDrink((HotDrinksEnum)hotDrinkId);

                    return Ok(hotdrink.Create());
                }
                else
                {
                    throw new ArgumentException("Drink Id Cannot be 0");
                }
                
            }
            catch(ArgumentException ex)
            {
                _logger.LogError(ex, "Bad Request Getting Drink");
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error When Getting Drink");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.ExchangeAPI.Repositories;
using Stock.ExchangeAPI.Entities;


namespace Stock.ExchangeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeController : ControllerBase
    {
        private readonly ExchangeRepository repository = new ExchangeRepository();
        [HttpPost]
        [Route("AddExchange")]
        public IActionResult Add(Exchange category)
        {
            try
            {
                repository.AddExchange(category);
                return Ok("Exchange Added");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllExchange")]
        public IActionResult GetExchange() //Get the All item
        {
            try
            {
                List<Exchange> items = repository.GetAllExchange();
                return Ok(items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetExchange/{itemname}")]
        public IActionResult Get(string itemname) //Get ipo using name
        {
            try
            {
                Exchange item = repository.GetExchangeByName(itemname);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteExchange/{itemname}")]
        public IActionResult DeleteIpo(string itemname) //Delete Item using id
        {
            try
            {
                repository.DeleteExchange(itemname);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPut]
        [Route("EditExchange")]
        public IActionResult EditItem(Exchange item) //Update Item
        {
            try
            {
                repository.UpdateExchange(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }






    }
}

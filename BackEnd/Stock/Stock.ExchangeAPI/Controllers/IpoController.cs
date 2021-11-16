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
    public class IpoController : ControllerBase
    {
        private readonly IPODetailsRepository repository = new IPODetailsRepository();
        [HttpPost]
        [Route("AddIpo")]
        public IActionResult Add(Ipo category)
        {
            try
            {
                repository.AddIpo(category);
                return Ok("IPO Added");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
            [HttpGet]
            [Route("GetAll")]
            public IActionResult GetIPO() //Get the All item
            {
                try
                {
                    List<Ipo> items = repository.GetAllIpo();
                    return Ok(items);
                }
                catch (Exception ex)
                {

                    return Content(ex.Message);
                }
            }
        [HttpGet]
        [Route("GetItem/{itemId}")]
        public IActionResult Get(string itemId) //Get ipo using name
        {
            try
            {
                Ipo item = repository.GetIpoByName(itemId);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteItem/{itemId}")]
        public IActionResult DeleteIpo(string itemId) //Delete Item using id
        {
            try
            {
                repository.DeleteIpo(itemId);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPut]
        [Route("EditItem")]
        public IActionResult EditItem(Ipo item) //Update Item
        {
            try
            {
                repository.UpdateIpo(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }








    }

        }


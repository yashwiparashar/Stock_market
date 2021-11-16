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
    public class SectorController : ControllerBase
    {
        private readonly SectorsRepository repository = new SectorsRepository();
        [HttpPost]
        [Route("AddSector")]
        public IActionResult Add(Sectors category)
        {
            try
            {
                repository.AddSectors(category);
                return Ok("Sector Added");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllSector")]
        public IActionResult GetSector() //Get the All item
        {
            try
            {
                List<Sectors> items = repository.GetAllSectors();
                return Ok(items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetSector/{itemId}")]
        public IActionResult Get(string itemId) //Get ipo using name
        {
            try
            {
                Sectors item = repository.GetSectorsByName(itemId);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteSector/{itemId}")]
        public IActionResult DeleteSector(string itemId) //Delete Item using id
        {
            try
            {
                repository.DeleteSectors(itemId);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPut]
        [Route("EditSector")]
        public IActionResult EditItem(Sectors item) //Update Item
        {
            try
            {
                repository.UpdateSectors(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }







    }
}

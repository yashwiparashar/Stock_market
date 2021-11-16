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
    public class CompanyController : ControllerBase
    {

        private readonly CompanyRepository repository = new CompanyRepository();
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult Add(Company category)
        {
            try
            {
                repository.AddCompany(category);
                return Ok("Company Added");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllCompany")]
        public IActionResult GetCompany() //Get the All item
        {
            try
            {
                List<Company> items = repository.GetAllCompany();
                return Ok(items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCompany/{itemId}")]
        public IActionResult Get(string itemId) //Get company using name
        {
            try
            {
                Company item = repository.GetCompanyByName(itemId);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteCompany/{itemname}")]
        public IActionResult DeleteCompany(string itemname) //Delete Item using id
        {
            try
            {
                repository.DeleteCompany(itemname);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPut]
        [Route("EditCompany")]
        public IActionResult EditItem(Company item) //Update Item
        {
            try
            {
                repository.UpdateCompany(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }















    }
}

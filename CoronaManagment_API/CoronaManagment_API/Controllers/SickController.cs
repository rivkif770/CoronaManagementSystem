using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaManagment_DTO;
using CorornaManagment_BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoronaManagment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SickController : ControllerBase
    {
        ISick_BL sick_BL;

        public SickController(ISick_BL sick_BL)
        {
            this.sick_BL = sick_BL;
        }


        [HttpGet]
        [Route("GetSick/{identityClient}")]
        public IActionResult GetSick(string identityClient)
        {
            try
            {
                return Ok(sick_BL.GetSick(identityClient));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddSick")]
        public IActionResult AddSick([FromBody] Sick_DTO newSick)
        {
            try
            {
                return Ok(sick_BL.AddSick(newSick));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("CountSick")]
        public IActionResult CountSick()
        {
            try
            {
                return Ok(sick_BL.CountSick());
            }


            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

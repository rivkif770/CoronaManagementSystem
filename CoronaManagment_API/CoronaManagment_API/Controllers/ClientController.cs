using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoronaManagment_DTO;
using CorornaManagment_BL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoronaManagment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClient_BL client_BL;
        //private IWebHostEnvironment _hostEnvironment;

        public ClientController(IClient_BL client_BL,IWebHostEnvironment environment)
        {
            this.client_BL = client_BL;
            //this._hostEnvironment = environment;
        }

        [HttpGet]
        [Route("GetAllClients")]
        public IActionResult GetAllClients()
        {
            try
            {
                return Ok(client_BL.GetAllClients());
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetClient/{id}")]
        public IActionResult GetClient(int id)
        {
            try
            {
                return Ok(client_BL.GetClient(id));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddClient")]
        public IActionResult AddClient([FromBody] Client_DTO newClient)
        {
            try
            {
                return Ok(client_BL.AddClient(newClient));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeletClient/{IdentityClient}")]
        public IActionResult DeleteClient(string IdentityClient)
        {
            try
            {
                return Ok(client_BL.DeleteClient(IdentityClient));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut]
        [Route("UpdateClient/{id}")]
        public IActionResult UpdateClient(int id, [FromBody] Client_DTO client)
        {
            try
            {
                return Ok(client_BL.UpdateClient(id, client));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("CountUnvaccinated")]
        public int CountUnvaccinated()
        {
            return client_BL.CountUnvaccinated();
        }

    }
}

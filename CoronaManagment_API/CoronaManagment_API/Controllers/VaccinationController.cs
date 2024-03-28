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
    public class VaccinationController : ControllerBase
    {
        IVaccination_BL vaccination_BL;

        public VaccinationController(IVaccination_BL vaccination_BL)
        {
            this.vaccination_BL = vaccination_BL;
        }

        [HttpGet]
        [Route("GetAllVaccin/{identityClient}")]
        public IActionResult GetAllVaccin(string identityClient)
        {
            try
            {
                return Ok( vaccination_BL.GetAllVaccin(identityClient));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddVaccin")]
        public IActionResult AddVaccin([FromBody] Vaccination_DTO vaccination)
        {
            try
            {
                return Ok(vaccination_BL.AddVaccin(vaccination));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
    }
}

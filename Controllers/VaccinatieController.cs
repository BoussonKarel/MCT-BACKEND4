using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationAPI.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Options;
using MCT_BACKEND4.Data;
using Microsoft.EntityFrameworkCore;
using MCT_BACKEND4.Services;

namespace RegistrationAPI.Controllers
{
 

    [ApiController] 
    public class VaccinatieController : ControllerBase
    {
        private IRegistrationService _registrationService;
        public VaccinatieController(IRegistrationService RegistrationService)
        {
            _registrationService = RegistrationService;
        }

        [HttpGet]
        [Route("/vaccins")]
        public async Task<List<VaccinType>> GetVaccinsAsync(){
            return await _registrationService.GetVaccinTypes();
        }

        [HttpGet]
        [Route("/locations")]
        public async Task<List<VaccinationLocation>> GetLocationsAsync(){
            return await _registrationService.GetVaccinationLocations();
        }

        [HttpGet]
        [Route("/registrations")]
        public async Task<ActionResult<List<VaccinationRegistration>>> GetRegistrations(string date="", bool includeVaccin = false) {
            try
            {
                return await _registrationService.GetVaccinationRegistrations(date, includeVaccin);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("/registration")]
        public async Task<ActionResult<VaccinationRegistration>> AddRegistrationAsync(VaccinationRegistration registration){
            try
            {
                registration.VaccinationRegistrationId = Guid.NewGuid();
                await _registrationService.AddVaccinationRegistration(registration);
                return new OkObjectResult(registration);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

    }
}

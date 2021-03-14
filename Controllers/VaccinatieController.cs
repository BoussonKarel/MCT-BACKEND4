using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegistrationAPI.Models;
using MCT_BACKEND4.Services;
using Microsoft.Extensions.Caching.Memory;

namespace RegistrationAPI.Controllers
{
 

    [ApiController] 
    public class VaccinatieController : ControllerBase
    {
        private IRegistrationService _registrationService;
        private IMemoryCache _cache;
        public VaccinatieController(IRegistrationService RegistrationService, IMemoryCache cache)
        {
            _registrationService = RegistrationService;
            _cache = cache;
        }

        [HttpGet]
        [Route("/vaccins")]
        public async Task<List<VaccinType>> GetVaccinsAsync(){
            return await _registrationService.GetVaccinTypes();
        }

        [HttpGet]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any)] // HTTP Response cachen (10 seconden)
        [Route("/locations")]
        public async Task<List<VaccinationLocation>> GetLocationsAsync(){
            List<VaccinationLocation> locations;

            _cache.TryGetValue<List<VaccinationLocation>>("locations", out locations);
            if (locations == null) {
                locations = await _registrationService.GetVaccinationLocations();
                _cache.Set<List<VaccinationLocation>>("locations", locations, DateTime.Now.AddSeconds(10));
                // 10 seconden id memory cache
            }

            return locations;
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

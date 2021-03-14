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

namespace RegistrationAPI.Controllers
{
 

    [ApiController] 
    public class VaccinatieController : ControllerBase
    {
        private RegistrationContext _context;
        public VaccinatieController(RegistrationContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/locations")]
        public async Task<List<VaccinationLocation>> GetLocationsAsync(){
            return await _context.VaccinationLocations.ToListAsync();
        }

        [HttpGet]
        [Route("/vaccins")]
        public async Task<List<VaccinType>> GetVaccinsAsync(){
            return await _context.VaccinType.ToListAsync();
        }

        [HttpGet]
        [Route("/registrations")]
        public async Task<ActionResult<List<VaccinationRegistration>>> GetRegistrationsAsync(string date = "", bool includeVaccin = false){
            if (!string.IsNullOrWhiteSpace(date)) {
                if (includeVaccin) {
                    // Doesn't work... yet?
                    return await _context.VaccinationRegistrations.Where(r => r.VaccinationDate == date).Include(r => r.VaccinType).ToListAsync();
                }
                else {
                    return await _context.VaccinationRegistrations.Where(r => r.VaccinationDate == date).ToListAsync();
                }
                
            }
            else {
                return await _context.VaccinationRegistrations.ToListAsync();
            }
        }

        [HttpPost]
        [Route("/registration")]
        public async Task<ActionResult<VaccinationRegistration>> AddRegistrationAsync(VaccinationRegistration registration){
            try
            {
                registration.VaccinationRegistrationId = Guid.NewGuid();
                await _context.VaccinationRegistrations.AddAsync(registration);
                await _context.SaveChangesAsync();
                return registration;
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(500);
            }
        }

    }
}

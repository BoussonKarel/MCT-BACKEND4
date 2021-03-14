using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MCT_BACKEND4.Data;
using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Models;

namespace MCT_BACKEND4.Repositories
{
    public interface IVaccinationLocationRepository
    {
        Task<List<VaccinationLocation>> GetVaccinationLocations();
    }

    public class VaccinationLocationRepository : IVaccinationLocationRepository
    {
        private IRegistrationContext _context;

        public VaccinationLocationRepository(IRegistrationContext context)
        {
            _context = context;
        }

        public async Task<List<VaccinationLocation>> GetVaccinationLocations()
        {
            return await _context.VaccinationLocations.ToListAsync();
        }
    }
}

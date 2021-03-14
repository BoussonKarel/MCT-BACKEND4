using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MCT_BACKEND4.Data;
using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Models;

namespace MCT_BACKEND4.Repositories
{
    public interface IVaccinTypeRepository
    {
        Task<List<VaccinType>> GetVaccinTypes();
    }

    public class VaccinTypeRepository : IVaccinTypeRepository
    {
        private IRegistrationContext _context;

        public VaccinTypeRepository(IRegistrationContext context)
        {
            _context = context;
        }

        public async Task<List<VaccinType>> GetVaccinTypes()
        {
            return await _context.VaccinTypes.ToListAsync();
        }
    }
}

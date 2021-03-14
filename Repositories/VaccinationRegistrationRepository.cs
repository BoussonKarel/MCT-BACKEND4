using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCT_BACKEND4.Data;
using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Models;

namespace MCT_BACKEND4.Repositories
{
    public interface IVaccinationRegistrationRepository
    {
        Task<VaccinationRegistration> AddVaccinationRegistration(VaccinationRegistration vaccinationRegistration);
        Task<List<VaccinationRegistration>> GetVaccinationRegistrations(string date, bool includeVaccin);
    }

    public class VaccinationRegistrationRepository : IVaccinationRegistrationRepository
    {
        private IRegistrationContext _context;

        public VaccinationRegistrationRepository(IRegistrationContext context)
        {
            _context = context;
        }

        public async Task<List<VaccinationRegistration>> GetVaccinationRegistrations(string date, bool includeVaccin)
        {
            // return await _context.VaccinationRegistrations.ToListAsync();

            //Filter by date
            if (!string.IsNullOrWhiteSpace(date)) {
                if (includeVaccin) {
                    return await _context.VaccinationRegistrations.Include(r => r.VaccinType).Where(r => r.VaccinationDate == date).ToListAsync();
                }
                else {
                    return await _context.VaccinationRegistrations.Where(r => r.VaccinationDate == date).ToListAsync();
                }
                
            }
            // Don't filter by date
            else {
                if (includeVaccin) {
                    return await _context.VaccinationRegistrations.Include(r => r.VaccinType).ToListAsync();
                }
                else {
                    return await _context.VaccinationRegistrations.ToListAsync();
                }

                
            }
        }

        public async Task<VaccinationRegistration> AddVaccinationRegistration(VaccinationRegistration vaccinationRegistration)
        {
            await _context.VaccinationRegistrations.AddAsync(vaccinationRegistration);
            await _context.SaveChangesAsync();
            return vaccinationRegistration;
        }
    }
}

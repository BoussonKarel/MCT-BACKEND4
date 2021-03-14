using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MCT_BACKEND4.Repositories;
using RegistrationAPI.Models;

namespace MCT_BACKEND4.Services
{
    public interface IRegistrationService
    {
        Task<VaccinationRegistration> AddVaccinationRegistration(VaccinationRegistration registration);
        Task<List<VaccinationLocation>> GetVaccinationLocations();
        Task<List<VaccinationRegistration>> GetVaccinationRegistrations(string date, bool includeVaccin);
        Task<List<VaccinType>> GetVaccinTypes();
    }

    public class RegistrationService : IRegistrationService
    {
        private IVaccinationRegistrationRepository _vaccinationRegistrationRepository;
        private IVaccinationLocationRepository _vaccinationLocationRepository;
        private IVaccinTypeRepository _vaccinTypeRepository;

        private IMailService _mailService;

        public RegistrationService(
            IVaccinationRegistrationRepository vaccinationRegistrationRepository,
            IVaccinationLocationRepository vaccinationLocationRepository,
            IVaccinTypeRepository vaccinTypeRepository,
            IMailService mailService)
        {
            _vaccinationRegistrationRepository = vaccinationRegistrationRepository;
            _vaccinationLocationRepository = vaccinationLocationRepository;
            _vaccinTypeRepository = vaccinTypeRepository;
            _mailService = mailService;
        }

        public async Task<List<VaccinationLocation>> GetVaccinationLocations()
        {
            return await _vaccinationLocationRepository.GetVaccinationLocations();
        }

        public async Task<List<VaccinType>> GetVaccinTypes()
        {
            return await _vaccinTypeRepository.GetVaccinTypes();
        }

        public async Task<List<VaccinationRegistration>> GetVaccinationRegistrations(string date, bool includeVaccin)
        {
            return await _vaccinationRegistrationRepository.GetVaccinationRegistrations(date, includeVaccin);
        }

        public async Task<VaccinationRegistration> AddVaccinationRegistration(VaccinationRegistration registration)
        {
            var newRegistration = await _vaccinationRegistrationRepository.AddVaccinationRegistration(registration);
            await _mailService.SendMail("bousson.karel@gmail.com","info@unikits.be");
            return newRegistration;
        }
    }
}

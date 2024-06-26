﻿using VaxCentre.Server.Models;

namespace VaxCentre.Server.Data.Interfaces
{
    public interface IVaccineCentreRepository : IGenericRepository<VaccineCentre>
    {
        Task<List<VaccineCentre>> GetByNameAsync(string name);
        Task<VaccineCentre> UpdateAsync(VaccineCentre centre, int Id);
        Task<VaccineCentre> AssignVaccineToCentre(int VaccineCentreId,int VaccineId);
    }
}

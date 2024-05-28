using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VacationManagement.Domain;

namespace VacationManagement.Application.Persistence.Contracts
{
    public interface IVacationTypeRepository : IGenericRepository<VacationType>
    {
        Task<VacationType> GetVacationTypeWithDetails(int id);

        Task<List<VacationType>> GetVacationTypeWithDetails();
    }
}
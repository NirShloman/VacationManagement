using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VacationManagement.Domain;

namespace VacationManagement.Application.Persistence.Contracts
{
    public interface IVacationAllocationRepository : IGenericRepository<VacationAllocation>
    {
        Task<VacationAllocation> GetVacationAllocationWithDetails(int id);

        Task<List<VacationAllocation>> GetVacationAllocationWithDetails();
    }
}
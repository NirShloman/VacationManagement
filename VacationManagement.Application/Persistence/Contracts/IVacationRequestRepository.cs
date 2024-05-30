using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VacationManagement.Domain;

namespace VacationManagement.Application.Persistence.Contracts
{
    public interface IVacationRequestRepository : IGenericRepository<VacationRequset>
    {
        Task<VacationRequset> GetVacationRequsetWithDetails(int id);

        Task<List<VacationRequset>> GetVacationRequsetWithDetails();

        Task ChangeApprovalStatus(VacationRequset leaveRequest, bool? ApprovalStatus);
    }
}
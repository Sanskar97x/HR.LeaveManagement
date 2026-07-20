using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistance.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}

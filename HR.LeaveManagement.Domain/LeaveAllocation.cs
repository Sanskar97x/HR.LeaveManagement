
using HR.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; } = 0;
        public LeaveType LeaveType { get; set; } = new LeaveType();
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}

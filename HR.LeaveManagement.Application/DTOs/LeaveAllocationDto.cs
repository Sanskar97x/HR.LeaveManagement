using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; } = 0;
        public LeaveTypeDto LeaveType { get; set; } = new LeaveTypeDto();
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}

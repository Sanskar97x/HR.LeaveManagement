using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; } = new LeaveTypeDto();
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }

    }
}

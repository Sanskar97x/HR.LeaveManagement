using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTOs.Common;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }

    }
}

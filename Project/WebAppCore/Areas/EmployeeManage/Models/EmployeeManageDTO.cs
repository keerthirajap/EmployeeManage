﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Areas.EmployeeManage.Models
{
    public class EmployeeManageDTO
    {
        
        public EmployeeViewModel EmployeeViewModel { get; set; }

        public List<EmployeeViewModel> EmployeesViewModel { get; set; }

    }
}
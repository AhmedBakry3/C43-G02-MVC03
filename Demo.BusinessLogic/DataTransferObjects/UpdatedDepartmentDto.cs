﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.DataTransferObjects
{
    public class UpdatedDepartmentDto
    {
        public string Name { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string Description { get; set; }
        public DateOnly DateOfCreation  { get; set; }
    }
}

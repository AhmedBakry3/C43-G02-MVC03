﻿
namespace Demo.BusinessLogic.DataTransferObjects.DepartmentDto
{
    public class UpdatedDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string Description { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}

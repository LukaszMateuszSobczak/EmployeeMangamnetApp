using EmployeeManagmentApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagmentApp.Services
{
    public interface IExportService
    {
        public Task<FileStreamResult> GenerateEmployeesCsv(List<Employee> employees);
        public byte[] GenerateEmployeesExcel(List<Employee> employees);
    }
}

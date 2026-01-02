using EmployeeManagmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace EmployeeManagmentApp.Services
{
    public class ExportService : IExportService
    {
        //public async Task<IActionResult> ExportToExcel()
        //{
        //    var userId = GetUserId();
        //    if (userId is null)
        //    {
        //        return Challenge();
        //    }
        //    var employees = await _service.GetEmployeesAsync(userId);

        //    using (var package = new ExcelPackage())
        //    {
        //        var worksheet = package.Workbook.Worksheets.Add("Employees");
        //        worksheet.Cells["A1"].Value = "Id";
        //        worksheet.Cells["B1"].Value = "Imię";
        //        worksheet.Cells["C1"].Value = "Nazwisko";
        //        worksheet.Cells["D1"].Value = "Pesel";
        //        worksheet.Cells["E1"].Value = "Email";
        //        worksheet.Cells["F1"].Value = "Numer telefonu";
        //        worksheet.Cells["G1"].Value = "Pensja";
        //        worksheet.Cells["H1"].Value = "Data zatrudnienia";
        //        worksheet.Cells["I1"].Value = "Miasto";
        //        worksheet.Cells["J1"].Value = "Ulica";
        //        worksheet.Cells["K1"].Value = "Numer domu";
        //        worksheet.Cells["L1"].Value = "Numer mieszkania";
        //        worksheet.Cells["M1"].Value = "Kod pocztowy";

        //        for (var i = 0; i < employees.Count; i++)
        //        {
        //            worksheet.Cells[i + 2, 1].Value = employees[i].Id;
        //            worksheet.Cells[i + 2, 2].Value = employees[i].FirstName;
        //            worksheet.Cells[i + 2, 3].Value = employees[i].LastName;
        //            worksheet.Cells[i + 2, 4].Value = employees[i].Pesel;
        //            worksheet.Cells[i + 2, 5].Value = employees[i].Email;
        //            worksheet.Cells[i + 2, 6].Value = employees[i].Phone;
        //            worksheet.Cells[i + 2, 7].Value = employees[i].Salary;
        //            worksheet.Cells[i + 2, 8].Value = employees[i].HireDate;
        //            worksheet.Cells[i + 2, 9].Value = employees[i].Address.City;
        //            worksheet.Cells[i + 2, 10].Value = employees[i].Address.StreetName;
        //            worksheet.Cells[i + 2, 11].Value = employees[i].Address.HouseNumber;
        //            worksheet.Cells[i + 2, 12].Value = employees[i].Address.ApartamentNumber;
        //            worksheet.Cells[i + 2, 13].Value = employees[i].Address.PostalCode;
        //        }

        //        var stream = new MemoryStream(package.GetAsByteArray());
        //        return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "employees.xlsx");
        //    }




        public byte[] GenerateEmployeesExcel(List<Employee> employees)
        {
            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Employees");
            SetupHeaders(worksheet);
            PopulateEmployeeData(worksheet, employees);
            return package.GetAsByteArray();

        }

        private static void SetupHeaders(ExcelWorksheet worksheet)
        {
            worksheet.Cells["A1"].Value = "Id";
            worksheet.Cells["B1"].Value = "Imię";
            worksheet.Cells["C1"].Value = "Nazwisko";
            worksheet.Cells["D1"].Value = "Pesel";
            worksheet.Cells["E1"].Value = "Email";
            worksheet.Cells["F1"].Value = "Numer telefonu";
            worksheet.Cells["G1"].Value = "Pensja";
            worksheet.Cells["H1"].Value = "Data zatrudnienia";
            worksheet.Cells["I1"].Value = "Miasto";
            worksheet.Cells["J1"].Value = "Ulica";
            worksheet.Cells["K1"].Value = "Numer domu";
            worksheet.Cells["L1"].Value = "Numer mieszkania";
            worksheet.Cells["M1"].Value = "Kod pocztowy";
        }

        private static void PopulateEmployeeData(ExcelWorksheet worksheet, List<Employee> employees)
        {
            for (var i = 0; i < employees.Count; i++)
            {
                worksheet.Cells[i + 2, 1].Value = employees[i].Id;
                worksheet.Cells[i + 2, 2].Value = employees[i].FirstName;
                worksheet.Cells[i + 2, 3].Value = employees[i].LastName;
                worksheet.Cells[i + 2, 4].Value = employees[i].Pesel;
                worksheet.Cells[i + 2, 5].Value = employees[i].Email;
                worksheet.Cells[i + 2, 6].Value = employees[i].Phone;
                worksheet.Cells[i + 2, 7].Value = employees[i].Salary;
                worksheet.Cells[i + 2, 8].Value = employees[i].HireDate.ToString();
                worksheet.Cells[i + 2, 9].Value = employees[i].Address.City;
                worksheet.Cells[i + 2, 10].Value = employees[i].Address.StreetName;
                worksheet.Cells[i + 2, 11].Value = employees[i].Address.HouseNumber;
                worksheet.Cells[i + 2, 12].Value = employees[i].Address.ApartamentNumber;
                worksheet.Cells[i + 2, 13].Value = employees[i].Address.PostalCode;
            }
        }



        public Task<FileStreamResult> GenerateEmployeesCsv(List<Employee> employees)
        {
            throw new NotImplementedException();
        }
    }
}

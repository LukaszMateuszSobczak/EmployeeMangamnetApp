using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole miasto jest wymagane")]
        public string City { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole ulica jest wymagane")]
        public string StreetName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole numer domu jest wymagane")]
        public string HouseNumber { get; set; } = string.Empty;
        public string? ApartamentNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "Pole kod pocztowy jest wymagane")]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi być w formacie 00-000")]
        public string PostalCode { get; set; } = string.Empty;

        //FK
        public int EmployeeId { get; set; }

        //NAVIGATION
        public Employee? Employee { get; set; } = null;
    }
}

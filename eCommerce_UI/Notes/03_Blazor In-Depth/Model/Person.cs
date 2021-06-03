using System.ComponentModel.DataAnnotations;

namespace eCommerce_UI.Notes._03_Blazor_In_Depth.Model
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [Range(1, 100)]
        public int EmployeeNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}


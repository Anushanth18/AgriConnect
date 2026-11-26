using System.ComponentModel.DataAnnotations;

namespace AgriSupplierApi.DTOs.Supplier
{
    public class SupplierCreateDto
    {
        [Required]
        public string BusinessName { get; set; } = string.Empty;

        [Required]
        public string ContactNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
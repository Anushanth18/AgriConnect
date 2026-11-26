namespace AgriSupplierApi.DTOs.Supplier
{
    public class SupplierResponseDto
    {
        public int SupplierId { get; set; }

        public string BusinessName { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
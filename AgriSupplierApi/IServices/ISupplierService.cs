using AgriSupplierApi.DTOs.Supplier;

namespace AgriSupplierApi.IServices
{
    public interface ISupplierService
    {
        Task<SupplierResponseDto> CreateSupplier(
            SupplierCreateDto dto, string userId);

        Task<SupplierResponseDto?> GetSupplierById(int id);

        Task<SupplierResponseDto?> GetSupplierByUserId(string userId);

        Task<SupplierResponseDto?> UpdateSupplier(
            int id, SupplierUpdateDto dto, string userId);

        Task<bool> DeleteSupplier(int id, string userId);
    }
}
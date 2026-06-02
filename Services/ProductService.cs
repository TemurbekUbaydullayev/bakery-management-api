using BakeryApi.Data;
using BakeryApi.DTOs;
using BakeryApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BakeryApi.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;
    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public Task<ProductDto> CreateAsync(CreateProductDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductDto>> GetAllAsync()
    {
        return await _context.Products
            .Include(p => p.PriceHistories)
            .Select(p => new ProductDto(
                p.Id,
                p.Name,
                p.Category,
                p.PriceHistories
                    .OrderByDescending(ph => ph.EffectiveDate)
                    .FirstOrDefault()!.Price,
                p.IsAvailable,
                p.CreatedAt
            )).ToListAsync();
    }

    public Task<ProductDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task SetPriceAsync(Guid id, decimal price)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> UpdateAsync(Guid id, UpdateProductDto dto)
    {
        throw new NotImplementedException();
    }
}

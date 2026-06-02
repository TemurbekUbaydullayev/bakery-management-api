namespace BakeryApi.DTOs;

public record ProductDto(
    Guid Id,
    string Name,
    string Category,
    decimal CurrentPrice,
    bool IsAvailable,
    DateTime CreatedAt
);

public record CreateProductDto(
    string Name,
    string Category,
    decimal Price
);

public record UpdateProductDto(
    string Name,
    string Category,
    bool IsAvailable
);
namespace ProductsApiExtended.Dtos
{
    public class ProductDto
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty; 
        public string? OnStock { get; set; }
        public string? Manufacturer { get; set; }
    }
}

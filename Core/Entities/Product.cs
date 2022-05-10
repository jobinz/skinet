namespace Core.Entities;

/// <summary>
/// Product Entity
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Name of the product
    /// </summary>
    /// <value></value>
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string PictureUrl { get; set; }
    public ProductType ProductType { get; set; }
    public int ProductTypeId { get; set; }
    public ProductBrand ProductBrand { get; set; }
    public int ProductBrandId { get; set; }
}
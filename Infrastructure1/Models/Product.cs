namespace Infrastructure1.Models;

public class Product
{
    public string Id { get; set; } = null!;
    public string? ArticleNumber { get; set; }
    public bool IsService { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Description { get; set; } 
    public string Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
}


public class ProductCreateRequest
{ 
}

public class ProductViewRequest
{ 
}
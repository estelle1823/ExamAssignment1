﻿namespace Infrastructure1.Models;

public class Product
{
    public string Id { get; set; } = null!;
    public string? ArticleNumber { get; set; }
    public bool IsService { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Description { get; set; } 
}

public class Unit
{ 
    public int Id { get; set; }
    public string UnitName { get; set; } = null!;
}

public class ProductSku
{
    public Product Product { get; set; } = null!;
    public int QuantityInStock { get; set; }
}

    public class ProductPrice
{ 
    public Product Product { get; set; } = null!;
    public Unit Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
}

public class ProductCreateRequest
{
    public string? ArticleNumber { get; set; }
    public bool IsService { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Description { get; set; }
    public string Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }

}
public class ProductViewListRequest
{
    public string? ArticleNumber { get; set; }
    public bool IsService { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Description { get; set; }
    public string Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
}
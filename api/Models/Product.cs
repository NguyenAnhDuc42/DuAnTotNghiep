using System;

namespace api.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ProductDetail ProductDetail { get; set; } //1-1
}

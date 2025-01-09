using System;
using FakeStoreApi2.Models;

namespace FakeStoreApi2;

public class ApiResponse
{
    public string? Status { get; set; }
    public string? Message { get; set; }
    public List<Product>? Products { get; set; }
    public Product? Product { get; set; }


}
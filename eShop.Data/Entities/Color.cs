﻿

namespace eShop.Data.Entities;

public class Color : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TextColor { get; set; } = string.Empty;
    public string BGColor { get; set; } = string.Empty;
    public OptionType OptionType { get; set; }
    public List<Product>? Products { get; set; }
}

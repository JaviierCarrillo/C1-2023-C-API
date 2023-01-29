using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace example.Models;

public partial class Product
{

    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }

    [Required]
    public decimal? Price { get; set; }

    [DefaultValue(false)]
    public bool IsDeleted { get; set; }
}

using System;
using System.Collections.Generic;

namespace Souvenir.Models;

public partial class ProductReview
{
    public int ReviewId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public int? Rating { get; set; }

    public string? ReviewContent { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;
}

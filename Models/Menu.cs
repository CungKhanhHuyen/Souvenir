using System;
using System.Collections.Generic;

namespace Souvenir.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string MenuName { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int? ParentId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

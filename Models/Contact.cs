using System;
using System.Collections.Generic;

namespace Souvenir.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}

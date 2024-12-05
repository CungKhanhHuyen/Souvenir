using System;
using System.Collections.Generic;

namespace Souvenir.Models;

public partial class BlogComment
{
    public int CommentId { get; set; }

    public int BlogId { get; set; }

    public int UserId { get; set; }

    public string CommentContent { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Blog Blog { get; set; } = null!;
}

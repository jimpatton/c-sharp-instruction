using System;
using System.Collections.Generic;

namespace OurFirstWebAPIProject.Models;

public partial class Credit
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int ActorId { get; set; }

    public string Role { get; set; } = null!;

    public virtual Actor Actor { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;
}

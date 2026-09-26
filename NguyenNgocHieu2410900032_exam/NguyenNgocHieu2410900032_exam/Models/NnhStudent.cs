using System;
using System.Collections.Generic;

namespace NguyenNgocHieu2410900032_exam.Models;

public partial class NnhStudent
{
    public int Id { get; set; }

    public string NnhName { get; set; } = null!;

    public string NnhGender { get; set; } = null!;

    public DateOnly NnhBirthDay { get; set; }

    public string NnhEmail { get; set; } = null!;

    public string NnhPhone { get; set; } = null!;

    public bool NnhActive { get; set; }
}

using System;
using System.Collections.Generic;

namespace NnhLession10efdbfist.Models;

public partial class NnhMember
{
    public long Id { get; set; }

    public string? NnhUserName { get; set; }

    public string? NnhPassword { get; set; }

    public string? NnhFullName { get; set; }

    public string? NnhEmail { get; set; }

    public string? NnhPhone { get; set; }

    public bool? NnhStatus { get; set; }
}

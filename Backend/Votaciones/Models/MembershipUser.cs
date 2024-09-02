using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class MembershipUser
{
    public string MemberId { get; set; } = null!;

    public string? PassMd5 { get; set; }

    public string? Email { get; set; }

    public DateOnly? SignupDate { get; set; }

    public uint? GroupId { get; set; }

    public sbyte? IsBanned { get; set; }

    public sbyte? IsApproved { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public string? Custom4 { get; set; }

    public string? Comments { get; set; }

    public string? PassResetKey { get; set; }

    public uint? PassResetExpiry { get; set; }
}

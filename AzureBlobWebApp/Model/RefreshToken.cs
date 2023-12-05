﻿using System;
using System.Collections.Generic;

namespace AzureBlobWebApp.Model;

public partial class RefreshToken
{
    public int TokenId { get; set; }

    public string Token { get; set; } = null!;

    public bool IsActive { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}

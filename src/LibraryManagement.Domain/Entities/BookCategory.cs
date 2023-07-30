﻿using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class BookCategory : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
}

﻿using LibraryManagement.Domain.Common;

namespace LibraryManagement.Domain.Entities;

public class BookCopy : BaseAuditableEntity
{
    public Guid BookId { get; set; }

    public Book Book { get; set; } = new Book();

    public Guid PublisherId { get; set; }

    public Publisher Publisher { get; set; } = new Publisher();

    public int YearPublished { get; set; }

    public List<Hold> Holds { get; set; } = new List<Hold>();

    public List<Checkout> Checkouts { get; set; } = new List<Checkout>();

    public List<Notification> Notifications { get; set; } = new List<Notification>();
}

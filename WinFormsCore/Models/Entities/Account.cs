using System;
using System.Collections.Generic;

namespace WinFormsCore.Models.Entities;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Role { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string FullName { get; set; }
}

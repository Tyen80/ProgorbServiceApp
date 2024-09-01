﻿using Microsoft.AspNetCore.Identity;
using ServiceApp.Domain.ToDoItems;
using ServiceApp.Domain.Users;

namespace ServiceApp.Infrastructure.Users;
public class User : IdentityUser, IUser
{

    public List<ToDoItem> ToDoItems { get; set; } = new();
    public string? FamilyId { get; set; }

}

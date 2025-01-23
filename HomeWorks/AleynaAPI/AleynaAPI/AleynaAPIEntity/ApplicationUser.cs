using System;
using Microsoft.AspNetCore.Identity;

namespace AleynaAPI.AleynaAPIEntity;

public class ApplicationUser:IdentityUser
{
public string ?FirstName { get; set; }
public string ?LastName { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Project.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    [Microsoft.Build.Framework.Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(20)")]
    public string Login { get; set; }

    [Microsoft.Build.Framework.Required]
    [EmailAddress]
    [Column(TypeName = "nvarchar(30)")]
    public string Email { get; set; }

    [Microsoft.Build.Framework.Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(20)")]
    public string name { get; set; }

    [Microsoft.Build.Framework.Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(20)")]
    public string surname { get; set; }

    [Microsoft.Build.Framework.Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string address { get; set; }

    [Microsoft.Build.Framework.Required]
    [PersonalData]
    public int club { get; set; }

    [Microsoft.Build.Framework.Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(20)")]
    public string sex { get; set; }

    [Microsoft.Build.Framework.Required]
    [PersonalData]
    [Column(TypeName = "date")]
    public DateOnly birthdate { get; set; }
    
    [Column(TypeName = "nvarchar(30))")]
    public string Role { get; set; }
}









using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable
namespace App.Domain
{
    public partial class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {
        }
        public string Name { get; set; }


    }
}

using Microsoft.AspNetCore.Identity;
using System;

namespace Project.Areas.Identity.Data
{
    public class CustomUser : IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }
        [PersonalData]
        public DateTime GeboorteDatum { get; set; }
    }
}

﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace Authorization.Models
{
 
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        { 

        }

        public string Description { get; set; }
    }
}

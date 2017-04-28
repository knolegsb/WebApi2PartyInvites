﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2PartyInvites.Infrastructure.Identity
{
    public class StoreRole : IdentityRole
    {
        public StoreRole() : base() { }
        public StoreRole(string name) : base(name) { }
    }
}
﻿using System;
using Umbraco.Core;
using Umbraco.Core.Models.Membership;
using Umbraco.Core.Security;

namespace Umbraco.Web.Security
{

    // NOTE: Moved to netcore
    public class BackOfficeSecurity : IBackOfficeSecurity
    {
        public IUser CurrentUser => throw new NotImplementedException();

        public Attempt<int> GetUserId()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated()
        {
            throw new NotImplementedException();
        }

        public bool UserHasSectionAccess(string section, IUser user)
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using Umbraco.Core.DependencyInjection;

namespace Umbraco.Web.BackOffice.Security
{
    public static class AuthenticationBuilderExtensions
    {
        public static IUmbracoBuilder AddBackOfficeExternalLogins(this IUmbracoBuilder umbracoBuilder, Action<BackOfficeExternalLoginsBuilder> builder)
        {
            builder(new BackOfficeExternalLoginsBuilder(umbracoBuilder.Services));
            return umbracoBuilder;
        }
    }

}

using Business.Contracts;
using Business.Implementations;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Services.Security
{
    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {

        public override async System.Threading.Tasks.Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string role = context.Parameters.Where(f => f.Key == "role").Select(f => f.Value).SingleOrDefault()[0];
            context.OwinContext.Set<string>("Role", role);

            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            string role = context.OwinContext.Get<string>("Role");
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("email", context.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Role, role));
            context.Validated(identity);
        }
    }
}
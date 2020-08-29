using IdentityModel;
using IdentityServer4.Models;

namespace Is4RoleDemo
{
    public sealed class ProfileWithIdentityResource : IdentityResources.Profile
    {
        public ProfileWithIdentityResource()
        {
            this.UserClaims.Add(JwtClaimTypes.Role);
        }
    }
}

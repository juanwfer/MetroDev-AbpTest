using Abp.Authorization;
using MetroDev.Boilerplate.Authorization.Roles;
using MetroDev.Boilerplate.Authorization.Users;

namespace MetroDev.Boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

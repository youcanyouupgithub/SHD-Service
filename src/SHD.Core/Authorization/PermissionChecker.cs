using Abp.Authorization;
using SHD.Authorization.Roles;
using SHD.Authorization.Users;

namespace SHD.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

using Abp.Authorization;
using IS.Authorization.Roles;
using IS.Authorization.Users;

namespace IS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

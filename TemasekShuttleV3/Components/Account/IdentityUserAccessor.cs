using TemasekShuttleV3.Data;
using Microsoft.AspNetCore.Identity;

namespace TemasekShuttleV3.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<TemasekShuttleV3User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<TemasekShuttleV3User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}

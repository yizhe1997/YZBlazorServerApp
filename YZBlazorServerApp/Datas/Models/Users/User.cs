using Microsoft.AspNetCore.Identity;

namespace YZBlazorServerApp.Datas.Models.Users
{
    public class User : IdentityUser<Guid>
    {
        private static readonly string DefaultUserName = "Please update user name!";

        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public override string UserName { get; set; } = DefaultUserName;
        public DateTime? LastLoggedIn { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace RedDress.Core.Entities
{
    public class UserAccount : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int RoleId { get; set; }

        // You can add additional properties as needed
        public virtual Role Role { get; set; }
    }
}

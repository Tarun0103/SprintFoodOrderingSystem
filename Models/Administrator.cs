#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Administrator
    {
        public int UserId { get; set; }
        public string AdminPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long? Mobile { get; set; }
    }
}

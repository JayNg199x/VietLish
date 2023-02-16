#nullable disable

namespace ELearning.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool? Status { get; set; }

        public virtual Role Role { get; set; }
    }
}

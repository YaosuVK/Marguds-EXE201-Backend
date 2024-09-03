using System.ComponentModel.DataAnnotations;

namespace Marguds_BussinessObject.ViewModels
{
    public class UserInfo
    {
        public Guid? AccountID { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Role { get; set; }
        public string? Image { get; set; }
        public string? Status { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}

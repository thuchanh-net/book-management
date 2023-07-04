using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NPBookManagement.Models.Users
{
    [Serializable]
    public sealed class LoginModel
    {
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        public string? Username { get; set; }

        [DisplayName("Mật khẩu")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string? Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RoomRoostHotel.WEBUI.Dtos.RegisterDto
{
    public class CreateAppUserDto
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail gereklidir.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrarı gereklidir.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}

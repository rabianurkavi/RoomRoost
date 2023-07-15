using System.ComponentModel.DataAnnotations;

namespace RoomRoostHotel.WEBUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet için icon linki giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir.")]

        public string ServiceTitle { get; set; }
        [Required(ErrorMessage = "Servis için icon linki giriniz.")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir.")]
        public string Description { get; set; }
    }
}

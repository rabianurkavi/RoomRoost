﻿using System.ComponentModel.DataAnnotations;

namespace RoomRoostHotel.WEBUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet için icon linki giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir.")]
        public string ServiceTitle { get; set; }
        [Required(ErrorMessage = "Servis için icon linki giriniz.")]

        public string Description { get; set; }
    }
}

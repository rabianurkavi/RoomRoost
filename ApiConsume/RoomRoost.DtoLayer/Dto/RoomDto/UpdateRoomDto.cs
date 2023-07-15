using DiscordRPC.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.DtoLayer.Dto.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
        public string RooomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
       
        public int RoomPrice { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı  giriniz.")]
        [StringLength(20, ErrorMessage = "Bir hata meydana geldi, lütfen tekrar deneyin.")]
        public string RoomTitle { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string RoomDescription { get; set; }
    }
}

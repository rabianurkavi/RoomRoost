namespace RoomRoostHotel.WEBUI.Dtos.AboutDto
{
    public class ResultAboutDto
    {
        public int AboutID { get; set; }
        public string AboutSmallTitle { get; set; }
        public string AboutLargeTitle { get; set; }
        public string AboutContent { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}

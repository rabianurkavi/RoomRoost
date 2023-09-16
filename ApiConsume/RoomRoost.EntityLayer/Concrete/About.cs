using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.EntityLayer.Concrete
{
    public class About
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

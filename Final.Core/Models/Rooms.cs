using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Core.Models
{
   public class Rooms
    {
        public int Id { get; set; }
        public string RoomId { get; set; }
        public string Type { get; set; }
        public string RoomName { get; set; }
        public double? Price { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public DateTime? DateRegister { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateDelete { get; set; }
    }

}

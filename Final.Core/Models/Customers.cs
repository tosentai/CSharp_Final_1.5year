using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Core.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string RoomID { get; set; }
        public decimal? Price { get; set; }
        public string StatusPayment { get; set; }
        public string Status { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? DateBook { get; set; }
    }
}

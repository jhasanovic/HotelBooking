using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; } 
        public string Email { get; set; }
 
        public Guest() { }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [ForeignKey("Room")]
        public int RoomID { get; set; }
        public Room Room { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double TotalPrice { get; set; }

        [ForeignKey("Guest")]
        public int GuestID { get; set; }
        public Guest Guest { get; set; }    

        [EnumDataType(typeof(ReservationStatus))]
        public ReservationStatus ReservationStatus { get; set; }

        public Reservation() { }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models

{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [EnumDataType(typeof(RoomType))]
        public RoomType RoomType { get; set; }

        public int NumberOfBeds { get; set; }

        public double pricePerNight { get; set; }

        [EnumDataType(typeof(RoomStatus))]
        public RoomStatus RoomStatus { get; set; }

        [ForeignKey("Guest")]
        public int? RoomOccupantID { get; set; }
        public Guest Guest { get; set; }

        [EnumDataType(typeof(RoomViewOrientation))]
        public RoomViewOrientation RoomViewOrientation { get; set; }

        public bool HasBalcony { get; set; }

        public Room() { }
    }
}


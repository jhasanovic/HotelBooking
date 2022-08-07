using System;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class HotelStaff
    {
        [Key]
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime EmployedSince { get; set; }
        public double Salary { get; set; }

        [EnumDataType(typeof(StaffStatus))]
        public StaffStatus StaffStatus { get; set; }

        public HotelStaff() { }
    }
}

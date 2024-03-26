using System.ComponentModel.DataAnnotations;

namespace RailwayTicketReservation.Models.Data
{
    public class Passenger
    {
        [Key]
        public int Passenger_Id { get; set; }
        public string Passenger_Name {  get; set; }
        public int Age {  get; set; }
        public int Seat_No { get; set; }
        public string Booking_status {  get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RailwayTicketReservation.Models.Data
{
    public class ReserveTicket
    {
        [Key]
       public int Ticket_Id { get; set; }
        public string From_Station { get; set; }
        public string To_Station { get; set; }
        public DateOnly Departure_Time { get; set; }
        public DateOnly Return { get; set; }
        public string Age_Group {  get; set; }
        public int Seat_Availability { get; set; }
        
        public int Seat_No { get; set; }
        public int Payment { get; set; }


    }
}

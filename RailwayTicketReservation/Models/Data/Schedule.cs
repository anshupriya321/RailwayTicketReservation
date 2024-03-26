using System.ComponentModel.DataAnnotations;

namespace RailwayTicketReservation.Models.Data
{
    public class Schedule
    {
        [Key]
        public int Train_No { get; set; }
        public string Train_Name { get; set; }
      
        public string Time {  get; set; }
       

    }
}

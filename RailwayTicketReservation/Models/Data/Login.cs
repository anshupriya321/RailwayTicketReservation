using System.ComponentModel.DataAnnotations;

namespace RailwayTicketReservation.Models.Data
{
    public class Login
    {
        [Key]
       public string UserName {  get; set; }
        
       public string Password { get; set; }
    }
}

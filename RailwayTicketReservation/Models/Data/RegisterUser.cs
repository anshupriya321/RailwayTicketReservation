using System.ComponentModel.DataAnnotations;

namespace RailwayTicketReservation.Models.Data
{
    public class RegisterUser
    {
      
        public string First_Name {  get; set; }

        public string Last_Name { get; set; }

        public int MobileNo {get; set; }

        public string EmailId { get; set; }

        [Key]
        public string UserName { get; set; }
        
        public string Password { get; set; }

        public string DateOfBirth { get; set; }

    }
}

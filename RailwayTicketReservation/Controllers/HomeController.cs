using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RailwayTicketReservation.Models;
using RailwayTicketReservation.Models.Data;
using System.Diagnostics;

namespace RailwayTicketReservation.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ReservationDbContext _reservationDbContext;
        public HomeController(ReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var users = _reservationDbContext.UserRegistration.FirstOrDefault(x => x.UserName == username);
            var pass = _reservationDbContext.UserRegistration.FirstOrDefault(x => x.Password == password);

            if (users != null && pass != null)
            {

                return RedirectToAction("BookYourTicket");
            }
            else
            {
                ModelState.AddModelError("CustomError", "Invalid username or password");
            }
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(RegisterUser registerUser)
        {


            await _reservationDbContext.UserRegistration.AddAsync(registerUser);
            await _reservationDbContext.SaveChangesAsync();
            return RedirectToAction("Login");
        }
        public IActionResult BookYourTicket()
        {
            return View();
        }
        public IActionResult Schedule()
        {
            var trainList = _reservationDbContext.trains.ToList();


            return View(trainList);
        }
        public IActionResult payment()
        {
            return View();
        }
        
        public IActionResult ShowTicket()
        {
            return View();
        }

        public IActionResult TicketStatus()
        {
            return View();
        }


        public async Task<IActionResult> TicketStatusOne(int train_No)
        {
            var listOfEmployees = await _reservationDbContext.trains.FirstOrDefaultAsync(x => x.Train_No == train_No);
            ViewBag.Message = listOfEmployees;
            return View("TicketStatus");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    public class HomeController:Controller{
        public IActionResult Index(){
            
            int saat = DateTime.Now.Hour;

            
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(info=> info.WillAttend==true).Count();;


            var meetingInfo =new MeetinfInfo(){
                Id=1,
                Location="İstanbul",
                Date = new DateTime(2024,11,05,14,0,0),
                NumberOfPeople=UserCount

            };  

            return View(meetingInfo);
        }
    }
}
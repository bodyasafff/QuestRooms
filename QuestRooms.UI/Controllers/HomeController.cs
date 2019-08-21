using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.BLL.Services.Implemetention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService cityService;
        public HomeController()
        {
              
        }
        // GET: Home
        public ActionResult Index()
        {
            //RoomsContext
            return View();
        }
    }
}
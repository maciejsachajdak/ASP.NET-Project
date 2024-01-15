using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Areas.Identity.Data;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    public class ClubsController : Controller
    {
        private readonly AnotherDBContext _contex;
        private readonly UserManager<ApplicationUser> _userManager;
        private int clubID;

        public ClubsController(UserManager<ApplicationUser> userManager, AnotherDBContext contex)
        {
            _userManager = userManager;
            _contex = contex;
        }

        public ActionResult Index()
        {
            return View(_contex.Clubs.ToList());
        }

        public ActionResult OpinionList(int id)
        {
            ViewBag.ClubID = id;
            clubID = id;
            return View(_contex.Opinions.ToList());
        }

        public ActionResult AddOpinion(int id)
        {
            var club = _contex.Clubs.FirstOrDefault(club1 => club1.ID == id);
            var opinion = new Opinion(); 
            return View(new ClubOpinionViewModel { Club = club, Opinion = opinion });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOpinion(Opinion opinion)
        {
            try
            {
                _contex.Opinions.Add(opinion);
                _contex.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public class ClubOpinionViewModel
        {
            public Club Club { get; set; }
            public Opinion Opinion { get; set; }
        }
    }

}

    

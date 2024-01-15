using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Areas.Identity.Data;
using Project.Models;

namespace Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _contex;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly ILogger<UserController> _logger;

        public UserController(UserManager<ApplicationUser> userManager, ApplicationDBContext contex,
            IUserStore<ApplicationUser> userStore, ILogger<UserController> logger)
        {
            _userManager = userManager;
            _contex = contex;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _logger = logger;
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View(_contex.Users.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ApplicationUser user)
        {
            var User = CreateUser();
            User.Login = user.Login;
            User.name = user.name;
            User.surname = user.surname;
            User.address = user.address;
            User.birthdate = user.birthdate;
            User.sex = user.sex;
            User.club = user.club;
            User.Email = user.Email;
            User.Role = "Member";
            await _userStore.SetUserNameAsync(User, user.Login, CancellationToken.None);
            await _emailStore.SetEmailAsync(User, user.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(User, "User123!");
            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");
                await _userManager.AddToRoleAsync(User, User.Role);
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }


            return View();
        }

        public async Task<ActionResult> Details(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            return View(user);
        }


        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationUser user)
        {
            try
            {
                var findUser = _contex.Users.FirstOrDefault(u => u.Id == user.Id);
                findUser.name = user.name;
                findUser.surname = user.surname;
                findUser.address = user.address;
                findUser.sex = user.sex;
                findUser.club = user.club;
                findUser.birthdate = user.birthdate;
                findUser.Email = user.Email;
                _contex.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ApplicationUser user)
        {
            try
            {
                var findUser = _contex.Users.FirstOrDefault(u => u.Id == user.Id);
                _contex.Users.Remove(findUser);
                _contex.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }

            return (IUserEmailStore<ApplicationUser>)_userStore;
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                                                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
    }
}
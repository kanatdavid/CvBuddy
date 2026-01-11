using bla.Model;
using bla.Model.CvInfo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bla.DAL;

namespace bla.Controllers
{
    public class SearchController : HomeController
    {
        public SearchController(UserManager<User> u, CVBuddyContext c, SignInManager<User> sm) : base(u, c, sm)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchTerm)
        {
            try
            {
                List<User> users = await _context.Users
                               .Include(u => u.OneCv)
                               .ThenInclude(cv => cv.Experiences)
                               .Include(u => u.OneCv)
                               .ThenInclude(cv => cv.Education)
                               .Include(u => u.OneCv)
                               .ThenInclude(cv => cv.Skills)
                               .Include(u => u.OneCv)
                               .ThenInclude(cv => cv.Certificates)
                               .Include(u => u.OneCv)
                               .ThenInclude(cv => cv.Interests)
                               .ToListAsync();


                if (User.Identity!.IsAuthenticated)
                {
                    users = users.Where(u => !u.IsDeactivated).ToList();
                }
                else
                {
                    users = users.Where(u => !u.IsDeactivated! && !u.HasPrivateProfile).ToList();
                }

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {                                                                                           //Split delar upp strängen vid varje mellanslag
                    var cleanSearchTerms = searchTerm.Split(" ", StringSplitOptions.RemoveEmptyEntries)     //RemoveEmptyentries tar bort strängar med mellanslag
                        .Select(t => t.ToLower())
                        .ToList();

                    users = users.Where(u =>
                    {
                        if (u.OneCv != null)
                        {
                            return cleanSearchTerms.All(t =>                                                           //All() alla stärngar som användaren skrev måste matcha
                            (u.FirstName ?? "").ToLower().Contains(t) ||                                  //?? "" skyddar mot null om namnet angavs inte i sök strängen
                            (u.LastName ?? "").ToLower().Contains(t) ||                                   //Contains() kollar om strängen finns i LastName, om en av de strängar matchas så returnera user
                            u.OneCv.Experiences.Any(e => (e.Title ?? "").ToLower().Contains(t)));
                        }
                        return cleanSearchTerms.All(t =>                                                          
                            (u.FirstName ?? "").ToLower().Contains(t) ||                                  
                            (u.LastName ?? "").ToLower().Contains(t));                                 
                    }).ToList();
                        
                }

                ViewBag.ResultCount = users.Count() == 0;
                return View(users);
            }
            catch(Exception e)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = e.Message});
            }
            
        }
    }
}
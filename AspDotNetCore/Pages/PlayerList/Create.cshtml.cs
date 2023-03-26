using DataAccessLayer;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspDotNetCore.Pages.PlayerList
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public IplPlayer Player { get; set; }
        ApplicationDbContext db;

        public CreateModel(ApplicationDbContext dbContext)
        {
            db= dbContext;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost() 
            
        {
            var tm = db.IplTeams.FirstOrDefault(x=>x.Name== "Delhi Capitals");
            if (tm != null)
            {
                Player.Team= tm;
                db.IplPlayers.Add(Player);
                db.SaveChanges();
                return RedirectToPage("Index");   
            }
            else
            {
                return Page();
            }
        }


    }
}

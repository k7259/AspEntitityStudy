using DataAccessLayer;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspDotNetCore.Pages.PlayerList
{
    // 1.we need id in this page.
    // 2. we need application db contex in this page.
    public class EditModel : PageModel

	{
		
		ApplicationDbContext db;
		public void OnGet(Guid Id)
        {
            PlayertoEdit=db.IplPlayers.Find(Id);
        }
        public EditModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
            
        }
		[BindProperty]
		public IplPlayer PlayertoEdit { get; set; }

    }

}

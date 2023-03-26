using DataAccessLayer;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspDotNetCore.Pages.PlayerList
{
    public class IndexModel : PageModel
    {
       public List<IplPlayer> players= new List<IplPlayer>();
        ApplicationDbContext db;

		public void OnGet()
      {
   //         IplPlayer player = new IplPlayer();
   //         player.Id= Guid.NewGuid(); 
   //         player.Name="kl rahul";
			//IplPlayer player1 = new IplPlayer();
			//player1.Id = Guid.NewGuid();
			//player1.Name = "Virat Kohli";
			//players.Add(player1);
   //         players.Add(player);
         players= db.IplPlayers.ToList();

 

        }

        public IndexModel(ApplicationDbContext dbContext)
        {
            db= dbContext;
        }
        public IActionResult OnPostDelete(Guid Id)
        {
            var ItemToDelete= db.IplPlayers.FirstOrDefault(p => p.Id==Id);
            if (ItemToDelete!=null)
            {
                db.IplPlayers.Remove(ItemToDelete);
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

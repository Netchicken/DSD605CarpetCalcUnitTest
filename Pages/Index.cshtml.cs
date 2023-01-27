using Dsd601CarpetCalcAsp.Model;
using Dsd601CarpetCalcAsp.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsd601CarpetCalcAsp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Carpet? carpet { get; set; }

        public CarpetOperations carpetOperations = new CarpetOperations();


        public IndexModel()
        {
            carpet = new Carpet();
        }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //calculate the room area
                carpet.RoomArea = carpetOperations.CalcRoomArea(carpet.RoomWidth, carpet.RoomLength);
                carpet.FinalCost = carpetOperations.TotalInstallCost(carpet);
                carpet.Results = carpetOperations.RoomAreaResults(carpet.RoomArea, carpet.FinalCost);

            }
            return Page();
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P3A26RazorPages.Pages
{
    public class PrivacyModel : PageModel
    {
        public string Pozdrav { get; set; } = "I don't know";
        public int Counter { get; set; } = 3;

        [BindProperty(SupportsGet = true)]
        public int Cnt { get; set; } = 5;

        public void OnGet()
        {
            Pozdrav = "Hello from PrivacyModel!";
            Counter = Cnt * 2;
        }
        public void OnGetAnother()
        {
            Pozdrav = "Hello from OnGetAnother!";
            Counter = Cnt;
        }
    }
}

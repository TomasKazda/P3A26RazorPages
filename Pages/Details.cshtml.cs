using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P3A26RazorPages.Pages
{
    public class DetailsModel : PageModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public void OnGet(string? name, string? gender)
        {
            Name = name ?? "Name not found";
            Gender = gender ?? "Gender is ⚲";
        }
    }
}

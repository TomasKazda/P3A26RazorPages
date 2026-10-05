using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace P3A26RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<Person> People { get; set; } = new List<Person>
        {
            new Person { Name = "Alice", Gender = true },
            new Person { Name = "Bob", Gender = false },
            new Person { Name = "Charlie", Gender = false },
            new Person { Name = "Diana", Gender = true }
        };

        [BindProperty(SupportsGet = true)]
        public bool? FilterGender { get; set; } = null;

        public void OnGet()
        {
         
        }

        public IActionResult OnGetDetails(string name)
        {
            var person = People.FirstOrDefault(p => p.Name == name);
            string genderSymbol = "⚲";
            string nameText = "Not Found";
            if (person != null)
            {
                nameText = person.Name;
                genderSymbol = person.Gender ? "♀" : "♂";
            }

            return RedirectToPage("Details", new { name = nameText, gender = genderSymbol });
        }

        public class Person
        {
            public string Name { get; set; }
            public bool Gender { get; set; }
        }
    }
}

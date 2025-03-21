using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Presentation.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            //if (Username == "admin" && Password == "admin")
            //{
            //    //redirect to home 
            //    return RedirectToPage("Index");
            //}

            ErrorMessage = "Invalid username or password.";
            return Page();
        }
    }
}

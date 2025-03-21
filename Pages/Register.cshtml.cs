using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyApp.Presentation.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Username")]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet()
        {

        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new User
        //        {
        //            UserName = Input.UserName,
        //            Email = Input.Email
        //        };

        //        var passwordHasher = new PasswordHasher<User>();
        //        user.Password = passwordHasher.HashPassword(user, Input.Password);

        //        //_context.Users.Add(user);
        //        //await _context.SaveChangesAsync();

        //        return RedirectToPage("/Login");
        //    }

        //    return Page();
        //}
    }
}

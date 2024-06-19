using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;
using System.Text.Json;

namespace BBMSRazorPages.Pages.Authentication
{
    public class LoginModel : PageModel
    {
        private readonly IUserService userService;

        [BindProperty]
        public User LoginUser { get; set; }
        public string Message { get; set; }
        public LoginModel(IUserService userService)
        {
            this.userService = userService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            User user = userService.GetUserByEmail(LoginUser.Email);
            if(user != null)
            {
                if(user.Email.Equals(LoginUser.Email))
                {
                    HttpContext.Session.SetString("SessionAccount", JsonSerializer.Serialize(user));
                    return RedirectToPage("/Index");
                }
                else
                {
                    Message = "Wrong email or password";
                    return RedirectToPage("/Authentication/Login", Message);
                }
            }
            else
            {
                return RedirectToPage("/Authentication/Login", Message);
            }
        }
    }
}

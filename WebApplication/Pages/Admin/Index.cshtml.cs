using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages.Admin
{
    public class IndexModel : PageModel
    {
        //[BindProperty]
        //public Compte compte { get; set; }
        public IActionResult OnGet()
        {
            if(HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("./Admin/Students");
            }
            else
            {
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(string username, string password, string ReturnUrl)
        {

            if (username == "admin")
            {

                var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.
                AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl == null ? "/Admin/Students" : ReturnUrl);
            }

            return Page();
        }

        /*public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return(Page());
            if (compte.login == "admin" && compte.mdp == "adminpassword")
            {
                return RedirectToPage("/Students/Index");
            }
            return (Page());
        }
    }*/

        /* public class Compte
         {
             [Required]
             public string login { get; set; }
             [Required]
             [DataType(DataType.Password)]
             [Display(Name ="password")]
             public string mdp { get; set; }
         }*/
    }
}
